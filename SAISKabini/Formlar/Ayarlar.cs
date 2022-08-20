using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAISKabini
{
    public partial class Ayarlar : Form
    {
        #region Yan Form Çağırılması

        Ayarlar_IstasyonAyarlari ayarlar_IstasyonAyarlari = new Ayarlar_IstasyonAyarlari();

        #endregion
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void btn_istasyonAyarlari_Click(object sender, EventArgs e)
        {
            panel_content.Controls.Clear();
            ayarlar_IstasyonAyarlari.TopLevel = false;
            panel_content.Controls.Add(ayarlar_IstasyonAyarlari);
            ayarlar_IstasyonAyarlari.Show();
        }
    }
}
