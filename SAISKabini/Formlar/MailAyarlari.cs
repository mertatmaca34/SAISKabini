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
    public partial class MailAyarlari : Form
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

        #region Yan Formların Çağırılması

        MailAyarlari_Kullanicilar mailAyarlari_Kullanicilar = new MailAyarlari_Kullanicilar();
        MailAyarlari_MailDurumlari mailAyarlari_MailDurumlari = new MailAyarlari_MailDurumlari();
        MailAyarlari_MailServerAyarlari mailServerAyarlari = new MailAyarlari_MailServerAyarlari();

        #endregion

        public MailAyarlari()
        {
            InitializeComponent();

            panel_content.Controls.Clear();
            mailAyarlari_Kullanicilar.TopLevel = false;
            panel_content.Controls.Add(mailAyarlari_Kullanicilar);
            mailAyarlari_Kullanicilar.Show();
        }


        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_content.Controls.Clear();
            mailAyarlari_Kullanicilar.TopLevel = false;
            panel_content.Controls.Add(mailAyarlari_Kullanicilar);
            mailAyarlari_Kullanicilar.Show();
        }

        private void mailDurumlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_content.Controls.Clear();
            mailAyarlari_MailDurumlari.TopLevel = false;
            panel_content.Controls.Add(mailAyarlari_MailDurumlari);
            mailAyarlari_MailDurumlari.Show();
        }

        private void mailServerAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_content.Controls.Clear();
            mailServerAyarlari.TopLevel = false;
            panel_content.Controls.Add(mailServerAyarlari);
            mailServerAyarlari.Show();
        }
    }
}
