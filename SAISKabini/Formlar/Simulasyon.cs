using SAISKabini.Entities;
using Sharp7;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SAISKabini
{
    public partial class Simulasyon : Form
    {
        private protected ServicesModel Services { get; set; }

        readonly UserInfo userInfo = new UserInfo();

        readonly SqlSave sqlSave = new SqlSave();

        readonly FormStyles formStyles = new FormStyles();

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


        #region Değişkenler

        public string bgImageName, bgPompaName, bgTankName;

        #endregion

        public Simulasyon()
        {
            InitializeComponent();

            #region Default Form Stilleri

            tblLayP_donenCevaplar.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tblLayP_donenCevaplar.Width, tblLayP_donenCevaplar.Height, 20, 20));
            tblLayP_kabinDurumu.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tblLayP_kabinDurumu.Width, tblLayP_kabinDurumu.Height, 20, 20));
            tblLayP_kalibrasyonBilgileri.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tblLayP_kalibrasyonBilgileri.Width, tblLayP_kalibrasyonBilgileri.Height, 20, 20));

            #endregion

            this.Services = new ServicesModel("https://entegrationsais.csb.gov.tr/", StationType.SAIS);


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

        private void Timer_SendData_Tick(object sender, EventArgs e)
        {
            var BgwSendData = new BackgroundWorker();

            BgwSendData.DoWork += delegate
            {
                DeserializeResult deserializeResult = new DeserializeResult();

                deserializeResult.AKM_N_Status = sqlSave.DonenVeriGetir();

                if (deserializeResult.AKM_N_Status == 1)
                {
                    lbl_CevapVeriSagligi.Text = "Geçerli Veri";
                    lbl_CevapGunlukYikama.Text = "Geçerli Yıkama";
                    lbl_CevapHaftalikYikama.Text = "Geçerli Haftalık Yıkama";
                    lbl_CevapKalibrasyon.Text = "Geçerli Kalibrasyon";
                    lbl_CevapAkisHizi.Text = "Geçerli Akış Hızı";
                    lbl_CevapTekrarVeri.Text = "Geçerli Veri";
                    tblLayP_donenCevaplar.Refresh();
                }
                else if (deserializeResult.AKM_N_Status == 200)
                {
                    lbl_CevapVeriSagligi.Text = "Geçersiz Veri";
                    lbl_CevapGunlukYikama.Text = "Geçersiz Yıkama";
                    lbl_CevapHaftalikYikama.Text = "Geçerli Haftalık Yıkama";
                    lbl_CevapKalibrasyon.Text = "Geçerli Kalibrasyon";
                    lbl_CevapAkisHizi.Text = "Geçerli Akış Hızı";
                    lbl_CevapTekrarVeri.Text = "Geçerli Veri";

                    //plcOps.SetGunlukYikama();

                    tblLayP_donenCevaplar.Refresh();
                }
                else if (deserializeResult.AKM_N_Status == 201)
                {
                    lbl_CevapVeriSagligi.Text = "Geçersiz Veri";
                    lbl_CevapGunlukYikama.Text = "Geçerli Yıkama";
                    lbl_CevapHaftalikYikama.Text = "Geçersiz Haftalık Yıkama";
                    lbl_CevapKalibrasyon.Text = "Geçerli Kalibrasyon";
                    lbl_CevapAkisHizi.Text = "Geçerli Akış Hızı";
                    lbl_CevapTekrarVeri.Text = "Geçerli Veri";

                    //plcOps.SetHaftalikYikama();

                    tblLayP_donenCevaplar.Refresh();

                }
                else if (deserializeResult.AKM_N_Status == 202)
                {
                    lbl_CevapVeriSagligi.Text = "Geçersiz Veri";
                    lbl_CevapGunlukYikama.Text = "Geçerli Yıkama";
                    lbl_CevapHaftalikYikama.Text = "Geçerli Haftalık Yıkama";
                    lbl_CevapKalibrasyon.Text = "Geçersiz Kalibrasyon";
                    lbl_CevapAkisHizi.Text = "Geçerli Akış Hızı";
                    lbl_CevapTekrarVeri.Text = "Geçerli Veri";
                    tblLayP_donenCevaplar.Refresh();
                }
                else if (deserializeResult.AKM_N_Status == 203)
                {
                    lbl_CevapVeriSagligi.Text = "Geçersiz Veri";
                    lbl_CevapGunlukYikama.Text = "Geçerli Yıkama";
                    lbl_CevapHaftalikYikama.Text = "Geçerli Haftalık Yıkama";
                    lbl_CevapKalibrasyon.Text = "Geçerli Kalibrasyon";
                    lbl_CevapAkisHizi.Text = "Geçersiz Akış Hızı";
                    lbl_CevapTekrarVeri.Text = "Geçerli Veri";
                    tblLayP_donenCevaplar.Refresh();
                }
                else if (deserializeResult.AKM_N_Status == 205)
                {
                    lbl_CevapVeriSagligi.Text = "Geçersiz Veri";
                    lbl_CevapGunlukYikama.Text = "Geçerli Yıkama";
                    lbl_CevapHaftalikYikama.Text = "Geçerli Haftalık Yıkama";
                    lbl_CevapKalibrasyon.Text = "Geçerli Kalibrasyon";
                    lbl_CevapAkisHizi.Text = "Geçerli Akış Hızı";
                    lbl_CevapTekrarVeri.Text = "Geçersiz Veri";
                    tblLayP_donenCevaplar.Refresh();
                }
                else
                {
                    lbl_CevapVeriSagligi.Text = "Geçerli Veri";
                    lbl_CevapGunlukYikama.Text = "Geçerli Yıkama";
                    lbl_CevapHaftalikYikama.Text = "Geçerli Haftalık Yıkama";
                    lbl_CevapKalibrasyon.Text = "Geçerli Kalibrasyon";
                    lbl_CevapAkisHizi.Text = "Geçerli Akış Hızı";
                    lbl_CevapTekrarVeri.Text = "Geçerli Veri";
                    tblLayP_donenCevaplar.Refresh();
                }

                lbl_LastQuery.Text = "Son Sorgu: " + sqlSave.DonenVeriGetirTarih().ToString("t");

                lbl_AKM.Text = sqlSave.SonKalibrasyonAkmGetir();
                lbl_KOi.Text = sqlSave.SonKalibrasyonKoiGetir();
                lbl_Iletkenlik.Text = sqlSave.SonKalibrasyonIletkenlikGetir();
                lbl_pH.Text = sqlSave.SonKalibrasyonpHGetir();
            };

            BgwSendData.RunWorkerAsync();
        }

        private void Simulasyon_Load(object sender, EventArgs e)
        {
            tblLayP_donenCevaplar.CellPaint += new TableLayoutCellPaintEventHandler(tblLayP_donenCevaplar_CellPaint);
        }

        private void tblLayP_kabinDurumu_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (lbl_Duman.Text == "-" && e.Row % 2 == 0)
            {
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.CellBounds);
            }
            if (lbl_Duman.Text == "Duman yok" && e.Row == 2)
            {
                e.Graphics.FillRectangle(Brushes.SpringGreen, e.CellBounds);
            }
            else if (lbl_Duman.Text == "DUMAN VAR!" && e.Row == 2)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.CellBounds);
            }

            if (lbl_SuBaskini.Text == "Su Baskını yok" && e.Row == 4)
            {
                e.Graphics.FillRectangle(Brushes.SpringGreen, e.CellBounds);
            }
            else if (lbl_SuBaskini.Text == "SU BASKINI VAR!" && e.Row == 4)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.CellBounds);
            }

            if (lbl_AcilStop.Text == "Acil Stop yok" && e.Row == 6)
            {
                e.Graphics.FillRectangle(Brushes.SpringGreen, e.CellBounds);
            }
            else if (lbl_AcilStop.Text == "ACİL STOP!" && e.Row == 6)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.CellBounds);
            }

            if (lbl_Enerji.Text == "Enerji var" && e.Row == 8)
            {
                e.Graphics.FillRectangle(Brushes.SpringGreen, e.CellBounds);
            }
            else if (lbl_Enerji.Text == "ENERJİ YOK!" && e.Row == 8)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.CellBounds);
            }
        }

        private void tblLayP_kalibrasyonBilgileri_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (lbl_AKM.Text == "-" && e.Row % 2 == 0)
            {
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.CellBounds);
            }
            if (lbl_AKM.Text == "Geçerli" && e.Row == 2)
            {
                e.Graphics.FillRectangle(Brushes.SpringGreen, e.CellBounds);
            }
            else if (lbl_AKM.Text == "Geçersiz" && e.Row == 2)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.CellBounds);
            }

            if (lbl_KOi.Text == "Geçerli" && e.Row == 4)
            {
                e.Graphics.FillRectangle(Brushes.SpringGreen, e.CellBounds);
            }
            else if (lbl_KOi.Text == "Geçersiz" && e.Row == 4)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.CellBounds);
            }

            if (lbl_Iletkenlik.Text == "Geçerli" && e.Row == 6)
            {
                e.Graphics.FillRectangle(Brushes.SpringGreen, e.CellBounds);
            }
            else if (lbl_Iletkenlik.Text == "Geçersiz" && e.Row == 6)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.CellBounds);
            }

            if (lbl_pH.Text == "Geçerli" && e.Row == 8)
            {
                e.Graphics.FillRectangle(Brushes.SpringGreen, e.CellBounds);
            }
            else if (lbl_pH.Text == "Geçersiz" && e.Row == 8)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.CellBounds);
            }
        }

        private void tblLayP_donenCevaplar_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (lbl_CevapAkisHizi.Text == "-" && e.Row % 2 == 0)
            {
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.CellBounds);
            }
            if (lbl_CevapVeriSagligi.Text == "Geçerli Veri" && e.Row == 2)
            {
                e.Graphics.FillRectangle(Brushes.SpringGreen, e.CellBounds);
            }
            else if (lbl_CevapVeriSagligi.Text == "Geçersiz Veri" && e.Row == 2)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.CellBounds);
            }

            if (lbl_CevapGunlukYikama.Text == "Geçerli Yıkama" && e.Row == 4)
            {
                e.Graphics.FillRectangle(Brushes.SpringGreen, e.CellBounds);
            }
            else if (lbl_CevapGunlukYikama.Text == "Geçersiz Yıkama" && e.Row == 4)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.CellBounds);
            }

            if (lbl_CevapHaftalikYikama.Text == "Geçerli Haftalık Yıkama" && e.Row == 6)
            {
                e.Graphics.FillRectangle(Brushes.SpringGreen, e.CellBounds);
            }
            else if (lbl_CevapHaftalikYikama.Text == "Geçersiz Haftalık Yıkama" && e.Row == 6)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.CellBounds);
            }

            if (lbl_CevapKalibrasyon.Text == "Geçerli Kalibrasyon" && e.Row == 8)
            {
                e.Graphics.FillRectangle(Brushes.SpringGreen, e.CellBounds);
            }
            else if (lbl_CevapKalibrasyon.Text == "Geçersiz Kalibrasyon" && e.Row == 8)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.CellBounds);
            }

            if (lbl_CevapAkisHizi.Text == "Geçerli Akış Hızı" && e.Row == 10)
            {
                e.Graphics.FillRectangle(Brushes.SpringGreen, e.CellBounds);
            }
            else if (lbl_CevapAkisHizi.Text == "Geçersiz Akış Hızı" && e.Row == 10)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.CellBounds);
            }

            if (lbl_CevapTekrarVeri.Text == "Geçerli Veri" && e.Row == 12)
            {
                e.Graphics.FillRectangle(Brushes.SpringGreen, e.CellBounds);
            }
            else if (lbl_CevapTekrarVeri.Text == "Geçersiz Veri" && e.Row == 12)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.CellBounds);
            }

        }

        private void timer_PlcConnect_Tick(object sender, EventArgs e)
        {
            var bgw = new BackgroundWorker();
            bgw.DoWork += delegate
            {
                AllData allData = sqlSave.TumVeriGetir();
                BitVeriler bitVeriler = sqlSave.BitVerilerGetir();

                lbl_akmValue.Text = allData.AKM + " mg/l";

                lbl_oksijenValue.Text = allData.CozunmusOksijen + " mg/l";

                //Debi eklenecek.

                lbl_koiValue.Text = allData.KOi + " mg/l";

                lbl_phValue.Text = allData.pH.ToString();

                lbl_sicaklikValue.Text = allData.Sicaklik + "°C";

                lbl_iletkenlikValue.Text = allData.Iletkenlik + " mS/cm";

                lbl_akisHiziValue.Text = allData.AkisHizi + " m/s";

                lbl_nemValue.Text = allData.NumuneNem + "%";

                //Kabin Durumu Değerleri

                lbl_Duman.Text = bitVeriler.Duman ? "DUMAN VAR!" : "Duman yok";
                lbl_SuBaskini.Text = bitVeriler.SuBaskini ? "SU BASKINI VAR!" : "Su Baskını yok";
                lbl_AcilStop.Text = bitVeriler.AcilStop ? "ACİL STOP!" : "Acil Stop yok";
                lbl_Enerji.Text = bitVeriler.Enerji ? "ENERJİ YOK!" : "Enerji var";

                #region Durumlara Göre Görsel Değişiklikler


                if (bitVeriler.Kapi == false && bitVeriler.AutoStat == true && bitVeriler.YikamaStat == false && bitVeriler.HaftalikYikamaStat == false && bgImageName != "panel_bakanlikkabini_dolu")
                {
                    panel_simulasyon.BackgroundImage = SAISKabini.Properties.Resources.panel_bakanlikkabini_dolu;
                    bgImageName = "panel_bakanlikkabini_dolu";
                }

                else if (bitVeriler.Kapi == true && bitVeriler.AutoStat == true && bitVeriler.YikamaStat == false && bitVeriler.HaftalikYikamaStat == false && bgImageName != "panel_bakanlikkabini_dolu_kapiacik")
                {
                    panel_simulasyon.BackgroundImage = SAISKabini.Properties.Resources.panel_bakanlikkabini_dolu_kapiacik;
                    bgImageName = "panel_bakanlikkabini_dolu_kapiacik";
                }

                else if (bitVeriler.Kapi == false && (bitVeriler.YikamaStat == true || bitVeriler.HaftalikYikamaStat == true) && bgImageName != "panel_bakanlikkabini_dolu_yikama")
                {
                    panel_simulasyon.BackgroundImage = SAISKabini.Properties.Resources.panel_bakanlikkabini_dolu_yikama;
                    bgImageName = "panel_bakanlikkabini_dolu_yikama";
                }

                else if (bitVeriler.Kapi == true && (bitVeriler.YikamaStat == true || bitVeriler.HaftalikYikamaStat == true) && bgImageName != "panel_bakanlikkabini_doluyikama_kapiacik")
                {
                    panel_simulasyon.BackgroundImage = SAISKabini.Properties.Resources.panel_bakanlikkabini_doluyikama_kapiacik;
                    bgImageName = "panel_bakanlikkabini_doluyikama_kapiacik";
                }

                else if (bitVeriler.Kapi == false && bitVeriler.BakimStat == true && bitVeriler.KalibrasyonStat == true && bgImageName != "panel_bakanlikkabini_bos")
                {
                    panel_simulasyon.BackgroundImage = SAISKabini.Properties.Resources.panel_bakanlikkabini_bos;
                    bgImageName = "panel_bakanlikkabini_bos";
                }

                else if (bitVeriler.Kapi == true && bitVeriler.BakimStat == true && bitVeriler.KalibrasyonStat == true && bgImageName != "panel_bakanlikkabini_bos_kapiacik")
                {
                    panel_simulasyon.BackgroundImage = SAISKabini.Properties.Resources.panel_bakanlikkabini_bos_kapiacik;
                    bgImageName = "panel_bakanlikkabini_bos_kapiacik";
                }

                if (bitVeriler.YikamaTanki == false && bgTankName != "tank_dolu")
                {
                    pic_yikamaTanki.BackgroundImage = SAISKabini.Properties.Resources.tank_dolu;
                    bgTankName = "tank_dolu";
                }
                else if (bitVeriler.YikamaTanki == true && bgTankName != "tank_bos")
                {
                    pic_yikamaTanki.BackgroundImage = SAISKabini.Properties.Resources.tank_bos;
                    bgTankName = "tank_bos";
                }

                #endregion

                #region Durumlara Göre Yazısal Değişiklikler

                if (bitVeriler.Pompa1CalisiyorMu == true && bgPompaName != "pump2_anim")
                {
                    lbl_aktifPompaValue.Text = "Pompa 1";
                    lbl_pompaHzValue.Text = allData.Pompa1Hz + "Hz";
                    pic_pompa1.Image = SAISKabini.Properties.Resources.pump1_anim;
                    pic_pompa2.Image = SAISKabini.Properties.Resources.pump2_idle;
                    bgPompaName = "pump2_anim";
                }
                else if (bitVeriler.Pompa2CalisiyorMu == true && bgPompaName != "pump1_anim")
                {
                    lbl_aktifPompaValue.Text = "Pompa 2";
                    lbl_pompaHzValue.Text = allData.Pompa2Hz + "Hz";
                    pic_pompa1.Image = SAISKabini.Properties.Resources.pump1_idle1;
                    pic_pompa2.Image = SAISKabini.Properties.Resources.pump2_anim;
                    bgPompaName = "pump1_anim";
                }
                else if (bitVeriler.Pompa1CalisiyorMu == false && bitVeriler.Pompa2CalisiyorMu == false)
                {
                    lbl_aktifPompaValue.Text = "Yok";
                    lbl_pompaHzValue.Text = "0 Hz";
                    pic_pompa1.Image = SAISKabini.Properties.Resources.pump1_idle1;
                    pic_pompa2.Image = SAISKabini.Properties.Resources.pump2_idle;
                    bgPompaName = "";
                }
                #endregion
            };

            bgw.RunWorkerAsync();
        }
    }
}
