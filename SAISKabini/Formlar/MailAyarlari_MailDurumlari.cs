using SAISKabini.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SAISKabini
{
    public partial class MailAyarlari_MailDurumlari : Form
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

        readonly SqlSave sqlSave = new SqlSave();

        readonly static string pcName = Environment.MachineName;
        readonly SqlConnection sqlConnection = new SqlConnection("Data Source=" + pcName + "\\SQLEXPRESS;Initial Catalog=SAISKabini;Integrated Security=True");

        public MailAyarlari_MailDurumlari()
        {
            InitializeComponent();

            #region Default Form Stilleri

            /*tablelyp_left.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tablelyp_left.Width, tablelyp_left.Height, 20, 20));
            tablelyp_right.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tablelyp_right.Width, tablelyp_right.Height, 20, 20));
            btn_Duzenle.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Duzenle.Width, btn_Duzenle.Height, 10, 10));
            btn_Kaydet.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Kaydet.Width, btn_Kaydet.Height, 10, 10));
            btn_Sil.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Sil.Width, btn_Sil.Height, 10, 10));
            btn_Yeni.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Yeni.Width, btn_Yeni.Height, 10, 10));
            */
            #endregion

        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                var itm = listView1.SelectedItems[0];

                txtBox_DurumAdi.Text = itm.Text;
                cmBox_MesajAraligi.SelectedItem = itm.SubItems[1].Text;
                cmBox_Parametre.SelectedItem = itm.SubItems[2].Text;
                cmBox_Kosul.SelectedItem = itm.SubItems[3].Text;
                txtBox_Deger.Text = itm.SubItems[4].Text;
                txtBox_MailContent.Text = itm.SubItems[5].Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden bir seçim yapınız.");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            var tempv = listView1.SelectedItems;

            foreach (var item in tempv)
            {
                try
                {
                    var itm = listView1.SelectedItems[0];
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM MailDurumlari WHERE '" + itm.Text + "' = DurumAdi", sqlConnection);

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                }
                catch (Exception exc)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Mail Durumu silinirken hata! Detay: " + exc.Message);
                }
                listView1.Items.Remove((ListViewItem)item);
            }            
        }
    }
}
