using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SAISKabini
{
    public partial class Ayarlar_IstasyonAyarlari : Form
    {
        private protected ServicesModel Services { get; set; }

        readonly static string pcName = System.Environment.MachineName;
        readonly SqlConnection sqlConnection = new SqlConnection("Data Source=" + pcName + "\\SQLEXPRESS;Initial Catalog=SAISKabini;Integrated Security=True");

        public Ayarlar_IstasyonAyarlari()
        {
            InitializeComponent();

            this.Services = new ServicesModel("https://entegrationsais.csb.gov.tr/", StationType.SAIS);
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spIstasyonAyarKaydet", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                sqlCommand.Parameters.AddWithValue("@istasyonAdi", txt_istasyonAdi.Text);
                sqlCommand.Parameters.AddWithValue("@istasyonIp", txt_istasyonIp.Text);
                sqlCommand.Parameters.AddWithValue("@istasyonSimId", txt_istasyonSimId.Text);
                sqlCommand.Parameters.AddWithValue("@simKullaniciAdi", txt_simKullaniciAdi.Text);
                sqlCommand.Parameters.AddWithValue("@simKullaniciSifresi", txt_simKullaniciSifresi.Text);

                sqlCommand.ExecuteNonQuery();

                //MessageBox.Show("İşlem Yapıldı");

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Hata: Veritabanına bilgiler kaydedilirken hata oluştu. Detay: " + ex.Message);
            }
        }

        private void Ayarlar_IstasyonAyarlari_Load(object sender, EventArgs e)
        {
            var bgw_formYukle = new BackgroundWorker();

            bgw_formYukle.DoWork += delegate
            {
                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spIstasyonBilgiGetir", sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParameter = new SqlParameter();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        txt_istasyonAdi.Text = reader["istasyonAdi"].ToString();
                        txt_istasyonIp.Text = reader["istasyonIp"].ToString();
                        txt_istasyonSimId.Text = reader["istasyonSimId"].ToString();
                        txt_simKullaniciAdi.Text = reader["simKullaniciAdi"].ToString();
                        txt_simKullaniciSifresi.Text = reader["simKullaniciSifresi"].ToString();
                    }

                    sqlCommand.ExecuteNonQuery();

                    //MessageBox.Show("İşlem Yapıldı");

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Hata: Veritabanına bilgiler kaydedilirken hata oluştu. Detay: " + ex.Message);
                }
            };
            bgw_formYukle.RunWorkerAsync();
        }
    }
}
