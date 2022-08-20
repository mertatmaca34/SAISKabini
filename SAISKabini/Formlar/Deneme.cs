using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace SAISKabini
{
    public partial class Deneme : Form
    {
        private protected ServicesModel Services { get; set; }

        public Deneme()
        {
            InitializeComponent();

            this.Services = new ServicesModel("https://entegrationsais.csb.gov.tr/", StationType.SAIS);
        }

        PlcOps plc = new PlcOps();
        private void baglan_Click(object sender, EventArgs e)
        {
            Services.Login("istanbul_pasakoy", "1q2w3e");


            var data = new SendData
            {
                Readtime = DateTime.Now,
                Stationid = new Guid("9f3950ef-147a-46a5-ae5c-cb3c5028d829"),
                SoftwareVersion = "1.0.0",
                Period = 1,
                AkisHizi = 5,
                AkisHizi_Status = 1,
                AKM = 5,
                AKM_Status = 1,
                CozunmusOksijen = 5,
                CozunmusOksijen_Status = 1,
                Debi = 5,
                Debi_Status = 1,
                DesarjDebi = 5,
                DesarjDebi_Status = 1,
                KOi = 5,
                KOi_Status = 1,
                pH = 1,
                pH_Status = 1,
                Sicaklik = 5,
                Sicaklik_Status = 1,
                Iletkenlik = 5,
                Iletkenlik_Status = 1
            };


            var res = Services.sendData(data);

            if (res.result)
            {
                string cevap = res.objects.ToString();

                var donenObje = JsonConvert.DeserializeObject<DeserializeResult>(cevap);

                sonuc.Text = donenObje.AKM_N_Status.ToString();

                plc.SetGunlukYikama();
            }
            else
            {
                MessageBox.Show("Az bekle");
            }

        }

        private void yikama_Click(object sender, EventArgs e)
        {
            plc.SetGunlukYikama();
        }

        private void haftalikyikama_Click(object sender, EventArgs e)
        {
            plc.SetHaftalikYikama();
        }
    }
}
