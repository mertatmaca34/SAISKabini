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

        public void SendDataSave(SendData data)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spVeriKaydet", sqlConnection)
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

        public string GunlukYikamaGetir()
        {
            string res = "-";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spGunlukYikamaGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    res = reader["ReadTime"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                sqlConnection.Close();
            }

            return res;

        }

        public string HaftalikYikamaGetir()
        {
            string res = "-";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spHaftalikYikamaGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    res = reader["ReadTime"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                sqlConnection.Close();
            }

            return res;
        }

        public object IstasyonBilgiGetir()
        {
            StationInfo istasyonBilgileri = new StationInfo();

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spIstasyonBilgiGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    istasyonBilgileri.istasyonAdi = reader["istasyonAdi"].ToString();
                    istasyonBilgileri.istasyonIp = reader["istasyonIp"].ToString();
                    istasyonBilgileri.simId = reader["istasyonSimId"].ToString();

                    istasyonBilgileri.kullaniciAdi = reader["simKullaniciAdi"].ToString();
                    istasyonBilgileri.kullaniciSifresi = reader["simKullaniciSifresi"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                sqlConnection.Close();
            }

            return istasyonBilgileri;
        }

        public object NumuneBİlgiGetir()
        {
            SampleInfo numuneBilgileri = new SampleInfo();

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spNumuneBilgiGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    numuneBilgileri.tetik = reader["Tetik"].ToString();
                    numuneBilgileri.deger = (double)reader["Deger"];
                    numuneBilgileri.baslamaTarihi = (DateTime)reader["BaslamaTarihi"];

                    numuneBilgileri.bitisTarihi = (DateTime)reader["BitisTarihi"];
                    numuneBilgileri.dolapSicakligi = (double)reader["DolapSicakligi"];
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                sqlConnection.Close();
            }

            return numuneBilgileri;
        }
    }
}
