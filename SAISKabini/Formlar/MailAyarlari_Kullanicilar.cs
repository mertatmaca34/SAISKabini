using SAISKabini.Entities;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SAISKabini
{
    public partial class MailAyarlari_Kullanicilar : Form
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

        readonly string[] newUser = new string[3];

        readonly SqlSave sqlSave = new SqlSave();

        readonly static string pcName = Environment.MachineName;
        readonly SqlConnection sqlConnection = new SqlConnection("Data Source=" + pcName + "\\SQLEXPRESS;Initial Catalog=SAISKabini;Integrated Security=True");

        public MailAyarlari_Kullanicilar()
        {
            InitializeComponent();

            #region Default Form Stilleri

            tablelyp_Left.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tablelyp_Left.Width, tablelyp_Left.Height, 20, 20));
            tablelyp_Right.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tablelyp_Right.Width, tablelyp_Right.Height, 20, 20));
            TableLayoutPanel_UserMailList.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, TableLayoutPanel_UserMailList.Width, TableLayoutPanel_UserMailList.Height, 20, 20));

            #endregion
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txtbox_Ad.Text != null)
            {
                newUser[0] = txtbox_Ad.Text;
                newUser[1] = txtbox_Soyad.Text;
                newUser[2] = txtbox_Mail.Text;

                ListViewItem itm = new ListViewItem(newUser);

                if (!listView1.Items.ContainsKey(itm.Text))
                {
                    listView1.Items.Add(itm);
                }

                MailKullanicilari mailKullanicilari = new MailKullanicilari();

                mailKullanicilari.Ad = newUser[0];
                mailKullanicilari.Soyad = newUser[1];
                mailKullanicilari.Mail = newUser[2];

                sqlSave.MailKullaniciKaydet(mailKullanicilari);

                txtbox_Ad.Text = null;
                txtbox_Soyad.Text = null;
                txtbox_Mail.Text = null;
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

                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM MailKullanicilari WHERE '" + itm.SubItems[2].Text + "' = Mail", sqlConnection);

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                }
                catch (Exception exc)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Kullanıcı silinirken hata! Detay: " + exc.Message);
                }

                listView1.Items.Remove((ListViewItem)item);
            }
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            groupBox6.Text = "Seçili Kullanıcı: " + listView1.SelectedItems[0].SubItems[2].Text;

            try
            {
                var itm = listView1.SelectedItems[0];

                txtbox_Ad.Text = itm.Text;
                txtbox_Soyad.Text = itm.SubItems[1].Text;
                txtbox_Mail.Text = itm.SubItems[2].Text;

                MailKullanicilari mailKullanicilari = new MailKullanicilari();

                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM MailKullanicilari WHERE '" + itm.SubItems[2].Text + "' = Mail", sqlConnection);
                    SqlDataReader rdr = sqlCommand.ExecuteReader();

                    mailKullanicilari.PhLimitAsimi = checkedListBox1.GetItemChecked(0);
                    mailKullanicilari.AkmLimitAsimi = checkedListBox1.GetItemChecked(1);
                    mailKullanicilari.KoiLimitAsimi = checkedListBox1.GetItemChecked(2);
                    mailKullanicilari.DumanAlarmi = checkedListBox1.GetItemChecked(3);
                    mailKullanicilari.SuBaskiniAlarmi = checkedListBox1.GetItemChecked(4);
                    mailKullanicilari.ElektrikAlarmi = checkedListBox1.GetItemChecked(5);
                    mailKullanicilari.KapiAlarmi = checkedListBox1.GetItemChecked(6);
                    mailKullanicilari.Pompa1Alarmi = checkedListBox1.GetItemChecked(7);
                    mailKullanicilari.Pompa2Alarmi = checkedListBox1.GetItemChecked(8);
                    mailKullanicilari.TemizSuPompaTermik = checkedListBox1.GetItemChecked(9);
                    mailKullanicilari.YikamaTanki = checkedListBox1.GetItemChecked(10);
                    mailKullanicilari.VeriDurumu = checkedListBox1.GetItemChecked(11);

                    while (rdr.Read())
                    {
                        if ((bool)rdr["PhLimitAsimi"] == true)
                        {
                            checkedListBox1.SetItemCheckState(0, CheckState.Checked);
                        }
                        if ((bool)rdr["AkmLimitAsimi"] == true)
                        {
                            checkedListBox1.SetItemCheckState(1, CheckState.Checked);
                        }
                        if ((bool)rdr["KoiLimitAsimi"] == true)
                        {
                            checkedListBox1.SetItemCheckState(2, CheckState.Checked);
                        }
                        if ((bool)rdr["DumanAlarmi"] == true)
                        {
                            checkedListBox1.SetItemCheckState(3, CheckState.Checked);
                        }
                        if ((bool)rdr["SuBaskiniAlarmi"] == true)
                        {
                            checkedListBox1.SetItemCheckState(4, CheckState.Checked);
                        }
                        if ((bool)rdr["ElektrikAlarmi"] == true)
                        {
                            checkedListBox1.SetItemCheckState(5, CheckState.Checked);
                        }
                        if ((bool)rdr["KapiAlarmi"] == true)
                        {
                            checkedListBox1.SetItemCheckState(6, CheckState.Checked);
                        }
                        if ((bool)rdr["Pompa1Alarmi"] == true)
                        {
                            checkedListBox1.SetItemCheckState(7, CheckState.Checked);
                        }
                        if ((bool)rdr["Pompa2Alarmi"] == true)
                        {
                            checkedListBox1.SetItemCheckState(8, CheckState.Checked);
                        }
                        if ((bool)rdr["TemizSuPompaTermik"] == true)
                        {
                            checkedListBox1.SetItemCheckState(9, CheckState.Checked);
                        }
                        if ((bool)rdr["YikamaTanki"] == true)
                        {
                            checkedListBox1.SetItemCheckState(10, CheckState.Checked);
                        }
                        if ((bool)rdr["VeriDurumu"] == true)
                        {
                            checkedListBox1.SetItemCheckState(11, CheckState.Checked);
                        }
                    }

                    sqlConnection.Close();
                }
                catch (Exception exc)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Mail Durumları yüklenirken hata! Detay: " + exc.Message);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden bir seçim yapınız.");
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            groupBox6.Text = "Seçili Kullanıcı: " + listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void btn_KaydetDurumSec_Click(object sender, EventArgs e)
        {
            if (groupBox6.Text == "Seçili Kullanıcı: -")
            {
                MessageBox.Show("Lütfen listeden bir kullanıcı seçin.");
            }
            else
            {
                MailKullanicilari mailKullanicilari = new MailKullanicilari();

                mailKullanicilari.Ad = listView1.SelectedItems[0].Text;
                mailKullanicilari.Soyad = listView1.SelectedItems[0].SubItems[1].Text;
                mailKullanicilari.Mail = listView1.SelectedItems[0].SubItems[2].Text;
                mailKullanicilari.PhLimitAsimi = checkedListBox1.GetItemChecked(0);
                mailKullanicilari.AkmLimitAsimi = checkedListBox1.GetItemChecked(1);
                mailKullanicilari.KoiLimitAsimi = checkedListBox1.GetItemChecked(2);
                mailKullanicilari.DumanAlarmi = checkedListBox1.GetItemChecked(3);
                mailKullanicilari.SuBaskiniAlarmi = checkedListBox1.GetItemChecked(4);
                mailKullanicilari.ElektrikAlarmi = checkedListBox1.GetItemChecked(5);
                mailKullanicilari.KapiAlarmi = checkedListBox1.GetItemChecked(6);
                mailKullanicilari.Pompa1Alarmi = checkedListBox1.GetItemChecked(7);
                mailKullanicilari.Pompa2Alarmi = checkedListBox1.GetItemChecked(8);
                mailKullanicilari.TemizSuPompaTermik = checkedListBox1.GetItemChecked(9);
                mailKullanicilari.YikamaTanki = checkedListBox1.GetItemChecked(10);
                mailKullanicilari.VeriDurumu = checkedListBox1.GetItemChecked(11);

                sqlSave.MailUserUpdate(mailKullanicilari);
            }
        }

        private void timer_AlarmKontrol_Tick(object sender, EventArgs e)
        {
            var bgw = new BackgroundWorker();
            bgw.DoWork += delegate
            {
                SendMail sendMail = new SendMail();

                sendMail.GelenAlarmlarKontrol();
            };
        }

    }
}
