using Sharp7;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace SAISKabini
{
    public partial class Simulasyon : Form
    {
        #region Yuvarlak Köşe DLL eklentisi
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        #endregion

        #region PLC Bağlantısı

        static S7Client client = new S7Client();
        public int plcResult = client.ConnectTo("10.33.3.253", 0, 1);

        #endregion

        #region Değişkenler

        public byte[] db1Buffer = new byte[30];

        public byte[] db41Buffer = new byte[148];

        public byte[] mb1Buffer = new byte[30];

        public string bgImageName, bgPompaName, bgTankName;

        #endregion

        public Simulasyon()
        {
            InitializeComponent();

            #region Default Form Stilleri

            tblLayP_donenCevaplar.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tblLayP_donenCevaplar.Width, tblLayP_donenCevaplar.Height, 20, 20));
            tblLayP_kabinDurumu.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tblLayP_kabinDurumu.Width, tblLayP_kabinDurumu.Height, 20, 20));
            tblLayP_yikamaBilgileri.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tblLayP_yikamaBilgileri.Width, tblLayP_yikamaBilgileri.Height, 20, 20));

            #endregion
        }

        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            #region PLC'den Çekilen Değerlerin Ekranda Gösterimi

            //Database bağlantısı

            plcResult = client.DBRead(41, 0, db41Buffer.Length, db41Buffer);

            #region Real Değerler

            //Çekilen real değerlerin değişkenlere atanması

            double akmValue = Math.Round(S7.GetRealAt(db41Buffer, 36), 2);
            lbl_akmValue.Text = akmValue + " mg/l";

            double oksijenValue = Math.Round(S7.GetRealAt(db41Buffer, 24), 2);
            lbl_oksijenValue.Text = oksijenValue + " mg/l";

            double debiValue = Math.Round(S7.GetRealAt(db41Buffer, 0), 2);
            //buraya eklenecek

            double KOiValue = Math.Round(S7.GetRealAt(db41Buffer, 32), 2);
            lbl_koiValue.Text = KOiValue + " mg/l";

            double phValue = Math.Round(S7.GetRealAt(db41Buffer, 16), 2);
            lbl_phValue.Text = phValue.ToString();

            double sicaklikValue = Math.Round(S7.GetRealAt(db41Buffer, 28), 2);
            lbl_sicaklikValue.Text = sicaklikValue + "°C";

            double iletkenlikValue = Math.Round(S7.GetRealAt(db41Buffer, 20), 1);
            lbl_iletkenlikValue.Text = iletkenlikValue + " mS/cm";

            double akisHiziValue = Math.Round(S7.GetRealAt(db41Buffer, 4), 2);
            lbl_akisHiziValue.Text = akisHiziValue + " m/s";

            double nemValue = Math.Round(S7.GetRealAt(db41Buffer, 44), 2);
            lbl_nemValue.Text = nemValue + "%";

            //Pompa Hz Değerleri

            double pompa1Hz = Math.Round(S7.GetRealAt(db41Buffer, 140), 2);
            double pompa2Hz = Math.Round(S7.GetRealAt(db41Buffer, 144), 2);

            #endregion

            #region Bit Değerler

            plcResult = client.EBRead(0, db1Buffer.Length, db1Buffer);

            bool kapiValue = S7.GetBitAt(db1Buffer, 25, 5);

            bool dumanValue = S7.GetBitAt(db1Buffer, 1, 1);

            bool suBaskiniValue = S7.GetBitAt(db1Buffer, 0, 7);

            bool acilStopValue = S7.GetBitAt(db1Buffer, 25, 7);

            bool pompa1TermikValue = S7.GetBitAt(db1Buffer, 27, 5);

            bool pompa2TermikValue = S7.GetBitAt(db1Buffer, 28, 0);

            bool temizSuTermikValue = S7.GetBitAt(db1Buffer, 28, 2);

            bool yikamaTankiValue = S7.GetBitAt(db1Buffer, 28, 3);

            bool pompa1Value = S7.GetBitAt(db1Buffer, 27, 4);

            bool pompa2Value = S7.GetBitAt(db1Buffer, 27, 7);

            //Durum Değerleri

            plcResult = client.MBRead(0, mb1Buffer.Length, mb1Buffer);

            bool yikamaStat = S7.GetBitAt(mb1Buffer, 24, 1);

            bool haftalikYikamaStat = S7.GetBitAt(mb1Buffer, 24, 2);

            bool autoStat = S7.GetBitAt(mb1Buffer, 10, 6);

            bool bakimStat = S7.GetBitAt(mb1Buffer, 10, 4);

            bool kalibrasyonStat = S7.GetBitAt(mb1Buffer, 10, 5);


            #region Değerlerin İşlenmesi/Koşullar

            #region Durumlara Göre Görsel Değişiklikler

            if (kapiValue == false && autoStat == true && bgImageName != "panel_bakanlikkabini_dolu")
            {
                panel_simulasyon.BackgroundImage = SAISKabini.Properties.Resources.panel_bakanlikkabini_dolu;
                bgImageName = "panel_bakanlikkabini_dolu";
            }

            else if (kapiValue == true && autoStat == true && bgImageName != "panel_bakanlikkabini_dolu_kapiacik")
            {
                panel_simulasyon.BackgroundImage = SAISKabini.Properties.Resources.panel_bakanlikkabini_dolu_kapiacik;
                bgImageName = "panel_bakanlikkabini_dolu_kapiacik";
            }

            else if (kapiValue == false && (yikamaStat == true || haftalikYikamaStat == true) && bgImageName != "panel_bakanlikkabini_dolu_yikama")
            {
                panel_simulasyon.BackgroundImage = SAISKabini.Properties.Resources.panel_bakanlikkabini_dolu_yikama;
                bgImageName = "panel_bakanlikkabini_dolu_yikama";
                MessageBox.Show(kapiValue.ToString());
            }

            else if (kapiValue == true && (yikamaStat == true || haftalikYikamaStat == true) && bgImageName != "panel_bakanlikkabini_doluyikama_kapiacik")
            {
                panel_simulasyon.BackgroundImage = SAISKabini.Properties.Resources.panel_bakanlikkabini_doluyikama_kapiacik;
                bgImageName = "panel_bakanlikkabini_doluyikama_kapiacik";
                MessageBox.Show(kapiValue.ToString());
            }

            else if (kapiValue == false && bakimStat == true && kalibrasyonStat == true && bgImageName != "panel_bakanlikkabini_bos")
            {
                panel_simulasyon.BackgroundImage = SAISKabini.Properties.Resources.panel_bakanlikkabini_bos;
                bgImageName = "panel_bakanlikkabini_bos";
            }

            else if (kapiValue == true && bakimStat == true && kalibrasyonStat == true && bgImageName != "panel_bakanlikkabini_bos_kapiacik")
            {
                panel_simulasyon.BackgroundImage = SAISKabini.Properties.Resources.panel_bakanlikkabini_bos_kapiacik;
                bgImageName = "panel_bakanlikkabini_bos_kapiacik";
            }


            if(yikamaTankiValue == false && bgTankName != "tank_dolu")
            {
                pic_yikamaTanki.BackgroundImage = SAISKabini.Properties.Resources.tank_dolu;
                bgTankName = "tank_dolu";
            }
            else if(yikamaTankiValue == true && bgTankName != "tank_bos")
            {
                pic_yikamaTanki.BackgroundImage = SAISKabini.Properties.Resources.tank_bos;
                bgTankName = "tank_bos";
            }

            #endregion

            #region Durumlara Göre Yazısal Değişiklikler

            if (pompa1Value == true && bgPompaName != "pump2_anim")
            {
                lbl_aktifPompaValue.Text = "Pompa 1";
                lbl_pompaHzValue.Text = pompa1Hz + "Hz";
                pic_pompa1.Image = SAISKabini.Properties.Resources.pump1_anim;
                pic_pompa2.Image = SAISKabini.Properties.Resources.pump2_idle;
                bgPompaName = "pump2_anim";
            }
            else if (pompa2Value == true && bgPompaName != "pump1_anim")
            {
                lbl_aktifPompaValue.Text = "Pompa 2";
                lbl_pompaHzValue.Text = pompa2Hz + "Hz";
                pic_pompa1.Image = SAISKabini.Properties.Resources.pump1_idle;
                pic_pompa2.Image = SAISKabini.Properties.Resources.pump2_anim;
                bgPompaName = "pump1_anim";
            }
            #endregion

            #region Yan Panel Değişiklikleri

            #endregion

            #endregion

            #endregion

            #endregion
        }

        private void tblLayP_kabinDurumu_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row % 2 == 0)
            {
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.CellBounds);
            }
            else if (e.Row % 2 == 1)
            {
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            }
        }

        private void tblLayP_yikamaBilgileri_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row % 2 == 0)
            {
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.CellBounds);
            }
            else if (e.Row % 2 == 1)
            {
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            }
        }

        private void tblLayP_donenCevaplar_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row % 2 == 0)
            {
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.CellBounds);
            }
            else if (e.Row % 2 == 1)
            {
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            }
        }

        private void timer_PlcConnect_Tick(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }
    }
}
