using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SAISKabini
{
    public partial class Kalibrasyon : Form
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
        private protected ServicesModel Services { get; set; }

        readonly FormStyles formStyles = new FormStyles();

        readonly StationInfo istasyonBilgileri = new StationInfo();

        readonly MathematicalOps mathematicalOps = new MathematicalOps();

        readonly CalibrationData calibrationData = new CalibrationData();

        readonly PlcOpsCalibration plcOpsCalibration = new PlcOpsCalibration();

        readonly SqlSave sqlSave = new SqlSave();


        public double calibrationRef;

        public double tolerans = 1.1;

        public int kalibrasyonKalanSure = 0;

        public string seciliParametre = "";

        public Kalibrasyon()
        {
            InitializeComponent();

            this.Services = new ServicesModel("https://entegrationsais.csb.gov.tr/", StationType.SAIS);


            #region Default Form Stilleri

            tablelyp_kalibrasyonTop.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tablelyp_kalibrasyonTop.Width, tablelyp_kalibrasyonTop.Height, 20, 20));
            tablelyp_kalibrasyonDown.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tablelyp_kalibrasyonDown.Width, tablelyp_kalibrasyonDown.Height, 20, 20));
            tablelyP_pH.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tablelyP_pH.Width, tablelyP_pH.Height, 20, 20));
            tablelyP_Iletkenlik.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tablelyP_Iletkenlik.Width, tablelyP_Iletkenlik.Height, 20, 20));
            tablelyP_akm.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tablelyP_akm.Width, tablelyP_akm.Height, 20, 20));
            tablelyP_koi.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tablelyP_koi.Width, tablelyP_pH.Height, 20, 20));
            tablelyP_aciklama.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tablelyP_aciklama.Width, tablelyP_aciklama.Height, 20, 20));
            tablelyP_sorgu.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tablelyP_sorgu.Width, tablelyP_sorgu.Height, 20, 20));

            #endregion

            istasyonBilgileri = (StationInfo)sqlSave.IstasyonBilgiGetir();

            CheckForIllegalCrossThreadCalls = false;

        }
        private void Kalibrasyon_Load(object sender, EventArgs e)
        {
            foreach (Control item in tableLayoutPanel3.Controls)
            {
                if (item is TableLayoutPanel && item.Name != "tablelyP_TimeLeft")
                {
                    (item as TableLayoutPanel).CellPaint += new TableLayoutCellPaintEventHandler(formStyles.CellPaints);
                }
            }
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item is TableLayoutPanel)
                {
                    (item as TableLayoutPanel).CellPaint += new TableLayoutCellPaintEventHandler(formStyles.CellPaints);
                }
            }
        }
        private void btn_AkmZero_Click(object sender, EventArgs e)
        {
            if (lbl_KalanSure.Text == "Kalibrasyon Başlamadı")
            {
                calibrationData.Parametre = "AKM";
                calibrationData.ZeroRef = 0;
                kalibrasyonKalanSure = 10;
                lbl_KalanSure.Text = kalibrasyonKalanSure.ToString();
                lbl_SeciliKalibrasyon.Text = "AKM";
                timer_KalibrasyonZero.Enabled = true;
            }
        }

        private void btn_KoiZero_Click(object sender, EventArgs e)
        {
            if (lbl_KalanSure.Text == "Kalibrasyon Başlamadı")
            {
                calibrationData.Parametre = "KOi";
                calibrationData.ZeroRef = 0;
                kalibrasyonKalanSure = 10;
                lbl_KalanSure.Text = kalibrasyonKalanSure.ToString();
                lbl_SeciliKalibrasyon.Text = "KOi";
                timer_KalibrasyonZero.Enabled = true;
            }
        }

        private void btn_PhZero_Click(object sender, EventArgs e)
        {
            if (lbl_KalanSure.Text == "Kalibrasyon Başlamadı")
            {
                calibrationData.Parametre = "pH";
                calibrationData.ZeroRef = 7;
                kalibrasyonKalanSure = 60;
                lbl_KalanSure.Text = kalibrasyonKalanSure.ToString();
                lbl_SeciliKalibrasyon.Text = "pH";
                timer_KalibrasyonZero.Enabled = true;
            }
        }

        private void btn_IletkenlikZero_Click(object sender, EventArgs e)
        {
            if (lbl_KalanSure.Text == "Kalibrasyon Başlamadı")
            {
                calibrationData.Parametre = "Iletkenlik";
                calibrationData.ZeroRef = 0;
                kalibrasyonKalanSure = 30;
                lbl_KalanSure.Text = kalibrasyonKalanSure.ToString();
                lbl_SeciliKalibrasyon.Text = "Iletkenlik";
                timer_KalibrasyonZero.Enabled = true;
            }
        }

        private void btn_PhSpan_Click(object sender, EventArgs e)
        {
            if (lbl_KalanSure.Text == "Kalibrasyon Başlamadı")
            {
                calibrationData.Parametre = "pH";
                calibrationData.ZeroRef = 0;
                kalibrasyonKalanSure = 60;
                lbl_KalanSure.Text = kalibrasyonKalanSure.ToString();
                lbl_SeciliKalibrasyon.Text = "pH";
                timer_KalibrasyonZero.Enabled = true;
            }
        }

        private void btn_IletkenlikSpan_Click(object sender, EventArgs e)
        {
            if (lbl_KalanSure.Text == "Kalibrasyon Başlamadı")
            {
                calibrationData.Parametre = "Iletkenlik";
                calibrationData.ZeroRef = 0;
                kalibrasyonKalanSure = 90;
                lbl_KalanSure.Text = kalibrasyonKalanSure.ToString();
                lbl_SeciliKalibrasyon.Text = "Iletkenlik";
                timer_KalibrasyonZero.Enabled = true;
            }
        }

        private void timer_Kalibrasyon_Tick(object sender, EventArgs e)
        {
            kalibrasyonKalanSure--;

            kalibrasyonKalanSure = KalibrasyonYapZero(kalibrasyonKalanSure, calibrationData.Parametre);
            
            lbl_KalanSure.Text = kalibrasyonKalanSure.ToString();

        }

        private void timer_KalibrasyonSpan_Tick(object sender, EventArgs e)
        {
            kalibrasyonKalanSure--;

            kalibrasyonKalanSure = KalibrasyonYapSpan(kalibrasyonKalanSure, calibrationData.Parametre);

            lbl_KalanSure.Text = kalibrasyonKalanSure.ToString();
        }

        private int KalibrasyonYapZero(int sure, string parametre)
        {
            plcOpsCalibration.SetRealValues();

            double refDeger = calibrationData.ZeroRef;


            var bgw = new BackgroundWorker();
            bgw.DoWork += delegate
            {
                Services.Login(istasyonBilgileri.kullaniciAdi, istasyonBilgileri.kullaniciSifresi);

                if (parametre == "AKM")
                {
                    refDeger = calibrationData.ZeroRef;
                    double anlikDeger = plcOpsCalibration.AkmValue;

                    lbl_AnlikDeger.Text = anlikDeger.ToString();
                    lbl_ZeroRef.Text = refDeger.ToString();
                    lbl_ZeroMeas.Text = anlikDeger.ToString();
                    lbl_ZeroDiff.Text = Math.Round((anlikDeger - refDeger),2).ToString();


                    this.chart1.Series["Kalibrasyon Adı"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), anlikDeger);
                    this.chart1.Series["Referans Çizgisi"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), refDeger);


                    if (anlikDeger >= refDeger / tolerans && anlikDeger <= refDeger * tolerans)
                    {
                        this.chart1.Series["Kalibrasyon Adı"].Color = Color.Lime;
                    }
                    else
                    {
                        this.chart1.Series["Kalibrasyon Adı"].Color = Color.Red;
                    }

                    if (sure == 0)
                    {
                        timer_KalibrasyonZero.Enabled = false;

                        bool sonuc = false;

                        if (this.chart1.Series["Kalibrasyon Adı"].Color == Color.Lime)
                        {
                            MessageBox.Show("Kalibrasyon Başarılı");

                            sonuc = true;
                            btn_AkmZero.BackColor = Color.Lime;

                            this.chart1.Series["Kalibrasyon Adı"].Points.Clear();
                            this.chart1.Series["Referans Çizgisi"].Points.Clear();

                            lbl_KalanSure.Text = "Kalibrasyon Başlamadı";
                        }
                        else if (this.chart1.Series["Kalibrasyon Adı"].Color == Color.Red)
                        {
                            MessageBox.Show("Kalibrasyon Başarısız");

                            sonuc = false;
                            btn_AkmZero.BackColor = Color.Red;

                            this.chart1.Series["Kalibrasyon Adı"].Points.Clear();
                            this.chart1.Series["Referans Çizgisi"].Points.Clear();

                            lbl_KalanSure.Text = "Kalibrasyon Başlamadı";
                        }

                        //Kalibrasyonu Bakanlığa Gönder

                        var data = new SendCalibration
                        {
                            CalibrationDate = plcOpsCalibration.GetPlcTime(),
                            Stationid = new Guid(istasyonBilgileri.simId),
                            DBColumnName = "AKM",
                            ZeroRef = calibrationData.ZeroRef,
                            ZeroMeas = anlikDeger,
                            ZeroDiff = (anlikDeger - refDeger),
                            ZeroSTD = 0,
                            SpanRef = 0,
                            SpanMeas = 0,
                            SpanDiff = 0,
                            SpanSTD = 0,
                            ResultFactor = 1,
                            ResultZero = sonuc,
                            ResultSpan = true
                        };
                        Services.sendCalibration(data);
                    }
                }
                else if (parametre == "KOi")
                {
                    refDeger = calibrationData.ZeroRef;

                    double anlikDeger = plcOpsCalibration.KoiValue;

                    lbl_AnlikDeger.Text = anlikDeger.ToString();
                    lbl_ZeroRef.Text = refDeger.ToString();
                    lbl_ZeroMeas.Text = anlikDeger.ToString();
                    lbl_ZeroDiff.Text = Math.Round((anlikDeger - refDeger), 2).ToString();


                    this.chart1.Series["Kalibrasyon Adı"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), anlikDeger);
                    this.chart1.Series["Referans Çizgisi"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), refDeger);


                    if (anlikDeger >= refDeger / tolerans && anlikDeger <= refDeger * tolerans)
                    {
                        this.chart1.Series["Kalibrasyon Adı"].Color = Color.Lime;
                    }
                    else
                    {
                        this.chart1.Series["Kalibrasyon Adı"].Color = Color.Red;
                    }

                    if (sure == 0)
                    {
                        timer_KalibrasyonZero.Enabled = false;

                        bool sonuc = false;

                        if (this.chart1.Series["Kalibrasyon Adı"].Color == Color.Lime)
                        {
                            MessageBox.Show("Kalibrasyon Başarılı");

                            sonuc = true;
                            btn_KoiZero.BackColor = Color.Lime;

                            this.chart1.Series["Kalibrasyon Adı"].Points.Clear();
                            this.chart1.Series["Referans Çizgisi"].Points.Clear();

                            lbl_KalanSure.Text = "Kalibrasyon Başlamadı";
                        }
                        else if (this.chart1.Series["Kalibrasyon Adı"].Color == Color.Red)
                        {
                            MessageBox.Show("Kalibrasyon Başarısız");

                            sonuc = false;
                            btn_KoiZero.BackColor = Color.Red;

                            this.chart1.Series["Kalibrasyon Adı"].Points.Clear();
                            this.chart1.Series["Referans Çizgisi"].Points.Clear();

                            lbl_KalanSure.Text = "Kalibrasyon Başlamadı";
                        }
                        //Kalibrasyonu Bakanlığa Gönder

                        var data = new SendCalibration
                        {
                            CalibrationDate = plcOpsCalibration.GetPlcTime(),
                            Stationid = new Guid(istasyonBilgileri.simId),
                            DBColumnName = "KOi",
                            ZeroRef = calibrationData.ZeroRef,
                            ZeroMeas = anlikDeger,
                            ZeroDiff = (anlikDeger - refDeger),
                            ZeroSTD = 0,
                            SpanRef = 0,
                            SpanMeas = 0,
                            SpanDiff = 0,
                            SpanSTD = 0,
                            ResultFactor = 1,
                            ResultZero = sonuc,
                            ResultSpan = true
                        };
                        Services.sendCalibration(data);
                    }                    
                }
                else if (parametre == "pH")
                {
                    refDeger = calibrationData.ZeroRef;

                    double anlikDeger = plcOpsCalibration.PhValue;

                    lbl_AnlikDeger.Text = anlikDeger.ToString();
                    lbl_ZeroRef.Text = refDeger.ToString();
                    lbl_ZeroMeas.Text = anlikDeger.ToString();
                    lbl_ZeroDiff.Text = Math.Round((anlikDeger - refDeger), 2).ToString();


                    this.chart1.Series["Kalibrasyon Adı"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), anlikDeger);
                    this.chart1.Series["Referans Çizgisi"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), refDeger);


                    if (anlikDeger >= refDeger / tolerans && anlikDeger <= refDeger * tolerans)
                    {
                        this.chart1.Series["Kalibrasyon Adı"].Color = Color.Lime;
                    }
                    else
                    {
                        this.chart1.Series["Kalibrasyon Adı"].Color = Color.Red;
                    }

                    if (sure == 0)
                    {

                        timer_KalibrasyonZero.Enabled = false;

                        if (this.chart1.Series["Kalibrasyon Adı"].Color == Color.Lime)
                        {
                            MessageBox.Show("Kalibrasyon Başarılı");

                            calibrationData.ZeroGecerlimi = true;

                            btn_PhZero.BackColor = Color.Lime;

                            this.chart1.Series["Kalibrasyon Adı"].Points.Clear();
                            this.chart1.Series["Referans Çizgisi"].Points.Clear();

                            lbl_KalanSure.Text = "Kalibrasyon Başlamadı";
                        }
                        else if (this.chart1.Series["Kalibrasyon Adı"].Color == Color.Red)
                        {
                            MessageBox.Show("Kalibrasyon Başarısız");

                            calibrationData.ZeroGecerlimi = false;

                            btn_PhZero.BackColor = Color.Red;

                            this.chart1.Series["Kalibrasyon Adı"].Points.Clear();
                            this.chart1.Series["Referans Çizgisi"].Points.Clear();

                            lbl_KalanSure.Text = "Kalibrasyon Başlamadı";
                        }

                        calibrationData.ZeroMeas = anlikDeger;
                        calibrationData.ZeroDiff = anlikDeger - refDeger;
                        calibrationData.ZeroStd = 1;
                    }
                }
                else if (parametre == "Iletkenlik")
                {
                    refDeger = calibrationData.ZeroRef;

                    double anlikDeger = plcOpsCalibration.PhValue;

                    lbl_AnlikDeger.Text = anlikDeger.ToString();
                    lbl_ZeroRef.Text = refDeger.ToString();
                    lbl_ZeroMeas.Text = anlikDeger.ToString();
                    lbl_ZeroDiff.Text = Math.Round((anlikDeger - refDeger), 2).ToString();


                    this.chart1.Series["Kalibrasyon Adı"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), anlikDeger);
                    this.chart1.Series["Referans Çizgisi"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), refDeger);


                    if (anlikDeger >= refDeger / tolerans && anlikDeger <= refDeger * tolerans)
                    {
                        this.chart1.Series["Kalibrasyon Adı"].Color = Color.Lime;
                    }
                    else
                    {
                        this.chart1.Series["Kalibrasyon Adı"].Color = Color.Red;
                    }

                    if (sure == 0)
                    {
                        timer_KalibrasyonZero.Enabled = false;

                        if (this.chart1.Series["Kalibrasyon Adı"].Color == Color.Lime)
                        {
                            MessageBox.Show("Kalibrasyon Başarılı");

                            calibrationData.ZeroGecerlimi = true;

                            btn_IletkenlikZero.BackColor = Color.Lime;

                            this.chart1.Series["Kalibrasyon Adı"].Points.Clear();
                            this.chart1.Series["Referans Çizgisi"].Points.Clear();

                            lbl_KalanSure.Text = "Kalibrasyon Başlamadı";
                        }
                        else if (this.chart1.Series["Kalibrasyon Adı"].Color == Color.Red)
                        {
                            MessageBox.Show("Kalibrasyon Başarısız");

                            calibrationData.ZeroGecerlimi = false;

                            btn_IletkenlikZero.BackColor = Color.Red;

                            this.chart1.Series["Kalibrasyon Adı"].Points.Clear();
                            this.chart1.Series["Referans Çizgisi"].Points.Clear();

                            lbl_KalanSure.Text = "Kalibrasyon Başlamadı";
                        }

                        calibrationData.ZeroMeas = anlikDeger;
                        calibrationData.ZeroDiff = anlikDeger - refDeger;
                        calibrationData.ZeroStd = 1;
                    }
                }

            };
            bgw.RunWorkerAsync();

            return sure;
        }

        private int KalibrasyonYapSpan(int sure, string parametre)
        {
            plcOpsCalibration.SetRealValues();

            double refDeger = calibrationData.SpanRef;


            var bgw = new BackgroundWorker();
            bgw.DoWork += delegate
            {
                Services.Login(istasyonBilgileri.kullaniciAdi, istasyonBilgileri.kullaniciSifresi);

                if (parametre == "pH")
                {
                    refDeger = calibrationData.SpanRef;

                    double anlikDeger = plcOpsCalibration.PhValue;

                    lbl_AnlikDeger.Text = anlikDeger.ToString();
                    lbl_SpanRef.Text = refDeger.ToString();
                    lbl_SpanMeas.Text = anlikDeger.ToString();
                    lbl_SpanDiff.Text = (anlikDeger - refDeger).ToString();


                    this.chart1.Series["Kalibrasyon Adı"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), anlikDeger);
                    this.chart1.Series["Referans Çizgisi"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), refDeger);


                    if (anlikDeger >= refDeger / tolerans && anlikDeger <= refDeger * tolerans)
                    {
                        this.chart1.Series["Kalibrasyon Adı"].Color = Color.Lime;
                    }
                    else
                    {
                        this.chart1.Series["Kalibrasyon Adı"].Color = Color.Red;
                    }

                    if (sure == 0)
                    {

                        timer_KalibrasyonZero.Enabled = false;

                        if (this.chart1.Series["Kalibrasyon Adı"].Color == Color.Lime)
                        {
                            MessageBox.Show("Kalibrasyon Başarılı");

                            calibrationData.SpanGecerlimi = true;

                            btn_PhSpan.BackColor = Color.Lime;

                            this.chart1.Series["Kalibrasyon Adı"].Points.Clear();
                            this.chart1.Series["Referans Çizgisi"].Points.Clear();

                            lbl_KalanSure.Text = "Kalibrasyon Başlamadı";
                        }
                        else if (this.chart1.Series["Kalibrasyon Adı"].Color == Color.Red)
                        {
                            MessageBox.Show("Kalibrasyon Başarısız");

                            calibrationData.SpanGecerlimi = false;

                            btn_PhSpan.BackColor = Color.Red;

                            this.chart1.Series["Kalibrasyon Adı"].Points.Clear();
                            this.chart1.Series["Referans Çizgisi"].Points.Clear();

                            lbl_KalanSure.Text = "Kalibrasyon Başlamadı";
                        }

                        calibrationData.SpanMeas = anlikDeger;
                        calibrationData.SpanDiff = anlikDeger - refDeger;
                        calibrationData.SpanStd = 1;

                        //Kalibrasyonu Bakanlığa Gönder
                        var data = new SendCalibration
                        {
                            CalibrationDate = plcOpsCalibration.GetPlcTime(),
                            Stationid = new Guid(istasyonBilgileri.simId),
                            DBColumnName = "pH",
                            ZeroRef = calibrationData.ZeroRef,
                            ZeroMeas = calibrationData.ZeroMeas,
                            ZeroDiff = calibrationData.ZeroDiff,
                            ZeroSTD = calibrationData.ZeroStd,
                            SpanRef = calibrationData.SpanRef,
                            SpanMeas = calibrationData.SpanMeas,
                            SpanDiff = calibrationData.SpanDiff,
                            SpanSTD = calibrationData.SpanStd,
                            ResultFactor = 1,
                            ResultZero = calibrationData.ZeroGecerlimi,
                            ResultSpan = calibrationData.SpanGecerlimi
                        };
                        Services.sendCalibration(data);
                    }
                }
                else if (parametre == "Iletkenlik")
                {
                    refDeger = calibrationData.ZeroRef;

                    double anlikDeger = plcOpsCalibration.PhValue;

                    lbl_AnlikDeger.Text = anlikDeger.ToString();
                    lbl_ZeroRef.Text = refDeger.ToString();
                    lbl_ZeroMeas.Text = anlikDeger.ToString();
                    lbl_ZeroDiff.Text = Math.Round((anlikDeger - refDeger), 2).ToString();


                    this.chart1.Series["Kalibrasyon Adı"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), anlikDeger);
                    this.chart1.Series["Referans Çizgisi"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), refDeger);


                    if (anlikDeger >= refDeger / tolerans && anlikDeger <= refDeger * tolerans)
                    {
                        this.chart1.Series["Kalibrasyon Adı"].Color = Color.Lime;
                    }
                    else
                    {
                        this.chart1.Series["Kalibrasyon Adı"].Color = Color.Red;
                    }

                    if (sure == 0)
                    {
                        timer_KalibrasyonZero.Enabled = false;

                        if (this.chart1.Series["Kalibrasyon Adı"].Color == Color.Lime)
                        {
                            MessageBox.Show("Kalibrasyon Başarılı");

                            calibrationData.SpanGecerlimi = true;

                            btn_IletkenlikSpan.BackColor = Color.Lime;

                            this.chart1.Series["Kalibrasyon Adı"].Points.Clear();
                            this.chart1.Series["Referans Çizgisi"].Points.Clear();

                            lbl_KalanSure.Text = "Kalibrasyon Başlamadı";
                        }
                        else if (this.chart1.Series["Kalibrasyon Adı"].Color == Color.Red)
                        {
                            MessageBox.Show("Kalibrasyon Başarısız");

                            calibrationData.SpanGecerlimi = false;

                            btn_IletkenlikSpan.BackColor = Color.Red;

                            this.chart1.Series["Kalibrasyon Adı"].Points.Clear();
                            this.chart1.Series["Referans Çizgisi"].Points.Clear();

                            lbl_KalanSure.Text = "Kalibrasyon Başlamadı";
                        }

                        //Kalibrasyonu Bakanlığa Gönder
                        var data = new SendCalibration
                        {
                            CalibrationDate = plcOpsCalibration.GetPlcTime(),
                            Stationid = new Guid(istasyonBilgileri.simId),
                            DBColumnName = "pH",
                            ZeroRef = calibrationData.ZeroRef,
                            ZeroMeas = calibrationData.ZeroMeas,
                            ZeroDiff = calibrationData.ZeroDiff,
                            ZeroSTD = calibrationData.ZeroStd,
                            SpanRef = calibrationData.SpanRef,
                            SpanMeas = calibrationData.SpanMeas,
                            SpanDiff = calibrationData.SpanDiff,
                            SpanSTD = calibrationData.SpanStd,
                            ResultFactor = 1,
                            ResultZero = calibrationData.ZeroGecerlimi,
                            ResultSpan = calibrationData.SpanGecerlimi
                        };
                        Services.sendCalibration(data);
                    }

                    calibrationData.SpanMeas = anlikDeger;
                    calibrationData.SpanDiff = anlikDeger - refDeger;
                    calibrationData.SpanStd = 1;
                }

            };
            bgw.RunWorkerAsync();

            return sure;
        }

    }
}
