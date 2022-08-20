using System;
using Sharp7;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SAISKabini
{
    public partial class Anasayfa : Form
    {

        readonly UserInfo userInfo = new UserInfo();

        readonly FormStyles formStyles = new FormStyles();

        readonly SqlSave sqlSave = new SqlSave();

        readonly static string pcName = Environment.MachineName;

        readonly SqlConnection sqlConnection = new SqlConnection("Data Source=" + pcName + "\\SQLEXPRESS;Initial Catalog=SAISKabini;Integrated Security=True");

        private protected ServicesModel Services { get; set; }

        readonly UserInfo userInfo = new UserInfo();

        DeserializeResult deserializeResult = new DeserializeResult();

        readonly FormStyles formStyles = new FormStyles();

        readonly SqlSave sqlSave = new SqlSave();

        static readonly S7Client client = new S7Client(); //PLC Nesnesi Oluşturma

        private int PlcResult = client.ConnectTo("10.33.3.253", 0, 1);


        byte[] db41Buffer = new byte[148];

        byte[] db4Buffer = new byte[30];

        byte[] db1Buffer = new byte[30];

        byte[] mb1Buffer = new byte[300];

        byte[] MBBuffer = new byte[2000];


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

        public string softwareVersion = "1.0.0";

        #endregion


        private void timer_GitmeyenVeriGonder_Tick(object sender, EventArgs e)
        {
            var bgw = new BackgroundWorker();
            bgw.DoWork += delegate
            {
                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spGitmeyenVeriGetir", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };


                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        DateTime ReadTime = (DateTime)reader["ReadTime"];
                        Guid Stationid = new Guid(reader["Stationid"].ToString());
                        string SoftwareVersion = reader["SoftwareVersion"].ToString();
                        int Period = (int)reader["Period"];
                        double AkisHizi = Convert.ToDouble(reader["AkisHizi"]);
                        int AkisHizi_Status = (int)reader["Status"];
                        double AKM = Convert.ToDouble(reader["AKM"]);
                        int AKM_Status = (int)reader["Status"];
                        double CozunmusOksijen = Convert.ToDouble(reader["CozunmusOksijen"]);
                        int CozunmusOksijen_Status = (int)reader["Status"];
                        double Debi = Convert.ToDouble(reader["Debi"]);
                        int Debi_Status = (int)reader["Status"];
                        double DesarjDebi = Convert.ToDouble(reader["Debi"]);
                        int DesarjDebi_Status = (int)reader["Status"];
                        double KOi = Convert.ToDouble(reader["KOi"]);
                        int KOi_Status = (int)reader["Status"];
                        double pH = Convert.ToDouble(reader["pH"]);
                        int pH_Status = (int)reader["Status"];
                        double Sicaklik = Convert.ToDouble(reader["Sicaklik"]);
                        int Sicaklik_Status = (int)reader["Status"];
                        double Iletkenlik = Convert.ToDouble(reader["Iletkenlik"]);
                        int Iletkenlik_Status = (int)reader["Status"];

                        ServicePointManager.Expect100Continue = true;
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11;

                        var data = new SendData
                        {
                            Readtime = ReadTime,
                            Stationid = Stationid,
                            SoftwareVersion = SoftwareVersion,
                            Period = Period,
                            AkisHizi = AkisHizi,
                            AkisHizi_Status = AkisHizi_Status,
                            AKM = AKM,
                            AKM_Status = AKM_Status,
                            CozunmusOksijen = CozunmusOksijen,
                            CozunmusOksijen_Status = CozunmusOksijen_Status,
                            Debi = Debi,
                            Debi_Status = Debi_Status,
                            DesarjDebi = DesarjDebi,
                            DesarjDebi_Status = DesarjDebi_Status,
                            KOi = KOi,
                            KOi_Status = KOi_Status,
                            pH = pH,
                            pH_Status = pH_Status,
                            Sicaklik = Sicaklik,
                            Sicaklik_Status = Sicaklik_Status,
                            Iletkenlik = Iletkenlik,
                            Iletkenlik_Status = Iletkenlik_Status,
                        };

                        Services.Login(userInfo.UserName, userInfo.Password);

                        var res = Services.sendData(data);
                    }
                    sqlConnection.Close();
                }
                catch (Exception)
                {
                }

            };
            bgw.RunWorkerAsync();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            #region Bilgilerin Veritabanından Getirilmesi

            foreach (Control item in Right_TLP.Controls)
            {
                if (item is TableLayoutPanel)
                {
                    (item as TableLayoutPanel).CellPaint += new TableLayoutCellPaintEventHandler(formStyles.CellPaints);
                }
            }

            foreach (Control item in Main_TLP.Controls)
            {
                if (item is TableLayoutPanel)
                {
                    (item as TableLayoutPanel).CellPaint += new TableLayoutCellPaintEventHandler(formStyles.CellPaints);
                }
            }

            #endregion

            #region Bilgilerin Veritabanından Getirilmesi

                    lbl_birSonrakiHaftalikYikama.Text = kalanSure.ToString("c");
                }

            bgw_formYukle.DoWork += delegate
            {

                while (reader.Read())
                {
                    DateTime tetikTarih = (DateTime)reader["BaslamaTarihi"];
                    lbl_numuneTetikveTarih.Text = reader["Tetik"] + ": " + reader["Değer"] + " - " + tetikTarih.ToString("hh:mm:ss");

                stationInfo = (StationInfo)sqlSave.IstasyonBilgiGetir();

                lbl_istasyonAdi.Text = stationInfo.istasyonAdi;
                lbl_istasyonIp.Text = stationInfo.istasyonIp;
                lbl_simId.Text = stationInfo.simId;
                userInfo.UserName = stationInfo.kullaniciAdi;
                userInfo.Password = stationInfo.kullaniciSifresi;

                DateTime tetikTarih = sampleInfo.baslamaTarihi;
                lbl_numuneTetikveTarih.Text = sampleInfo.tetik + ": " + sampleInfo.deger + " - " + tetikTarih.ToString("hh:mm:ss");

                //Yıkama Bilgileri
                lbl_sonGunlukYikama.Text = sqlSave.GunlukYikamaGetir();
                lbl_sonHaftalikYikama.Text = sqlSave.HaftalikYikamaGetir();


                //Numune Bilgileri
                SampleInfo sampleInfo = new SampleInfo();

                sampleInfo = (SampleInfo)sqlSave.NumuneBilgiGetir();

                DateTime tetikTarih = sampleInfo.baslamaTarihi;
                lbl_numuneTetikveTarih.Text = sampleInfo.tetik + ": " + sampleInfo.deger + " - " + tetikTarih.ToString("hh:mm:ss");

                DateTime numuneAlmaBitisTarihi = sampleInfo.bitisTarihi;
                lbl_numuneAlmaBitis.Text = numuneAlmaBitisTarihi.ToString("hh:mm:ss");
                lbl_dolapSicakligi.Text = sampleInfo.dolapSicakligi + "°C";
            };

            bgw_formYukle.RunWorkerAsync();
            #endregion
        }

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

            Services.Login(userInfo.UserName, userInfo.Password);

            var res = Services.sendData(data);

            if (res.result)
            {
                deserializeResult = JsonConvert.DeserializeObject<DeserializeResult>(res.objects.ToString());

                sqlSave.DonenVeriKaydet(deserializeResult);

                sqlSave.SendDataSave(data);
            }
            else
            {
                sqlSave.NotSendDataSave(data);
                //log eklenecek
            }
            #endregion
        }



        private void Timer_PlcConnect_Tick(object sender, EventArgs e)
        {
            var bgw_FormYukle = new BackgroundWorker();
            bgw_FormYukle.DoWork += delegate
            {
                PlcResult = client.DBRead(41, 0, db41Buffer.Length, db41Buffer);

                double AkmValue = Math.Round(S7.GetRealAt(db41Buffer, 36), 2);

                double OksijenValue = Math.Round(S7.GetRealAt(db41Buffer, 24), 2);

                double DebiValue = Math.Round(S7.GetRealAt(db41Buffer, 0), 2);

                double KoiValue = Math.Round(S7.GetRealAt(db41Buffer, 32), 2);

                double PhValue = Math.Round(S7.GetRealAt(db41Buffer, 16), 2);

                double SicaklikValue = Math.Round(S7.GetRealAt(db41Buffer, 28), 2);

                double NemValue = Math.Round(S7.GetRealAt(db41Buffer, 44), 2);

                double IletkenlikValue = Math.Round(S7.GetRealAt(db41Buffer, 20), 2);

                double AkisHiziValue = Math.Round(S7.GetRealAt(db41Buffer, 4), 2);

                double DesarjDebiValue = Math.Round(S7.GetRealAt(db41Buffer, 12), 2);

                double Pompa1Hz = Math.Round(S7.GetRealAt(db41Buffer, 140), 2);

                double Pompa2Hz = Math.Round(S7.GetRealAt(db41Buffer, 144), 2);

                double NumuneSicaklik = Math.Round(S7.GetRealAt(db41Buffer, 80), 2);

                double NumuneNem = Math.Round(S7.GetRealAt(db41Buffer, 84), 2);

                PlcResult = client.EBRead(0, db1Buffer.Length, db1Buffer);

                bool KapiValue = S7.GetBitAt(db1Buffer, 25, 5);

                bool DumanValue = S7.GetBitAt(db1Buffer, 1, 1);

                bool SuBaskiniValue = S7.GetBitAt(db1Buffer, 0, 7);

                bool AcilStopValue = S7.GetBitAt(db1Buffer, 25, 7);

                bool Pompa1TermikValue = S7.GetBitAt(db1Buffer, 27, 5);

                bool Pompa2TermikValue = S7.GetBitAt(db1Buffer, 28, 0);

                bool TemizSuTermikValue = S7.GetBitAt(db1Buffer, 28, 2);

                bool YikamaTankiValue = S7.GetBitAt(db1Buffer, 28, 3);

                bool EnerjiValue = S7.GetBitAt(db1Buffer, 25, 6);

                bool Pompa1CalisiyorMu = S7.GetBitAt(db1Buffer, 27, 4);

                bool Pompa2CalisiyorMu = S7.GetBitAt(db1Buffer, 27, 7);

                PlcResult = client.MBRead(0, mb1Buffer.Length, mb1Buffer);

                bool YikamaStat = S7.GetBitAt(mb1Buffer, 24, 1);

                bool HaftalikYikamaStat = S7.GetBitAt(mb1Buffer, 24, 2);

                bool AutoStat = S7.GetBitAt(mb1Buffer, 10, 6);

                bool BakimStat = S7.GetBitAt(mb1Buffer, 10, 4);

                bool KalibrasyonStat = S7.GetBitAt(mb1Buffer, 10, 5);

                int status = YikamaStat == true ? 23
                : HaftalikYikamaStat == true ? 24
                : AutoStat == true ? 1
                : BakimStat == true ? 25
                : KalibrasyonStat == true ? 9
                : 0;

                PlcResult = client.DBRead(4, 0, db4Buffer.Length, db4Buffer);

                DateTime time = S7.GetDTLAt(db4Buffer, 0);

                /*ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11;
                */
                VeriGonder(time, lbl_simId.Text, softwareVersion, 1, AkisHiziValue, status, AkmValue, OksijenValue,
                    DebiValue, DebiValue, KoiValue, PhValue, SicaklikValue, IletkenlikValue);

                lbl_sicaklik.Text = plc.SicaklikValue.ToString() + "°C";

                //Çekilen real değerlerin controllere atanması

                instantAkmValue.Text = AkmValue.ToString() + " mg/l";

                instantOksijenValue.Text = OksijenValue.ToString() + " mg/l";

                instantDebiValue.Text = DebiValue.ToString() + " m³/d";

                instantKOiValue.Text = KoiValue.ToString() + " mg/l";

                instantPhValue.Text = PhValue.ToString();

                instantSicaklikValue.Text = SicaklikValue.ToString() + "°C";

                lbl_sicaklik.Text = SicaklikValue.ToString() + "°C";

                lbl_nem.Text = "%" + NemValue.ToString();

                instantIletkenlikValue.Text = IletkenlikValue.ToString() + " mS/cm";

                instantAkisHiziValue.Text = AkisHiziValue.ToString() + " m/s";

                instantDesarjDebiValue.Text = DesarjDebiValue.ToString() + " m³/d";

                //1 Dakikalik Tüm Verilerin Veritabanına Kaydı

                AllData alldata = new AllData();

                alldata.Readtime = time;
                alldata.Stationid = new Guid(lbl_simId.Text);
                alldata.SoftwareVersion = "1.0.0";
                alldata.Period = 1;
                alldata.AKM = AkmValue;
                alldata.AkisHizi = AkisHiziValue;
                alldata.CozunmusOksijen = OksijenValue;
                alldata.Debi = DebiValue;
                alldata.KOi = KoiValue;
                alldata.pH = PhValue;
                alldata.Sicaklik = SicaklikValue;
                alldata.Iletkenlik = IletkenlikValue;
                alldata.NumuneNem = NemValue;
                alldata.NumuneSicaklik = SicaklikValue;
                alldata.Pompa1Hz = Pompa1Hz;
                alldata.Pompa2Hz = Pompa2Hz;
                alldata.Status = status;

                sqlSave.TumDataKaydet(alldata);

                //1 Dakikalik Tüm Verilerin Veritabanına Kaydı


                BitVeriler bitVeriler = new BitVeriler();

                DeserializeResult deserializeResult = new DeserializeResult();
                deserializeResult.AKM_N_Status = sqlSave.DonenVeriGetir();

                if (deserializeResult.AKM_N_Status == 1)
                {
                    bitVeriler.VeriDurumu = true;
                }
                else
                {
                    bitVeriler.VeriDurumu = false;
                }

                bitVeriler.Readtime = time;
                bitVeriler.Kapi = KapiValue;
                bitVeriler.Duman = DumanValue;
                bitVeriler.SuBaskini = SuBaskiniValue;
                bitVeriler.AcilStop = AcilStopValue;
                bitVeriler.Pompa1Termik = Pompa1TermikValue;
                bitVeriler.Pompa2Termik = Pompa2TermikValue;
                bitVeriler.TemizSuPompaTermik = TemizSuTermikValue;
                bitVeriler.YikamaTanki = YikamaTankiValue;
                bitVeriler.Enerji = EnerjiValue;
                bitVeriler.AutoStat = AutoStat;
                bitVeriler.YikamaStat = YikamaStat;
                bitVeriler.HaftalikYikamaStat = HaftalikYikamaStat;
                bitVeriler.KalibrasyonStat = KalibrasyonStat;
                bitVeriler.BakimStat = BakimStat;
                bitVeriler.Pompa1CalisiyorMu = Pompa1CalisiyorMu;
                bitVeriler.Pompa2CalisiyorMu = Pompa2CalisiyorMu;

                sqlSave.BitVerilerKaydet(bitVeriler);

                //Çekilen bit değerlerin controllere atanması

                #region Bit Değerler

                lbl_kapiInstantValue.Text = KapiValue == true ? "Açık" : "Kapalı";
                lbl_kapiDesc.Text = KapiValue == true ? "Kapı Açık" : "Kapı Kapalı";

                lbl_dumanInstantValue.Text = DumanValue == true ? "Var" : "Yok";
                lbl_dumanDesc.Text = DumanValue == true ? "İçeride duman var" : "İçeride duman yok";

                lbl_suBaskiniInstantValue.Text = SuBaskiniValue == true ? "Var" : "Yok";
                lbl_suBaskiniDesc.Text = SuBaskiniValue == true ? "Su Baskını Var" : "Su Baskını Yok";

                lbl_acilStopInstantValue.Text = AcilStopValue == true ? "Var" : "Yok";
                lbl_acilStopDesc.Text = AcilStopValue == true ? "Acil stopa basıldı" : "Acil stopa basılmadı";

                lbl_pompa1TermikInstantValue.Text = Pompa1TermikValue == true ? "Termik" : "Yok";
                lbl_pompa1TermikDesc.Text = Pompa1TermikValue == true ? "Termik attı" : "Termik yok";

                lbl_pompa2TermikInstantValue.Text = Pompa2TermikValue == true ? "Termik" : "Yok";
                lbl_pompa2TermikDesc.Text = Pompa2TermikValue == true ? "Termik attı" : "Termik yok";

                lbl_temizSuTermikInstantValue.Text = TemizSuTermikValue == true ? "Termik" : "Yok";
                lbl_temizSuTermikDesc.Text = TemizSuTermikValue == true ? "Termik Attı" : "Termik yok";

                lbl_yikamaTankiInstantValue.Text = YikamaTankiValue == true ? "Boş" : "Dolu";
                lbl_yikamaTankiDesc.Text = YikamaTankiValue == true ? "Yıkama tankı boş" : "Yıkama tankı dolu";

                lbl_enerjiInstantValue.Text = EnerjiValue == true ? "Yok" : "Var";
                lbl_enerjiDesc.Text = EnerjiValue == true ? "Enerji yok" : "Enerji var";

                #region Kabin Durumları Değerleri

                if (Pompa1Hz != 0)
                {
                    lbl_pompaDurum.Text = "Pompa 1 - " + Pompa1Hz + "Hz";
                }
                else if (Pompa2Hz != 0)
                {
                    lbl_pompaDurum.Text = "Pompa 2 - " + Pompa2Hz + "Hz";
                }
                else
                {
                    lbl_pompaDurum.Text = "Pompalar çalışmıyor";
                }

                #endregion

                #endregion

                #region Güncelleme Tarihlerinin Güncellenmesi


                //Üst Panel (Real Değerler)

                akmLastUpdate.Text = time.ToString();
                oksijenLastUpdate.Text = time.ToString();
                debiLastUpdate.Text = time.ToString();
                KOiLastUpdate.Text = time.ToString();
                phLastUpdate.Text = time.ToString();
                sicaklikLastUpdate.Text = time.ToString();
                iletkenlikLastUpdate.Text = time.ToString();
                akisHiziLastUpdate.Text = time.ToString();
                desarjDebiLastUpdate.Text = time.ToString();

                // Alt Panel (Bit Değerler)

                lbl_kapiLastUpdate.Text = time.ToString();
                lbl_dumanLastUpdate.Text = time.ToString();
                lbl_suBaskiniLastUpdate.Text = time.ToString();
                lbl_acilStopLastUpdate.Text = time.ToString();
                lbl_pompa1TermikLastUpdate.Text = time.ToString();
                lbl_pompa2TermikLastUpdate.Text = time.ToString();
                lbl_TemizSuTermikLastUpdate.Text = time.ToString();
                lbl_yikamaTankiLastUpdate.Text = time.ToString();
                lbl_enerjiLastUpdate.Text = time.ToString();

                #endregion

                //Son Gönderilen 5 verinin ortalamasının ekrana gösterimi
                sqlSave.OrtalamaSon5Dakika(lbl_minAvgAkm, lbl_minAvgOksijen, lbl_minAvgSicaklik, lbl_minAvgPh, lbl_minAvgIletkenlik, lbl_minAvgKOi, lbl_minAvgDebi, lbl_minAvgDesarjDebi, lbl_minAvgAkisHizi);

                //Son Gönderilen 1 saatlik verinin ortalamasının ekrana gösterimi
                sqlSave.OrtalamaSon60Dakika(lbl_hourAvgAkm, lbl_hourAvgOksijen, lbl_hourAvgSicaklik, lbl_hourAvgPh, lbl_hourAvgIletkenlik, lbl_hourAvgKOi, lbl_hourAvgDebi, lbl_hourAvgDesarjDebi, lbl_hourAvgAkisHizi);

                SonYikamayaKalan();
                SonHaftalikYikamayaKalan();
            };
            bgw_FormYukle.RunWorkerAsync();
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

            int kalangun;

            if ((int)tDT.DayOfWeek != 1)
            {
                int ayKacGun = DateTime.DaysInMonth(tDT.Year, tDT.Month);

                kalangun = 7 - (int)tDT.DayOfWeek;
                int normalGun = tDT.Day + kalangun;

                if (normalGun > ayKacGun)
                {
                    normalGun = normalGun + 1 - ayKacGun;
                }
                #endregion
            };

                //TimeSpan ts = yikamaZamani - DateTime.Now;
                string ayAdi = yikamaZamani.ToString("MMMM", new CultureInfo("tr-TR"));
                lbl_birSonrakiHaftalikYikama.Text = yikamaZamani.Day + " " + ayAdi + " Saat: " + yikamaZamani.Hour + ":" + yikamaZamani.Minute;
            }
            else if ((int)tDT.DayOfWeek == 1)
            {
                //DateTime yikamaZamani = new DateTime(tDT.Year, tDT.Month, normalGun, 6, 40, 0);
                DateTime yikamaZamani = new DateTime(tDT.Year, tDT.Month, tDT.Day, 6, 40, 0);

                //TimeSpan ts = yikamaZamani - DateTime.Now;
                string ayAdi = yikamaZamani.ToString("MMMM", new CultureInfo("tr-TR"));
                lbl_birSonrakiHaftalikYikama.Text = yikamaZamani.Day + " " + ayAdi + " Saat: " + yikamaZamani.Hour + ":" + yikamaZamani.Minute;
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
