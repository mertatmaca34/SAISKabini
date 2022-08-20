using Newtonsoft.Json;
using System;
using Sharp7;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SAISKabini
{
    public partial class Anasayfa : Form
    {
        private protected ServicesModel Services { get; set; }

        readonly UserInfo userInfo = new UserInfo();

        readonly FormStyles formStyles = new FormStyles();

        readonly SqlSave sqlSave = new SqlSave();

        readonly static string pcName = Environment.MachineName;

        readonly SqlConnection sqlConnection = new SqlConnection("Data Source=" + pcName + "\\SQLEXPRESS;Initial Catalog=SAISKabini;Integrated Security=True");

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

        public int loopCountAvgMin = 0, loopCountAvgHour = 0, intervalTime, period;

        public int[] stats;

        public double minAvgAkm, minAvgOksijen, minAvgDebi, minAvgKOi, minAvgPh, minAvgSicaklik, minAvgIletkenlilk, minAvgAkisHizi, minAvgDesarjDebi;

        public double hourAvgAkm, hourAvgOksijen, hourAvgDebi, hourAvgKOi, hourAvgPh, hourAvgSicaklik, hourAvgIletkenlilk, hourAvgAkisHizi, hourAvgDesarjDebi;

        #endregion

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            foreach (Control item in Right_TLP.Controls)
            {
                {
                }
            }

            {
                {



            {
                    CommandType = CommandType.StoredProcedure
                };




                    lbl_birSonrakiHaftalikYikama.Text = kalanSure.ToString("c");
                }


                while (reader.Read())
                {
                    DateTime tetikTarih = (DateTime)reader["BaslamaTarihi"];
                    lbl_numuneTetikveTarih.Text = reader["Tetik"] + ": " + reader["Değer"] + " - " + tetikTarih.ToString("hh:mm:ss");

                //Numune Bilgileri
                SampleInfo sampleInfo = new SampleInfo();


                DateTime tetikTarih = sampleInfo.baslamaTarihi;
                lbl_numuneTetikveTarih.Text = sampleInfo.tetik + ": " + sampleInfo.deger + " - " + tetikTarih.ToString("hh:mm:ss");

                DateTime numuneAlmaBitisTarihi = sampleInfo.bitisTarihi;
                lbl_numuneAlmaBitis.Text = numuneAlmaBitisTarihi.ToString("hh:mm:ss");
            };

            bgw_formYukle.RunWorkerAsync();
        }

        public string softwareVersion = "1.0.0";


        #endregion

        public Anasayfa()
        {
            InitializeComponent();

            #region Default Form Stilleri

            this.FormBorderStyle = FormBorderStyle.None;

            home_tableLayoutPanel_top.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, home_tableLayoutPanel_top.Width, home_tableLayoutPanel_top.Height, 20, 20));
            home_tableLayoutPanel_down.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, home_tableLayoutPanel_down.Width, home_tableLayoutPanel_down.Height, 20, 20));
            tblLayP_istasyonBilgileri.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tblLayP_istasyonBilgileri.Width, tblLayP_istasyonBilgileri.Height, 20, 20));
            tblLayP_kabinDurumu.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tblLayP_kabinDurumu.Width, tblLayP_kabinDurumu.Height, 20, 20));
            tblLayP_yikamaBilgileri.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tblLayP_yikamaBilgileri.Width, tblLayP_yikamaBilgileri.Height, 20, 20));
            tblLayP_numuneCihazi.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tblLayP_numuneCihazi.Width, tblLayP_numuneCihazi.Height, 20, 20));

            CheckForIllegalCrossThreadCalls = false;

            #endregion

            intervalTime = timer_PlcConnect.Interval / 1000;

            stats = new int[60 / intervalTime];

        }

        private void tblLayP_numuneCihazi_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
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

        {
        }
            else if (e.Row % 2 == 1)
            {
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            }
        }

        private void tblLayP_istasyonBilgileri_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
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

        private void tblyp_rightPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row < 7 && e.Row % 2 == 0)
            {
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            }
            else if (e.Row < 7 && e.Row % 2 == 1)
            {
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.CellBounds);
            }
        }

        private void VeriGonder(DateTime time, string _stationid, string softwareVersion, int period, double akisHizi, int status, double akm, double cozunmusOksijen,
            double debi, double desarjDebi, double koi, double ph, double sicaklik, double iletkenlik)
        {
            #region Data Oluşturma ve Gönderme

            var data = new SendData
            {
                Readtime = time,
                Stationid = new Guid(_stationid),
                SoftwareVersion = softwareVersion,
                Period = period,
                AkisHizi = akisHizi,
                AkisHizi_Status = status,
                AKM = akm,
                AKM_Status = status,
                CozunmusOksijen = cozunmusOksijen,
                CozunmusOksijen_Status = status,
                Debi = debi,
                Debi_Status = status,
                DesarjDebi = desarjDebi,
                DesarjDebi_Status = status,
                KOi = koi,
                KOi_Status = status,
                pH = ph,
                pH_Status = status,
                Sicaklik = sicaklik,
                Sicaklik_Status = status,
                Iletkenlik = iletkenlik,
                Iletkenlik_Status = status
            };



        }



        private void timer_PlcConnect_Tick(object sender, EventArgs e)
        {
            var bgw_FormYukle = new BackgroundWorker();
            bgw_FormYukle.DoWork += delegate
            {
                plc.SetRealValues();

                //Çekilen real değerlerin controllere atanması

                instantAkmValue.Text = plc.AkmValue.ToString() + " mg/l";

                instantOksijenValue.Text = plc.OksijenValue.ToString() + " mg/l";

                instantDebiValue.Text = plc.DebiValue.ToString() + " m³/d";

                instantKOiValue.Text = plc.KoiValue.ToString() + " mg/l";

                instantPhValue.Text = plc.PhValue.ToString();

                instantSicaklikValue.Text = plc.SicaklikValue.ToString() + "°C";

                lbl_sicaklik.Text = plc.SicaklikValue.ToString() + "°C";

                lbl_nem.Text = "%" + plc.NemValue.ToString();

                instantIletkenlikValue.Text = plc.IletkenlikValue.ToString() + " mS/cm";

                instantAkisHiziValue.Text = plc.AkisHiziValue.ToString() + " m/s";

                instantDesarjDebiValue.Text = plc.DesarjDebiValue.ToString() + " m³/d";


                //Çekilen bit değerlerin controllere atanması

                #region Bit Değerler
                plc.SetBitValues();

                lbl_kapiInstantValue.Text = plc.KapiValue == true ? "Açık" : "Kapalı";
                lbl_kapiDesc.Text = plc.KapiValue == true ? "Kapı Açık" : "Kapı Kapalı";

                lbl_dumanInstantValue.Text = plc.DumanValue == true ? "Var" : "Yok";
                lbl_dumanDesc.Text = plc.DumanValue == true ? "İçeride duman var" : "İçeride duman yok";

                lbl_suBaskiniInstantValue.Text = plc.SuBaskiniValue == true ? "Var" : "Yok";
                lbl_suBaskiniDesc.Text = plc.SuBaskiniValue == true ? "Su Baskını Var" : "Su Baskını Yok";

                lbl_acilStopInstantValue.Text = plc.AcilStopValue == true ? "Var" : "Yok";
                lbl_acilStopDesc.Text = plc.AcilStopValue == true ? "Acil stopa basıldı" : "Acil stopa basılmadı";

                lbl_pompa1TermikInstantValue.Text = plc.Pompa1TermikValue == true ? "Termik" : "Yok";
                lbl_pompa1TermikDesc.Text = plc.Pompa1TermikValue == true ? "Termik attı" : "Termik yok";

                lbl_pompa2TermikInstantValue.Text = plc.Pompa2TermikValue == true ? "Termik" : "Yok";
                lbl_pompa2TermikDesc.Text = plc.Pompa2TermikValue == true ? "Termik attı" : "Termik yok";

                lbl_temizSuTermikInstantValue.Text = plc.TemizSuTermikValue == true ? "Termik" : "Yok";
                lbl_temizSuTermikDesc.Text = plc.TemizSuTermikValue == true ? "Termik Attı" : "Termik yok";

                lbl_yikamaTankiInstantValue.Text = plc.YikamaTankiValue == true ? "Boş" : "Dolu";
                lbl_yikamaTankiDesc.Text = plc.YikamaTankiValue == true ? "Yıkama tankı boş" : "Yıkama tankı dolu";

                lbl_enerjiInstantValue.Text = plc.EnerjiValue == true ? "Yok" : "Var";
                lbl_enerjiDesc.Text = plc.EnerjiValue == true ? "Enerji yok" : "Enerji var";




                #region Kabin Durumları Değerleri

                if (plc.Pompa1Hz != 0)
                {
                    lbl_pompaDurum.Text = "Pompa 1 - " + plc.Pompa1Hz + "Hz";
                }
                else if (plc.Pompa2Hz != 0)
                {
                    lbl_pompaDurum.Text = "Pompa 2 - " + plc.Pompa2Hz + "Hz";
                }
                else
                {
                    lbl_pompaDurum.Text = "Pompalar çalışmıyor";
                }

                #endregion

                #endregion

                #region Güncelleme Tarihlerinin Güncellenmesi

                if (plc.Connected())
                {
                    //Üst Panel (Real Değerler)

                    akmLastUpdate.Text = DateTime.Now.ToString();
                    oksijenLastUpdate.Text = DateTime.Now.ToString();
                    debiLastUpdate.Text = DateTime.Now.ToString();
                    KOiLastUpdate.Text = DateTime.Now.ToString();
                    phLastUpdate.Text = DateTime.Now.ToString();
                    sicaklikLastUpdate.Text = DateTime.Now.ToString();
                    iletkenlikLastUpdate.Text = DateTime.Now.ToString();
                    akisHiziLastUpdate.Text = DateTime.Now.ToString();
                    desarjDebiLastUpdate.Text = DateTime.Now.ToString();

                    // Alt Panel (Bit Değerler)

                    lbl_kapiLastUpdate.Text = DateTime.Now.ToString();
                    lbl_dumanLastUpdate.Text = DateTime.Now.ToString();
                    lbl_suBaskiniLastUpdate.Text = DateTime.Now.ToString();
                    lbl_acilStopLastUpdate.Text = DateTime.Now.ToString();
                    lbl_pompa1TermikLastUpdate.Text = DateTime.Now.ToString();
                    lbl_pompa2TermikLastUpdate.Text = DateTime.Now.ToString();
                    lbl_TemizSuTermikLastUpdate.Text = DateTime.Now.ToString();
                    lbl_yikamaTankiLastUpdate.Text = DateTime.Now.ToString();
                    lbl_enerjiLastUpdate.Text = DateTime.Now.ToString();
                }
                else
                {
                    //Loglara yazılacak
                }

                #endregion

                #region Dakikalık Değerlerin Ekrana Yansıtılması ve Hesabı

                //Dakikalık Ortalamanın Hesaplanması

                //PLC Tetiğine Göre Dakikada Tekrar Sayı Hesabı


                //Saniye 59 dan düşük olduğu sürece yapılan hesap
                if (loopCountAvgMin < 60 / intervalTime)
                {
                    lbl_kapiStateTime.Text = loopCountAvgMin.ToString();
                    minAvgAkm += plc.AkmValue;
                    minAvgOksijen += plc.OksijenValue;
                    minAvgDebi += plc.DebiValue;
                    minAvgKOi += plc.KoiValue;
                    minAvgPh += plc.PhValue;
                    minAvgSicaklik += plc.SicaklikValue;
                    minAvgIletkenlilk += plc.IletkenlikValue;
                    minAvgAkisHizi += plc.AkisHiziValue;
                    minAvgDesarjDebi += plc.DesarjDebiValue;

                    #region stats Hesabı

                    stats[loopCountAvgMin] = plc.GetStatus();

                    #endregion

                    loopCountAvgMin++;

                    lbl_minAvgAkm.Text = Math.Round(minAvgAkm / loopCountAvgMin, 2).ToString() + " mg/l";
                    lbl_minAvgOksijen.Text = Math.Round(minAvgOksijen / loopCountAvgMin, 2).ToString() + " mg/l";
                    lbl_minAvgDebi.Text = Math.Round(minAvgDebi / loopCountAvgMin, 2).ToString() + " m³/d";
                    lbl_minAvgKOi.Text = Math.Round(minAvgKOi / loopCountAvgMin, 2).ToString() + " mg/l";
                    lbl_minAvgPh.Text = Math.Round(minAvgPh / loopCountAvgMin, 2).ToString();
                    lbl_minAvgSicaklik.Text = Math.Round(minAvgSicaklik / loopCountAvgMin, 2).ToString() + "°C";
                    lbl_minAvgIletkenlik.Text = Math.Round(minAvgIletkenlilk / loopCountAvgMin, 2).ToString() + " mS/cm";
                    lbl_minAvgAkisHizi.Text = Math.Round(minAvgAkisHizi / loopCountAvgMin, 2).ToString() + " m/s";
                    lbl_minAvgDesarjDebi.Text = Math.Round(minAvgDesarjDebi / loopCountAvgMin, 2).ToString() + " m³/d";
                }

                //Yeni Dakika Değerleri ve Saatlik Ortalama Atamaları

                else if (loopCountAvgMin == 60 / intervalTime)
                {
                    if (loopCountAvgHour < 60)
                    {
                        if (loopCountAvgHour == 0)
                        {
                            hourAvgAkm = minAvgAkm / loopCountAvgMin;
                            hourAvgOksijen = minAvgOksijen / loopCountAvgMin;
                            hourAvgDebi = minAvgDebi / loopCountAvgMin;
                            hourAvgKOi = minAvgKOi / loopCountAvgMin;
                            hourAvgPh = minAvgPh / loopCountAvgMin;
                            hourAvgSicaklik = minAvgSicaklik / loopCountAvgMin;
                            hourAvgIletkenlilk = minAvgIletkenlilk / loopCountAvgMin;
                            hourAvgAkisHizi = minAvgAkisHizi / loopCountAvgMin;
                            hourAvgDesarjDebi = minAvgDesarjDebi / loopCountAvgMin;

                            loopCountAvgHour++;

                            lbl_hourAvgAkm.Text = Math.Round(hourAvgAkm / loopCountAvgHour, 2).ToString() + " mg/l";
                            lbl_hourAvgOksijen.Text = Math.Round(hourAvgOksijen / loopCountAvgHour, 2).ToString() + " mg/l";
                            lbl_hourAvgDebi.Text = Math.Round(hourAvgDebi / loopCountAvgHour, 2).ToString() + " m³/d";
                            lbl_hourAvgKOi.Text = Math.Round(hourAvgKOi / loopCountAvgHour, 2).ToString() + " mg/l";
                            lbl_hourAvgPh.Text = Math.Round(hourAvgPh / loopCountAvgHour, 2).ToString();
                            lbl_hourAvgSicaklik.Text = Math.Round(hourAvgSicaklik / loopCountAvgHour, 2).ToString() + "°C";
                            lbl_hourAvgIletkenlik.Text = Math.Round(hourAvgIletkenlilk / loopCountAvgHour, 2).ToString() + " mS/cm";
                            lbl_hourAvgAkisHizi.Text = Math.Round(hourAvgAkisHizi / loopCountAvgHour, 2).ToString() + " m/s";
                            lbl_hourAvgDesarjDebi.Text = Math.Round(hourAvgDesarjDebi / loopCountAvgHour, 2).ToString() + " m³/d";
                        }
                        else
                        {
                            hourAvgAkm += minAvgAkm / loopCountAvgMin;
                            hourAvgOksijen += minAvgOksijen / loopCountAvgMin;
                            hourAvgDebi += minAvgDebi / loopCountAvgMin;
                            hourAvgKOi += minAvgKOi / loopCountAvgMin;
                            hourAvgPh += minAvgPh / loopCountAvgMin;
                            hourAvgSicaklik += minAvgSicaklik / loopCountAvgMin;
                            hourAvgIletkenlilk += minAvgIletkenlilk / loopCountAvgMin;
                            hourAvgAkisHizi += minAvgAkisHizi / loopCountAvgMin;
                            hourAvgDesarjDebi += minAvgDesarjDebi / loopCountAvgMin;

                            loopCountAvgHour++;

                            lbl_hourAvgAkm.Text = Math.Round(hourAvgAkm / loopCountAvgHour, 2).ToString() + " mg/l";
                            lbl_hourAvgOksijen.Text = Math.Round(hourAvgOksijen / loopCountAvgHour, 2).ToString() + " mg/l";
                            lbl_hourAvgDebi.Text = Math.Round(hourAvgDebi / loopCountAvgHour, 2).ToString() + " m³/d";
                            lbl_hourAvgKOi.Text = Math.Round(hourAvgKOi / loopCountAvgHour, 2).ToString() + " mg/l";
                            lbl_hourAvgPh.Text = Math.Round(hourAvgPh / loopCountAvgHour, 2).ToString();
                            lbl_hourAvgSicaklik.Text = Math.Round(hourAvgSicaklik / loopCountAvgHour, 2).ToString() + "°C";
                            lbl_hourAvgIletkenlik.Text = Math.Round(hourAvgIletkenlilk / loopCountAvgHour, 2).ToString() + " mS/cm";
                            lbl_hourAvgAkisHizi.Text = Math.Round(hourAvgAkisHizi / loopCountAvgHour, 2).ToString() + " m/s";
                            lbl_hourAvgDesarjDebi.Text = Math.Round(hourAvgDesarjDebi / loopCountAvgHour, 2).ToString() + " m³/d";
                        }
                    }
                    else if (loopCountAvgHour == 60)
                    {


                        VeriGonder(plc.GetPlcTime(), lbl_simId.Text, softwareVersion, 1, plc.AkisHiziValue, 1, plc.AkmValue, plc.OksijenValue,
                            plc.DebiValue, plc.DebiValue, plc.KoiValue, plc.PhValue, plc.SicaklikValue, plc.IletkenlikValue);

                        hourAvgAkm = 0;
                        hourAvgOksijen = 0;
                        hourAvgDebi = 0;
                        hourAvgKOi = 0;
                        hourAvgPh = 0;
                        hourAvgSicaklik = 0;
                        hourAvgIletkenlilk = 0;
                        hourAvgAkisHizi = 0;
                        hourAvgDesarjDebi = 0;

                        loopCountAvgHour = 0;
                    }


                    MathematicalOps mathematicalOps = new MathematicalOps();
                    int status = mathematicalOps.mostFrequent(stats, stats.Length); //O dakika içerisinde en çok tekrara eden durumu bulmak.

                    VeriGonder(plc.GetPlcTime(), lbl_simId.Text, softwareVersion, 1, plc.AkisHiziValue, status, plc.AkmValue, plc.OksijenValue,
                        plc.DebiValue, plc.DebiValue, plc.KoiValue, plc.PhValue, plc.SicaklikValue, plc.IletkenlikValue);

                    minAvgAkm = 0;
                    minAvgOksijen = 0;
                    minAvgDebi = 0;
                    minAvgKOi = 0;
                    minAvgPh = 0;
                    minAvgSicaklik = 0;
                    minAvgIletkenlilk = 0;
                    minAvgAkisHizi = 0;
                    minAvgDesarjDebi = 0;

                    loopCountAvgMin = 0;
                }
                #endregion

                SonYikamayaKalan();
                SonHaftalikYikamayaKalan();

            };

            if (plc.Connected())
            {
                bgw_FormYukle.RunWorkerAsync();
            }
            else
            {
                plc.Reconnect();
                //logekle
            }
        }

        private void SonYikamayaKalan()
        {
            if (DateTime.Now.Hour >= 18)
            {
                lbl_birSonrakiGunlukYikama.Text = (new TimeSpan(23, 54, 0) - DateTime.Now.TimeOfDay).ToString("hh\\:mm\\:ss");
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 18)
            {
                lbl_birSonrakiGunlukYikama.Text = (new TimeSpan(17, 54, 0) - DateTime.Now.TimeOfDay).ToString("hh\\:mm\\:ss");
            }
            else if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour <= 12)
            {
                lbl_birSonrakiGunlukYikama.Text = (new TimeSpan(11, 54, 0) - DateTime.Now.TimeOfDay).ToString("hh\\:mm\\:ss");
            }
            else if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour <= 6)
            {
                lbl_birSonrakiGunlukYikama.Text = (new TimeSpan(5, 54, 0) - DateTime.Now.TimeOfDay).ToString("hh\\:mm\\:ss");
            }
        }

        private void SonHaftalikYikamayaKalan()
        {
            DateTime tDT = DateTime.Now;

            int gun = (int)tDT.DayOfWeek;
            int kalangun;

            if ((int)tDT.DayOfWeek != 1)
            {
                kalangun = 7 - (int)tDT.DayOfWeek;
                int normalGun = tDT.Day + kalangun;
                DateTime yikamaZamani = new DateTime(tDT.Year, tDT.Month, normalGun, 6, 40, 0);

                //TimeSpan ts = yikamaZamani - DateTime.Now;
                string ayAdi = yikamaZamani.ToString("MMMM", new CultureInfo("tr-TR"));
                lbl_birSonrakiHaftalikYikama.Text = yikamaZamani.Day + " " + ayAdi + " Saat: " + yikamaZamani.Hour + ":" + yikamaZamani.Minute;
            }
        }
    }
}
