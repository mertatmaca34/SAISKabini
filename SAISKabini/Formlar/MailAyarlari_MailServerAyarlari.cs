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
    public partial class MailAyarlari_MailServerAyarlari : Form
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

        readonly FormStyles formStyles = new FormStyles();

        public MailAyarlari_MailServerAyarlari()
        {
            InitializeComponent();

            #region Default Form Stilleri

            tablelyp.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tablelyp.Width, tablelyp.Height, 20, 20));
            btn_Kaydet.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Kaydet.Width, btn_Kaydet.Height, 10, 10));

            #endregion
        }
    }
}
