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
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
        }

        private void Raporlama_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sAISKabiniDataSet.Veriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.verilerTableAdapter.Fill(this.sAISKabiniDataSet.Veriler);

            this.reportViewer2.RefreshReport();
        }

        private void btn_Olustur_Click(object sender, EventArgs e)
        {
        }
    }
}
