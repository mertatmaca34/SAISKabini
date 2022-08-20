using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SAISKabini
{
    public partial class Ana : Form
    {
        //#region Yuvarlak Köşe DLL eklentisi
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

        #region Yan Formların Çağırılması

        readonly Anasayfa anasayfa = new Anasayfa();
        readonly Simulasyon simulasyon = new Simulasyon();
        readonly VeriOranlari veriOranlari = new VeriOranlari();
        readonly Kalibrasyon kalibrasyon = new Kalibrasyon();
        readonly MailAyarlari mailAyarlari = new MailAyarlari();
        readonly Raporlama raporlama = new Raporlama();
        readonly Ayarlar ayarlar = new Ayarlar();

        #endregion

        public DeserializeResult deserializeResult = new DeserializeResult();

        private void Ana_Load(object sender, EventArgs e)
        {
            #region Default Form Stilleri

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            panel_content.Controls.Clear();
            anasayfa.TopLevel = false;
            panel_content.Controls.Add(anasayfa);
            anasayfa.Show();


            #endregion
        }

        public Ana()
        {
            InitializeComponent();

            #region Butonları Gri Yapma
            foreach (Control item in leftPanel.Controls)
            {
                if (item.Name != "panel_menuPicker")
                {
                    if (item is Button)
                    {
                        Bitmap blue = new Bitmap((item as Button).Image);

                        int width = blue.Width;
                        int height = blue.Height;
                        for (int y = 0; y < height; y++)
                        {
                            for (int x = 0; x < width; x++)
                            {
                                Color color = blue.GetPixel(x, y);

                                int a = color.A;

                                blue.SetPixel(x, y, Color.FromArgb(a, 145, 145, 145));
                            }
                        }
                        (item as Button).Image = blue;
                    }
                    item.BackColor = Color.Transparent;
                }
            }

            //default anasayfa butonu renklendirmeleri
            btn_home.BackColor = Color.FromArgb(255, 227, 231, 232);
            SetDefaultButtonValues(btn_home, null); Bitmap bmp = new Bitmap(btn_home.Image);

            #endregion
        }

        #region Formu Tutup Hareket Ettirme
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void TableLayoutPanel_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Formu Gradient Renklendirme
        /*protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle, Color.FromArgb(255, 32, 30, 43), Color.FromArgb(255, 38, 26, 38), 245F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }*/

        #endregion

        #region Buton Köşelerini Oval Yapma
        private void Btn_home_Paint(object sender, PaintEventArgs e)
        {
            btn_home.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_home.Width, btn_home.Height, 5, 5));
            btn_veriOranlari.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_veriOranlari.Width, btn_veriOranlari.Height, 5, 5));
            btn_simulasyon.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_simulasyon.Width, btn_simulasyon.Height, 5, 5));
            btn_kalibrasyon.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_kalibrasyon.Width, btn_kalibrasyon.Height, 5, 5));
            btn_mailAyarlari.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_mailAyarlari.Width, btn_mailAyarlari.Height, 5, 5));
            btn_raporlama.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_raporlama.Width, btn_raporlama.Height, 5, 5));
            btn_ayarlar.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ayarlar.Width, btn_ayarlar.Height, 5, 5));
            btn_kayitlar.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_geceModu.Width, btn_geceModu.Height, 5, 5));
            btn_geceModu.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_geceModu.Width, btn_geceModu.Height, 5, 5));
            panel_menuPicker.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_menuPicker.Width, panel_menuPicker.Height, 5, 5));
            panel_content.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_content.Width, panel_content.Height, 5, 5));
            leftPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, -20, leftPanel.Width, leftPanel.Height, 5, 5));
        }
        #endregion

        #region Kapat ve Küçült Butonları
        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Buton Click ve Menu Picker Hareketi

        private void Btn_home_Click(object sender, EventArgs e)
        {
            panel_menuPicker.Location = new Point(panel_menuPicker.Location.X, btn_home.Location.Y + btn_home.Height / 2
                - panel_menuPicker.Height / 2);
            SetDefaultButtonValues(btn_home, null); 
            
            panel_content.Controls.Clear();
            anasayfa.TopLevel = false;
            panel_content.Controls.Add(anasayfa);
            anasayfa.Show();
        }
        private void Btn_dataRates_Click(object sender, EventArgs e)
        {
            panel_menuPicker.Location = new Point(panel_menuPicker.Location.X, btn_veriOranlari.Location.Y + btn_veriOranlari.Height / 2
                - panel_menuPicker.Height / 2);
            SetDefaultButtonValues(btn_veriOranlari, null);

            panel_content.Controls.Clear();
            veriOranlari.TopLevel = false;
            panel_content.Controls.Add(veriOranlari);
            veriOranlari.Show();
        }

        private void Btn_simulation_Click(object sender, EventArgs e)
        {
            panel_menuPicker.Location = new Point(panel_menuPicker.Location.X, btn_simulasyon.Location.Y + btn_simulasyon.Height / 2
                - panel_menuPicker.Height / 2);
            SetDefaultButtonValues(btn_simulasyon, null);

            panel_content.Controls.Clear();
            simulasyon.TopLevel = false;
            panel_content.Controls.Add(simulasyon);
            simulasyon.Show();
        }

        private void Btn_calibration_Click(object sender, EventArgs e)
        {
            panel_menuPicker.Location = new Point(panel_menuPicker.Location.X, btn_kalibrasyon.Location.Y + btn_kalibrasyon.Height / 2
                - panel_menuPicker.Height / 2);
            SetDefaultButtonValues(btn_kalibrasyon, null);

            panel_content.Controls.Clear();
            kalibrasyon.TopLevel = false;
            panel_content.Controls.Add(kalibrasyon);
            kalibrasyon.Show();
        }

        private void Btn_mailSettings_Click(object sender, EventArgs e)
        {
            panel_menuPicker.Location = new Point(panel_menuPicker.Location.X, btn_mailAyarlari.Location.Y + btn_mailAyarlari.Height / 2
                - panel_menuPicker.Height / 2);
            SetDefaultButtonValues(btn_mailAyarlari, null);

            panel_content.Controls.Clear();
            mailAyarlari.TopLevel = false;
            panel_content.Controls.Add(mailAyarlari);
            mailAyarlari.Show();
        }

        private void Btn_reporting_Click(object sender, EventArgs e)
        {
            panel_menuPicker.Location = new Point(panel_menuPicker.Location.X, btn_raporlama.Location.Y + btn_raporlama.Height / 2
                - panel_menuPicker.Height / 2);
            SetDefaultButtonValues(btn_raporlama, null);

            panel_content.Controls.Clear();
            raporlama.TopLevel = false;
            panel_content.Controls.Add(raporlama);
            raporlama.Show();
        }

        private void Btn_settings_Click(object sender, EventArgs e)
        {
            panel_menuPicker.Location = new Point(panel_menuPicker.Location.X, btn_ayarlar.Location.Y + btn_ayarlar.Height / 2
                - panel_menuPicker.Height / 2);
            SetDefaultButtonValues(btn_ayarlar, null);

            panel_content.Controls.Clear();
            ayarlar.TopLevel = false;
            panel_content.Controls.Add(ayarlar);
            ayarlar.Show();
        }

        private void Btn_logs_Click(object sender, EventArgs e)
        {
            panel_menuPicker.Location = new Point(panel_menuPicker.Location.X, btn_kayitlar.Location.Y + btn_kayitlar.Height / 2
                - panel_menuPicker.Height / 2);
            SetDefaultButtonValues(btn_kayitlar, null);
        }
        #endregion
        
        private void SetDefaultButtonValues(object sender, EventArgs e)
        {
            #region Butonları Beyaz Yapma
            foreach (Control item in leftPanel.Controls)
            {
                if (item.Name != "panel_menuPicker")
                {
                    if (item is Button)
                    {
                        Bitmap blue = new Bitmap((item as Button).Image);

                        int width = blue.Width;
                        int height = blue.Height;
                        for (int y = 0; y < height; y++)
                        {
                            for (int x = 0; x < width; x++)
                            {
                                Color color = blue.GetPixel(x, y);

                                int a = color.A;

                                blue.SetPixel(x, y, Color.FromArgb(a, 145, 145, 145));
                            }
                        }
                        (item as Button).Image = blue;
                    }
                    item.BackColor = Color.Transparent;
                }
            }
            #endregion

            #region Butonları Mavi Yapma
            Control click = (Control)sender;
            click.BackColor = Color.FromArgb(255, 227, 231, 232);
            if (click is Button)
            {
                Bitmap white = new Bitmap((click as Button).Image);

                int width = white.Width;
                int height = white.Height;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color color = white.GetPixel(x, y);

                        int a = color.A;

                        white.SetPixel(x, y, Color.FromArgb(a, 63, 178, 255));
                    }
                }
                (click as Button).Image = white;
            }
            #endregion
        }

        private void Btn_geceModu_Click(object sender, EventArgs e)
        {
            ChangeTheme(Controls);
            ChangeTheme(anasayfa.Controls);
            ChangeTheme(veriOranlari.Controls);
            ChangeTheme(simulasyon.Controls);
            ChangeTheme(kalibrasyon.Controls);
            ChangeTheme(mailAyarlari.Controls);
            ChangeTheme(raporlama.Controls);
            ChangeTheme(ayarlar.Controls);
        }

        private void ChangeTheme(Control.ControlCollection container)
        {
            ColorScheme scheme = new ColorScheme();

            foreach (Control component in container)
            {
                if (component is Panel)
                {
                    ChangeTheme(component.Controls);
                    component.BackColor = scheme.dark_PanelColor;
                    component.ForeColor = scheme.dark_ForeColor;
                }
                else if (component is Button)
                {
                    component.BackColor = scheme.dark_PanelColor;
                    component.ForeColor = scheme.dark_ForeColor;
                }
                else if (component is TextBox)
                {
                    component.BackColor = scheme.dark_PanelColor;
                    component.ForeColor = scheme.dark_ForeColor;
                }
                else if (component is TableLayoutPanel)
                {
                    component.BackColor = scheme.dark_BackColor;
                    component.ForeColor = scheme.dark_ForeColor;
                }
                else if (component is Label)
                {
                    component.BackColor = scheme.dark_BackColor;
                    component.ForeColor = scheme.dark_ForeColor;
                }
            }
        }

    }
}