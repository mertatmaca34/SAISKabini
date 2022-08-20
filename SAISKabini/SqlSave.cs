using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SAISKabini
{
    internal class SqlSave
    {
        readonly static string pcName = Environment.MachineName;
        readonly SqlConnection sqlConnection = new SqlConnection("Data Source=" + pcName + "\\SQLEXPRESS;Initial Catalog=SAISKabini;Integrated Security=True");

        public void sendDataSave(SendData data)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spDakikalikVeriKaydet", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                sqlCommand.Parameters.AddWithValue("@ReadTime", data.Readtime);
                sqlCommand.Parameters.AddWithValue("@Stationid", data.Stationid);
                sqlCommand.Parameters.AddWithValue("@SoftwareVersion", data.SoftwareVersion);
                sqlCommand.Parameters.AddWithValue("@Period", data.Period);
                sqlCommand.Parameters.AddWithValue("@AkisHizi", data.AkisHizi);
                sqlCommand.Parameters.AddWithValue("@AKM", data.AKM);
                sqlCommand.Parameters.AddWithValue("@CozunmusOksijen", data.CozunmusOksijen);
                sqlCommand.Parameters.AddWithValue("@Debi", data.Debi);
                sqlCommand.Parameters.AddWithValue("@KOi", data.KOi);
                sqlCommand.Parameters.AddWithValue("@pH", data.pH);
                sqlCommand.Parameters.AddWithValue("@Sicaklik", data.Sicaklik);
                sqlCommand.Parameters.AddWithValue("@Iletkenlik", data.Iletkenlik);
                sqlCommand.Parameters.AddWithValue("@Status", data.AKM_Status);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("İşlem Yapıldı");

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: Veritabanına bilgiler kaydedilirken hata oluştu. Detay: " + ex.Message);
            }
        }
    }
}
