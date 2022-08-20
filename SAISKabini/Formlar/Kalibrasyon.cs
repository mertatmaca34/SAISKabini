using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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

        public double degisken = 7;
        public Kalibrasyon()
        {
            InitializeComponent();

            #region Default Form Stilleri

            tablelyp_kalibrasyonTop.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, tablelyp_kalibrasyonTop.Width - 10, tablelyp_kalibrasyonTop.Height - 10, 20, 20));
            tablelyp_kalibrasyonDown.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, tablelyp_kalibrasyonDown.Width - 10, tablelyp_kalibrasyonDown.Height - 10, 20, 20));

            #endregion
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            degisken += 0.2;
            this.chart1.Series["Kalibrasyon Adı"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), degisken);
            this.chart1.Series["Referans Çizgisi"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), 7);
        }

        private void timer_Kalibrasyon_Tick(object sender, EventArgs e)
        {
            backgroundWorker3.RunWorkerAsync();
        }
    }
}
