namespace SAISKabini
{
    partial class Ana
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel_TitleBar = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel_menuPicker = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_veriOranlari = new System.Windows.Forms.Button();
            this.btn_geceModu = new System.Windows.Forms.Button();
            this.btn_simulasyon = new System.Windows.Forms.Button();
            this.btn_kayitlar = new System.Windows.Forms.Button();
            this.btn_kalibrasyon = new System.Windows.Forms.Button();
            this.btn_ayarlar = new System.Windows.Forms.Button();
            this.btn_mailAyarlari = new System.Windows.Forms.Button();
            this.btn_raporlama = new System.Windows.Forms.Button();
            this.panel_content = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mainTitle.AutoSize = true;
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainTitle.Location = new System.Drawing.Point(47, 23);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(221, 15);
            this.mainTitle.TabIndex = 5;
            this.mainTitle.Text = "Şile Kumbaba - Bakanlık Kabini Yazılımı";
            // 
            // tableLayoutPanel_TitleBar
            // 
            this.tableLayoutPanel_TitleBar.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel_TitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel_TitleBar.ColumnCount = 7;
            this.tableLayoutPanel_TitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.357664F));
            this.tableLayoutPanel_TitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.34307F));
            this.tableLayoutPanel_TitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.02968F));
            this.tableLayoutPanel_TitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.28864F));
            this.tableLayoutPanel_TitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_TitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_TitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel_TitleBar.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel_TitleBar.Controls.Add(this.mainTitle, 1, 0);
            this.tableLayoutPanel_TitleBar.Controls.Add(this.btn_close, 6, 0);
            this.tableLayoutPanel_TitleBar.Controls.Add(this.btn_minimize, 5, 0);
            this.tableLayoutPanel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_TitleBar.Name = "tableLayoutPanel_TitleBar";
            this.tableLayoutPanel_TitleBar.RowCount = 1;
            this.tableLayoutPanel_TitleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TitleBar.Size = new System.Drawing.Size(1500, 62);
            this.tableLayoutPanel_TitleBar.TabIndex = 6;
            this.tableLayoutPanel_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TableLayoutPanel_TitleBar_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::SAISKabini.Properties.Resources.proximity_sensor_24px_blue;
            this.pictureBox1.Location = new System.Drawing.Point(17, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_close.AutoSize = true;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::SAISKabini.Properties.Resources.close_white;
            this.btn_close.Location = new System.Drawing.Point(1441, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 6;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_minimize.AutoSize = true;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = global::SAISKabini.Properties.Resources.minimize_white;
            this.btn_minimize.Location = new System.Drawing.Point(1377, 3);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_minimize.TabIndex = 6;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.panel_menuPicker);
            this.leftPanel.Controls.Add(this.btn_home);
            this.leftPanel.Controls.Add(this.btn_veriOranlari);
            this.leftPanel.Controls.Add(this.btn_geceModu);
            this.leftPanel.Controls.Add(this.btn_simulasyon);
            this.leftPanel.Controls.Add(this.btn_kayitlar);
            this.leftPanel.Controls.Add(this.btn_kalibrasyon);
            this.leftPanel.Controls.Add(this.btn_ayarlar);
            this.leftPanel.Controls.Add(this.btn_mailAyarlari);
            this.leftPanel.Controls.Add(this.btn_raporlama);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 62);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(90, 738);
            this.leftPanel.TabIndex = 9;
            // 
            // panel_menuPicker
            // 
            this.panel_menuPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.panel_menuPicker.Location = new System.Drawing.Point(8, 29);
            this.panel_menuPicker.Name = "panel_menuPicker";
            this.panel_menuPicker.Size = new System.Drawing.Size(5, 24);
            this.panel_menuPicker.TabIndex = 0;
            // 
            // btn_home
            // 
            this.btn_home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_home.Image = global::SAISKabini.Properties.Resources.home_blue;
            this.btn_home.Location = new System.Drawing.Point(8, 6);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 71);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Anasayfa";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.Btn_home_Click);
            this.btn_home.Paint += new System.Windows.Forms.PaintEventHandler(this.Btn_home_Paint);
            // 
            // btn_veriOranlari
            // 
            this.btn_veriOranlari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_veriOranlari.BackColor = System.Drawing.Color.Transparent;
            this.btn_veriOranlari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_veriOranlari.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_veriOranlari.FlatAppearance.BorderSize = 0;
            this.btn_veriOranlari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btn_veriOranlari.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btn_veriOranlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_veriOranlari.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_veriOranlari.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_veriOranlari.Image = global::SAISKabini.Properties.Resources.monitoring2_white;
            this.btn_veriOranlari.Location = new System.Drawing.Point(8, 83);
            this.btn_veriOranlari.Name = "btn_veriOranlari";
            this.btn_veriOranlari.Size = new System.Drawing.Size(75, 71);
            this.btn_veriOranlari.TabIndex = 0;
            this.btn_veriOranlari.Text = "Veri Oranları";
            this.btn_veriOranlari.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_veriOranlari.UseVisualStyleBackColor = false;
            this.btn_veriOranlari.Click += new System.EventHandler(this.Btn_dataRates_Click);
            // 
            // btn_geceModu
            // 
            this.btn_geceModu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_geceModu.BackColor = System.Drawing.Color.Transparent;
            this.btn_geceModu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_geceModu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_geceModu.FlatAppearance.BorderSize = 0;
            this.btn_geceModu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btn_geceModu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btn_geceModu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geceModu.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geceModu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_geceModu.Image = global::SAISKabini.Properties.Resources.black_and_white_white;
            this.btn_geceModu.Location = new System.Drawing.Point(8, 661);
            this.btn_geceModu.Name = "btn_geceModu";
            this.btn_geceModu.Size = new System.Drawing.Size(75, 75);
            this.btn_geceModu.TabIndex = 0;
            this.btn_geceModu.Text = "Gece  Modu";
            this.btn_geceModu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_geceModu.UseVisualStyleBackColor = false;
            this.btn_geceModu.Click += new System.EventHandler(this.Btn_geceModu_Click);
            // 
            // btn_simulasyon
            // 
            this.btn_simulasyon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_simulasyon.BackColor = System.Drawing.Color.Transparent;
            this.btn_simulasyon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_simulasyon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_simulasyon.FlatAppearance.BorderSize = 0;
            this.btn_simulasyon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btn_simulasyon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btn_simulasyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simulasyon.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_simulasyon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_simulasyon.Image = global::SAISKabini.Properties.Resources.monitoring_white;
            this.btn_simulasyon.Location = new System.Drawing.Point(8, 160);
            this.btn_simulasyon.Name = "btn_simulasyon";
            this.btn_simulasyon.Size = new System.Drawing.Size(75, 71);
            this.btn_simulasyon.TabIndex = 0;
            this.btn_simulasyon.Text = "Simülasyon";
            this.btn_simulasyon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_simulasyon.UseVisualStyleBackColor = false;
            this.btn_simulasyon.Click += new System.EventHandler(this.Btn_simulation_Click);
            // 
            // btn_kayitlar
            // 
            this.btn_kayitlar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_kayitlar.BackColor = System.Drawing.Color.Transparent;
            this.btn_kayitlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_kayitlar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_kayitlar.FlatAppearance.BorderSize = 0;
            this.btn_kayitlar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btn_kayitlar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btn_kayitlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayitlar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitlar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_kayitlar.Image = global::SAISKabini.Properties.Resources.log_white;
            this.btn_kayitlar.Location = new System.Drawing.Point(8, 545);
            this.btn_kayitlar.Name = "btn_kayitlar";
            this.btn_kayitlar.Size = new System.Drawing.Size(75, 71);
            this.btn_kayitlar.TabIndex = 0;
            this.btn_kayitlar.Text = "Kayıtlar";
            this.btn_kayitlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kayitlar.UseVisualStyleBackColor = false;
            this.btn_kayitlar.Click += new System.EventHandler(this.Btn_logs_Click);
            // 
            // btn_kalibrasyon
            // 
            this.btn_kalibrasyon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_kalibrasyon.BackColor = System.Drawing.Color.Transparent;
            this.btn_kalibrasyon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_kalibrasyon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_kalibrasyon.FlatAppearance.BorderSize = 0;
            this.btn_kalibrasyon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btn_kalibrasyon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btn_kalibrasyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kalibrasyon.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kalibrasyon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_kalibrasyon.Image = global::SAISKabini.Properties.Resources.calib_24px;
            this.btn_kalibrasyon.Location = new System.Drawing.Point(8, 237);
            this.btn_kalibrasyon.Name = "btn_kalibrasyon";
            this.btn_kalibrasyon.Size = new System.Drawing.Size(75, 71);
            this.btn_kalibrasyon.TabIndex = 0;
            this.btn_kalibrasyon.Text = "Kalibrasyon";
            this.btn_kalibrasyon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kalibrasyon.UseVisualStyleBackColor = false;
            this.btn_kalibrasyon.Click += new System.EventHandler(this.Btn_calibration_Click);
            // 
            // btn_ayarlar
            // 
            this.btn_ayarlar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ayarlar.BackColor = System.Drawing.Color.Transparent;
            this.btn_ayarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ayarlar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ayarlar.FlatAppearance.BorderSize = 0;
            this.btn_ayarlar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btn_ayarlar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btn_ayarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayarlar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ayarlar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ayarlar.Image = global::SAISKabini.Properties.Resources.settings_white;
            this.btn_ayarlar.Location = new System.Drawing.Point(8, 468);
            this.btn_ayarlar.Name = "btn_ayarlar";
            this.btn_ayarlar.Size = new System.Drawing.Size(75, 71);
            this.btn_ayarlar.TabIndex = 0;
            this.btn_ayarlar.Text = "Ayarlar";
            this.btn_ayarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ayarlar.UseVisualStyleBackColor = false;
            this.btn_ayarlar.Click += new System.EventHandler(this.Btn_settings_Click);
            // 
            // btn_mailAyarlari
            // 
            this.btn_mailAyarlari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mailAyarlari.BackColor = System.Drawing.Color.Transparent;
            this.btn_mailAyarlari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_mailAyarlari.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_mailAyarlari.FlatAppearance.BorderSize = 0;
            this.btn_mailAyarlari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btn_mailAyarlari.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btn_mailAyarlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mailAyarlari.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mailAyarlari.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_mailAyarlari.Image = global::SAISKabini.Properties.Resources.notifications_white;
            this.btn_mailAyarlari.Location = new System.Drawing.Point(8, 314);
            this.btn_mailAyarlari.Name = "btn_mailAyarlari";
            this.btn_mailAyarlari.Size = new System.Drawing.Size(75, 71);
            this.btn_mailAyarlari.TabIndex = 0;
            this.btn_mailAyarlari.Text = "Mail Ayarları";
            this.btn_mailAyarlari.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_mailAyarlari.UseVisualStyleBackColor = false;
            this.btn_mailAyarlari.Click += new System.EventHandler(this.Btn_mailSettings_Click);
            // 
            // btn_raporlama
            // 
            this.btn_raporlama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_raporlama.BackColor = System.Drawing.Color.Transparent;
            this.btn_raporlama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_raporlama.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_raporlama.FlatAppearance.BorderSize = 0;
            this.btn_raporlama.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btn_raporlama.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btn_raporlama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raporlama.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_raporlama.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_raporlama.Image = global::SAISKabini.Properties.Resources.reporting_white;
            this.btn_raporlama.Location = new System.Drawing.Point(8, 391);
            this.btn_raporlama.Name = "btn_raporlama";
            this.btn_raporlama.Size = new System.Drawing.Size(75, 71);
            this.btn_raporlama.TabIndex = 0;
            this.btn_raporlama.Text = "Raporlama";
            this.btn_raporlama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_raporlama.UseVisualStyleBackColor = false;
            this.btn_raporlama.Click += new System.EventHandler(this.Btn_reporting_Click);
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.SystemColors.Control;
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(90, 62);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(1410, 738);
            this.panel_content.TabIndex = 10;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.tableLayoutPanel_TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sais Kabini";
            this.tableLayoutPanel_TitleBar.ResumeLayout(false);
            this.tableLayoutPanel_TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TitleBar;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel_menuPicker;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_veriOranlari;
        private System.Windows.Forms.Button btn_geceModu;
        private System.Windows.Forms.Button btn_simulasyon;
        private System.Windows.Forms.Button btn_kayitlar;
        private System.Windows.Forms.Button btn_kalibrasyon;
        private System.Windows.Forms.Button btn_ayarlar;
        private System.Windows.Forms.Button btn_mailAyarlari;
        private System.Windows.Forms.Button btn_raporlama;
        private System.Windows.Forms.Panel panel_content;
    }
}

