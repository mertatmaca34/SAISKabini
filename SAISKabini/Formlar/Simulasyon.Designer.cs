namespace SAISKabini
{
    partial class Simulasyon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.timer_PlcConnect = new System.Windows.Forms.Timer(this.components);
            this.panel_simulasyon = new System.Windows.Forms.Panel();
            this.lbl_nemValue = new System.Windows.Forms.Label();
            this.lbl_sicaklikValue = new System.Windows.Forms.Label();
            this.lbl_aktifPompaValue = new System.Windows.Forms.Label();
            this.lbl_pompaHzValue = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_koiValue = new System.Windows.Forms.Label();
            this.lbl_akisHiziValue = new System.Windows.Forms.Label();
            this.lbl_akmValue = new System.Windows.Forms.Label();
            this.lbl_phValue = new System.Windows.Forms.Label();
            this.lbl_oksijenValue = new System.Windows.Forms.Label();
            this.lbl_iletkenlikValue = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pic_yikamaTanki = new System.Windows.Forms.PictureBox();
            this.pic_pompa2 = new System.Windows.Forms.PictureBox();
            this.pic_pompa1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayP_donenCevaplar = new System.Windows.Forms.TableLayoutPanel();
            this.label101 = new System.Windows.Forms.Label();
            this.lbl_istasyonAdi = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.lbl_simId = new System.Windows.Forms.Label();
            this.lbl_istasyonIp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tblLayP_kabinDurumu = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_nem = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.lbl_pompaDurum = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.lbl_sicaklik = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tblLayP_yikamaBilgileri = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_birSonrakiHaftalikYikama = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.lbl_sonGunlukYikama = new System.Windows.Forms.Label();
            this.lbl_birSonrakiGunlukYikama = new System.Windows.Forms.Label();
            this.lbl_sonHaftalikYikama = new System.Windows.Forms.Label();
            this.panel_simulasyon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_yikamaTanki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pompa2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pompa1)).BeginInit();
            this.tableLayoutPanel27.SuspendLayout();
            this.tblLayP_donenCevaplar.SuspendLayout();
            this.tblLayP_kabinDurumu.SuspendLayout();
            this.tblLayP_yikamaBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker2_DoWork);
            // 
            // timer_PlcConnect
            // 
            this.timer_PlcConnect.Enabled = true;
            this.timer_PlcConnect.Interval = 5000;
            this.timer_PlcConnect.Tick += new System.EventHandler(this.timer_PlcConnect_Tick);
            // 
            // panel_simulasyon
            // 
            this.panel_simulasyon.BackColor = System.Drawing.Color.Transparent;
            this.panel_simulasyon.BackgroundImage = global::SAISKabini.Properties.Resources.panel_bakanlikkabini_bos1;
            this.panel_simulasyon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_simulasyon.Controls.Add(this.lbl_nemValue);
            this.panel_simulasyon.Controls.Add(this.lbl_sicaklikValue);
            this.panel_simulasyon.Controls.Add(this.lbl_aktifPompaValue);
            this.panel_simulasyon.Controls.Add(this.lbl_pompaHzValue);
            this.panel_simulasyon.Controls.Add(this.label22);
            this.panel_simulasyon.Controls.Add(this.label20);
            this.panel_simulasyon.Controls.Add(this.label18);
            this.panel_simulasyon.Controls.Add(this.lbl_koiValue);
            this.panel_simulasyon.Controls.Add(this.lbl_akisHiziValue);
            this.panel_simulasyon.Controls.Add(this.lbl_akmValue);
            this.panel_simulasyon.Controls.Add(this.lbl_phValue);
            this.panel_simulasyon.Controls.Add(this.lbl_oksijenValue);
            this.panel_simulasyon.Controls.Add(this.lbl_iletkenlikValue);
            this.panel_simulasyon.Controls.Add(this.label34);
            this.panel_simulasyon.Controls.Add(this.label32);
            this.panel_simulasyon.Controls.Add(this.label30);
            this.panel_simulasyon.Controls.Add(this.label28);
            this.panel_simulasyon.Controls.Add(this.label26);
            this.panel_simulasyon.Controls.Add(this.label24);
            this.panel_simulasyon.Controls.Add(this.label10);
            this.panel_simulasyon.Controls.Add(this.pic_yikamaTanki);
            this.panel_simulasyon.Controls.Add(this.pic_pompa2);
            this.panel_simulasyon.Controls.Add(this.pic_pompa1);
            this.panel_simulasyon.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_simulasyon.Location = new System.Drawing.Point(0, 0);
            this.panel_simulasyon.Name = "panel_simulasyon";
            this.panel_simulasyon.Size = new System.Drawing.Size(1066, 738);
            this.panel_simulasyon.TabIndex = 2;
            // 
            // lbl_nemValue
            // 
            this.lbl_nemValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_nemValue.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_nemValue.Location = new System.Drawing.Point(155, 257);
            this.lbl_nemValue.Name = "lbl_nemValue";
            this.lbl_nemValue.Size = new System.Drawing.Size(83, 22);
            this.lbl_nemValue.TabIndex = 2;
            this.lbl_nemValue.Text = "%0";
            this.lbl_nemValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sicaklikValue
            // 
            this.lbl_sicaklikValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_sicaklikValue.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_sicaklikValue.Location = new System.Drawing.Point(156, 204);
            this.lbl_sicaklikValue.Name = "lbl_sicaklikValue";
            this.lbl_sicaklikValue.Size = new System.Drawing.Size(83, 22);
            this.lbl_sicaklikValue.TabIndex = 2;
            this.lbl_sicaklikValue.Text = "0°C";
            this.lbl_sicaklikValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_aktifPompaValue
            // 
            this.lbl_aktifPompaValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_aktifPompaValue.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_aktifPompaValue.Location = new System.Drawing.Point(156, 135);
            this.lbl_aktifPompaValue.Name = "lbl_aktifPompaValue";
            this.lbl_aktifPompaValue.Size = new System.Drawing.Size(83, 22);
            this.lbl_aktifPompaValue.TabIndex = 2;
            this.lbl_aktifPompaValue.Text = "Yok";
            this.lbl_aktifPompaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pompaHzValue
            // 
            this.lbl_pompaHzValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_pompaHzValue.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_pompaHzValue.Location = new System.Drawing.Point(156, 82);
            this.lbl_pompaHzValue.Name = "lbl_pompaHzValue";
            this.lbl_pompaHzValue.Size = new System.Drawing.Size(83, 22);
            this.lbl_pompaHzValue.TabIndex = 2;
            this.lbl_pompaHzValue.Text = "0 hz";
            this.lbl_pompaHzValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(155, 233);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 22);
            this.label22.TabIndex = 2;
            this.label22.Text = "NEM";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(156, 180);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 22);
            this.label20.TabIndex = 2;
            this.label20.Text = "SICAKLIK";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(156, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 22);
            this.label18.TabIndex = 2;
            this.label18.Text = "AKTİF";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_koiValue
            // 
            this.lbl_koiValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_koiValue.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_koiValue.Location = new System.Drawing.Point(933, 210);
            this.lbl_koiValue.Name = "lbl_koiValue";
            this.lbl_koiValue.Size = new System.Drawing.Size(76, 20);
            this.lbl_koiValue.TabIndex = 2;
            this.lbl_koiValue.Text = "0";
            this.lbl_koiValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_akisHiziValue
            // 
            this.lbl_akisHiziValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_akisHiziValue.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_akisHiziValue.Location = new System.Drawing.Point(480, 488);
            this.lbl_akisHiziValue.Name = "lbl_akisHiziValue";
            this.lbl_akisHiziValue.Size = new System.Drawing.Size(76, 20);
            this.lbl_akisHiziValue.TabIndex = 2;
            this.lbl_akisHiziValue.Text = "0";
            this.lbl_akisHiziValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_akmValue
            // 
            this.lbl_akmValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_akmValue.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_akmValue.Location = new System.Drawing.Point(933, 152);
            this.lbl_akmValue.Name = "lbl_akmValue";
            this.lbl_akmValue.Size = new System.Drawing.Size(76, 20);
            this.lbl_akmValue.TabIndex = 2;
            this.lbl_akmValue.Text = "0";
            this.lbl_akmValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_phValue
            // 
            this.lbl_phValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_phValue.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_phValue.Location = new System.Drawing.Point(720, 281);
            this.lbl_phValue.Name = "lbl_phValue";
            this.lbl_phValue.Size = new System.Drawing.Size(76, 20);
            this.lbl_phValue.TabIndex = 2;
            this.lbl_phValue.Text = "0";
            this.lbl_phValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_oksijenValue
            // 
            this.lbl_oksijenValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_oksijenValue.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_oksijenValue.Location = new System.Drawing.Point(618, 236);
            this.lbl_oksijenValue.Name = "lbl_oksijenValue";
            this.lbl_oksijenValue.Size = new System.Drawing.Size(76, 20);
            this.lbl_oksijenValue.TabIndex = 2;
            this.lbl_oksijenValue.Text = "0 mg";
            this.lbl_oksijenValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_iletkenlikValue
            // 
            this.lbl_iletkenlikValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_iletkenlikValue.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_iletkenlikValue.Location = new System.Drawing.Point(635, 156);
            this.lbl_iletkenlikValue.Name = "lbl_iletkenlikValue";
            this.lbl_iletkenlikValue.Size = new System.Drawing.Size(76, 20);
            this.lbl_iletkenlikValue.TabIndex = 2;
            this.lbl_iletkenlikValue.Text = "0 mS/cm";
            this.lbl_iletkenlikValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.Location = new System.Drawing.Point(933, 188);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(76, 20);
            this.label34.TabIndex = 2;
            this.label34.Text = "KOi";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.Location = new System.Drawing.Point(480, 466);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(76, 20);
            this.label32.TabIndex = 2;
            this.label32.Text = "AKIŞ HIZI";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.Location = new System.Drawing.Point(933, 130);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(76, 20);
            this.label30.TabIndex = 2;
            this.label30.Text = "AKM";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(720, 259);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(76, 20);
            this.label28.TabIndex = 2;
            this.label28.Text = "pH";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(618, 214);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 20);
            this.label26.TabIndex = 2;
            this.label26.Text = "OKSİJEN";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(635, 134);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 20);
            this.label24.TabIndex = 2;
            this.label24.Text = "İLETKENLİK";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(156, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "POMPA HZ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_yikamaTanki
            // 
            this.pic_yikamaTanki.BackgroundImage = global::SAISKabini.Properties.Resources.tank_bos;
            this.pic_yikamaTanki.Location = new System.Drawing.Point(896, 364);
            this.pic_yikamaTanki.Name = "pic_yikamaTanki";
            this.pic_yikamaTanki.Size = new System.Drawing.Size(91, 239);
            this.pic_yikamaTanki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_yikamaTanki.TabIndex = 1;
            this.pic_yikamaTanki.TabStop = false;
            // 
            // pic_pompa2
            // 
            this.pic_pompa2.Image = global::SAISKabini.Properties.Resources.pump2_idle;
            this.pic_pompa2.Location = new System.Drawing.Point(553, 539);
            this.pic_pompa2.Name = "pic_pompa2";
            this.pic_pompa2.Size = new System.Drawing.Size(75, 81);
            this.pic_pompa2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_pompa2.TabIndex = 1;
            this.pic_pompa2.TabStop = false;
            // 
            // pic_pompa1
            // 
            this.pic_pompa1.Image = global::SAISKabini.Properties.Resources.pump1_idle1;
            this.pic_pompa1.Location = new System.Drawing.Point(408, 539);
            this.pic_pompa1.Name = "pic_pompa1";
            this.pic_pompa1.Size = new System.Drawing.Size(75, 81);
            this.pic_pompa1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_pompa1.TabIndex = 1;
            this.pic_pompa1.TabStop = false;
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.tableLayoutPanel27.ColumnCount = 1;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.Controls.Add(this.tblLayP_donenCevaplar, 0, 0);
            this.tableLayoutPanel27.Controls.Add(this.tblLayP_kabinDurumu, 0, 1);
            this.tableLayoutPanel27.Controls.Add(this.tblLayP_yikamaBilgileri, 0, 2);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(1066, 0);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 3;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.31436F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.30081F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.52032F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(344, 738);
            this.tableLayoutPanel27.TabIndex = 3;
            // 
            // tblLayP_donenCevaplar
            // 
            this.tblLayP_donenCevaplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblLayP_donenCevaplar.BackColor = System.Drawing.Color.White;
            this.tblLayP_donenCevaplar.ColumnCount = 1;
            this.tblLayP_donenCevaplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayP_donenCevaplar.Controls.Add(this.label101, 0, 0);
            this.tblLayP_donenCevaplar.Controls.Add(this.lbl_istasyonAdi, 0, 2);
            this.tblLayP_donenCevaplar.Controls.Add(this.label102, 0, 1);
            this.tblLayP_donenCevaplar.Controls.Add(this.label106, 0, 5);
            this.tblLayP_donenCevaplar.Controls.Add(this.lbl_simId, 0, 6);
            this.tblLayP_donenCevaplar.Controls.Add(this.lbl_istasyonIp, 0, 4);
            this.tblLayP_donenCevaplar.Controls.Add(this.label8, 0, 3);
            this.tblLayP_donenCevaplar.Controls.Add(this.label1, 0, 7);
            this.tblLayP_donenCevaplar.Controls.Add(this.label2, 0, 8);
            this.tblLayP_donenCevaplar.Controls.Add(this.label3, 0, 9);
            this.tblLayP_donenCevaplar.Controls.Add(this.label4, 0, 10);
            this.tblLayP_donenCevaplar.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.tblLayP_donenCevaplar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblLayP_donenCevaplar.Location = new System.Drawing.Point(13, 14);
            this.tblLayP_donenCevaplar.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayP_donenCevaplar.Name = "tblLayP_donenCevaplar";
            this.tblLayP_donenCevaplar.Padding = new System.Windows.Forms.Padding(5);
            this.tblLayP_donenCevaplar.RowCount = 11;
            this.tblLayP_donenCevaplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayP_donenCevaplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_donenCevaplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_donenCevaplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_donenCevaplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_donenCevaplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_donenCevaplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_donenCevaplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_donenCevaplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_donenCevaplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_donenCevaplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_donenCevaplar.Size = new System.Drawing.Size(317, 239);
            this.tblLayP_donenCevaplar.TabIndex = 1;
            this.tblLayP_donenCevaplar.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tblLayP_donenCevaplar_CellPaint);
            // 
            // label101
            // 
            this.label101.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label101.AutoSize = true;
            this.label101.BackColor = System.Drawing.Color.Transparent;
            this.label101.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label101.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label101.Location = new System.Drawing.Point(41, 15);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(234, 19);
            this.label101.TabIndex = 6;
            this.label101.Text = "BAKANLIKTAN DÖNEN CEVAPLAR";
            // 
            // lbl_istasyonAdi
            // 
            this.lbl_istasyonAdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_istasyonAdi.AutoSize = true;
            this.lbl_istasyonAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_istasyonAdi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_istasyonAdi.Location = new System.Drawing.Point(152, 58);
            this.lbl_istasyonAdi.Name = "lbl_istasyonAdi";
            this.lbl_istasyonAdi.Size = new System.Drawing.Size(13, 18);
            this.lbl_istasyonAdi.TabIndex = 5;
            this.lbl_istasyonAdi.Text = "-";
            // 
            // label102
            // 
            this.label102.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label102.AutoSize = true;
            this.label102.BackColor = System.Drawing.Color.Transparent;
            this.label102.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label102.Location = new System.Drawing.Point(130, 44);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(57, 13);
            this.label102.TabIndex = 3;
            this.label102.Text = "Veri Sağlığı";
            // 
            // label106
            // 
            this.label106.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label106.AutoSize = true;
            this.label106.BackColor = System.Drawing.Color.Transparent;
            this.label106.Location = new System.Drawing.Point(120, 120);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(76, 13);
            this.label106.TabIndex = 9;
            this.label106.Text = "Haftalık Yıkama";
            // 
            // lbl_simId
            // 
            this.lbl_simId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_simId.AutoSize = true;
            this.lbl_simId.BackColor = System.Drawing.Color.Transparent;
            this.lbl_simId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_simId.Location = new System.Drawing.Point(152, 134);
            this.lbl_simId.Name = "lbl_simId";
            this.lbl_simId.Size = new System.Drawing.Size(13, 18);
            this.lbl_simId.TabIndex = 8;
            this.lbl_simId.Text = "-";
            // 
            // lbl_istasyonIp
            // 
            this.lbl_istasyonIp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_istasyonIp.AutoSize = true;
            this.lbl_istasyonIp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_istasyonIp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_istasyonIp.Location = new System.Drawing.Point(152, 96);
            this.lbl_istasyonIp.Name = "lbl_istasyonIp";
            this.lbl_istasyonIp.Size = new System.Drawing.Size(13, 18);
            this.lbl_istasyonIp.TabIndex = 7;
            this.lbl_istasyonIp.Text = "-";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(121, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Günlük Yıkama";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(128, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kalibrasyon";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(152, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(136, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Akış Hızı";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(152, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "-";
            // 
            // tblLayP_kabinDurumu
            // 
            this.tblLayP_kabinDurumu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblLayP_kabinDurumu.BackColor = System.Drawing.Color.White;
            this.tblLayP_kabinDurumu.ColumnCount = 1;
            this.tblLayP_kabinDurumu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayP_kabinDurumu.Controls.Add(this.lbl_nem, 0, 6);
            this.tblLayP_kabinDurumu.Controls.Add(this.label121, 0, 0);
            this.tblLayP_kabinDurumu.Controls.Add(this.label108, 0, 1);
            this.tblLayP_kabinDurumu.Controls.Add(this.lbl_pompaDurum, 0, 2);
            this.tblLayP_kabinDurumu.Controls.Add(this.label110, 0, 3);
            this.tblLayP_kabinDurumu.Controls.Add(this.lbl_sicaklik, 0, 4);
            this.tblLayP_kabinDurumu.Controls.Add(this.label112, 0, 5);
            this.tblLayP_kabinDurumu.Controls.Add(this.label5, 0, 7);
            this.tblLayP_kabinDurumu.Controls.Add(this.label6, 0, 8);
            this.tblLayP_kabinDurumu.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.tblLayP_kabinDurumu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblLayP_kabinDurumu.Location = new System.Drawing.Point(13, 284);
            this.tblLayP_kabinDurumu.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayP_kabinDurumu.Name = "tblLayP_kabinDurumu";
            this.tblLayP_kabinDurumu.Padding = new System.Windows.Forms.Padding(5);
            this.tblLayP_kabinDurumu.RowCount = 9;
            this.tblLayP_kabinDurumu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayP_kabinDurumu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_kabinDurumu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_kabinDurumu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_kabinDurumu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_kabinDurumu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_kabinDurumu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_kabinDurumu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_kabinDurumu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_kabinDurumu.Size = new System.Drawing.Size(317, 195);
            this.tblLayP_kabinDurumu.TabIndex = 1;
            this.tblLayP_kabinDurumu.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tblLayP_kabinDurumu_CellPaint);
            // 
            // lbl_nem
            // 
            this.lbl_nem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_nem.AutoSize = true;
            this.lbl_nem.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_nem.Location = new System.Drawing.Point(152, 128);
            this.lbl_nem.Name = "lbl_nem";
            this.lbl_nem.Size = new System.Drawing.Size(13, 18);
            this.lbl_nem.TabIndex = 8;
            this.lbl_nem.Text = "-";
            // 
            // label121
            // 
            this.label121.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label121.AutoSize = true;
            this.label121.BackColor = System.Drawing.Color.Transparent;
            this.label121.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label121.Location = new System.Drawing.Point(99, 12);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(119, 19);
            this.label121.TabIndex = 1;
            this.label121.Text = "KABİN DURUMU";
            // 
            // label108
            // 
            this.label108.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label108.AutoSize = true;
            this.label108.BackColor = System.Drawing.Color.Transparent;
            this.label108.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label108.Location = new System.Drawing.Point(138, 38);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(40, 13);
            this.label108.TabIndex = 2;
            this.label108.Text = "Duman";
            // 
            // lbl_pompaDurum
            // 
            this.lbl_pompaDurum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pompaDurum.AutoSize = true;
            this.lbl_pompaDurum.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pompaDurum.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_pompaDurum.Location = new System.Drawing.Point(152, 52);
            this.lbl_pompaDurum.Name = "lbl_pompaDurum";
            this.lbl_pompaDurum.Size = new System.Drawing.Size(13, 18);
            this.lbl_pompaDurum.TabIndex = 4;
            this.lbl_pompaDurum.Text = "-";
            // 
            // label110
            // 
            this.label110.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label110.AutoSize = true;
            this.label110.BackColor = System.Drawing.Color.Transparent;
            this.label110.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label110.Location = new System.Drawing.Point(132, 76);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(52, 13);
            this.label110.TabIndex = 5;
            this.label110.Text = "Su Baskını";
            // 
            // lbl_sicaklik
            // 
            this.lbl_sicaklik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_sicaklik.AutoSize = true;
            this.lbl_sicaklik.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sicaklik.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_sicaklik.Location = new System.Drawing.Point(152, 90);
            this.lbl_sicaklik.Name = "lbl_sicaklik";
            this.lbl_sicaklik.Size = new System.Drawing.Size(13, 18);
            this.lbl_sicaklik.TabIndex = 6;
            this.lbl_sicaklik.Text = "-";
            // 
            // label112
            // 
            this.label112.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label112.AutoSize = true;
            this.label112.BackColor = System.Drawing.Color.Transparent;
            this.label112.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label112.Location = new System.Drawing.Point(134, 114);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(48, 13);
            this.label112.TabIndex = 7;
            this.label112.Text = "Acil Stop";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label5.Location = new System.Drawing.Point(141, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enerji";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(152, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "-";
            // 
            // tblLayP_yikamaBilgileri
            // 
            this.tblLayP_yikamaBilgileri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblLayP_yikamaBilgileri.BackColor = System.Drawing.Color.White;
            this.tblLayP_yikamaBilgileri.ColumnCount = 1;
            this.tblLayP_yikamaBilgileri.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayP_yikamaBilgileri.Controls.Add(this.lbl_birSonrakiHaftalikYikama, 0, 8);
            this.tblLayP_yikamaBilgileri.Controls.Add(this.label114, 0, 0);
            this.tblLayP_yikamaBilgileri.Controls.Add(this.label115, 0, 1);
            this.tblLayP_yikamaBilgileri.Controls.Add(this.label117, 0, 3);
            this.tblLayP_yikamaBilgileri.Controls.Add(this.label119, 0, 5);
            this.tblLayP_yikamaBilgileri.Controls.Add(this.label120, 0, 7);
            this.tblLayP_yikamaBilgileri.Controls.Add(this.lbl_sonGunlukYikama, 0, 2);
            this.tblLayP_yikamaBilgileri.Controls.Add(this.lbl_birSonrakiGunlukYikama, 0, 4);
            this.tblLayP_yikamaBilgileri.Controls.Add(this.lbl_sonHaftalikYikama, 0, 6);
            this.tblLayP_yikamaBilgileri.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.tblLayP_yikamaBilgileri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblLayP_yikamaBilgileri.Location = new System.Drawing.Point(13, 517);
            this.tblLayP_yikamaBilgileri.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayP_yikamaBilgileri.Name = "tblLayP_yikamaBilgileri";
            this.tblLayP_yikamaBilgileri.Padding = new System.Windows.Forms.Padding(5);
            this.tblLayP_yikamaBilgileri.RowCount = 9;
            this.tblLayP_yikamaBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayP_yikamaBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_yikamaBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_yikamaBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_yikamaBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_yikamaBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_yikamaBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_yikamaBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_yikamaBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_yikamaBilgileri.Size = new System.Drawing.Size(317, 201);
            this.tblLayP_yikamaBilgileri.TabIndex = 1;
            this.tblLayP_yikamaBilgileri.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tblLayP_yikamaBilgileri_CellPaint);
            // 
            // lbl_birSonrakiHaftalikYikama
            // 
            this.lbl_birSonrakiHaftalikYikama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_birSonrakiHaftalikYikama.AutoSize = true;
            this.lbl_birSonrakiHaftalikYikama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_birSonrakiHaftalikYikama.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_birSonrakiHaftalikYikama.Location = new System.Drawing.Point(152, 172);
            this.lbl_birSonrakiHaftalikYikama.Name = "lbl_birSonrakiHaftalikYikama";
            this.lbl_birSonrakiHaftalikYikama.Size = new System.Drawing.Size(13, 18);
            this.lbl_birSonrakiHaftalikYikama.TabIndex = 9;
            this.lbl_birSonrakiHaftalikYikama.Text = "-";
            // 
            // label114
            // 
            this.label114.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label114.AutoSize = true;
            this.label114.BackColor = System.Drawing.Color.Transparent;
            this.label114.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label114.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label114.Location = new System.Drawing.Point(73, 15);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(170, 19);
            this.label114.TabIndex = 1;
            this.label114.Text = "KALİBRASYON BİLGİLERİ";
            // 
            // label115
            // 
            this.label115.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label115.AutoSize = true;
            this.label115.BackColor = System.Drawing.Color.Transparent;
            this.label115.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label115.Location = new System.Drawing.Point(143, 44);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(30, 13);
            this.label115.TabIndex = 2;
            this.label115.Text = "AKM";
            // 
            // label117
            // 
            this.label117.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label117.AutoSize = true;
            this.label117.BackColor = System.Drawing.Color.Transparent;
            this.label117.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label117.Location = new System.Drawing.Point(147, 82);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(23, 13);
            this.label117.TabIndex = 3;
            this.label117.Text = "KOi";
            // 
            // label119
            // 
            this.label119.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label119.AutoSize = true;
            this.label119.BackColor = System.Drawing.Color.Transparent;
            this.label119.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label119.Location = new System.Drawing.Point(133, 120);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(51, 13);
            this.label119.TabIndex = 4;
            this.label119.Text = "İletkenlik";
            // 
            // label120
            // 
            this.label120.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label120.AutoSize = true;
            this.label120.BackColor = System.Drawing.Color.Transparent;
            this.label120.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label120.Location = new System.Drawing.Point(148, 158);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(20, 13);
            this.label120.TabIndex = 5;
            this.label120.Text = "pH";
            // 
            // lbl_sonGunlukYikama
            // 
            this.lbl_sonGunlukYikama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_sonGunlukYikama.AutoSize = true;
            this.lbl_sonGunlukYikama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sonGunlukYikama.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_sonGunlukYikama.Location = new System.Drawing.Point(152, 58);
            this.lbl_sonGunlukYikama.Name = "lbl_sonGunlukYikama";
            this.lbl_sonGunlukYikama.Size = new System.Drawing.Size(13, 18);
            this.lbl_sonGunlukYikama.TabIndex = 6;
            this.lbl_sonGunlukYikama.Text = "-";
            // 
            // lbl_birSonrakiGunlukYikama
            // 
            this.lbl_birSonrakiGunlukYikama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_birSonrakiGunlukYikama.AutoSize = true;
            this.lbl_birSonrakiGunlukYikama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_birSonrakiGunlukYikama.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_birSonrakiGunlukYikama.Location = new System.Drawing.Point(152, 96);
            this.lbl_birSonrakiGunlukYikama.Name = "lbl_birSonrakiGunlukYikama";
            this.lbl_birSonrakiGunlukYikama.Size = new System.Drawing.Size(13, 18);
            this.lbl_birSonrakiGunlukYikama.TabIndex = 7;
            this.lbl_birSonrakiGunlukYikama.Text = "-";
            // 
            // lbl_sonHaftalikYikama
            // 
            this.lbl_sonHaftalikYikama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_sonHaftalikYikama.AutoSize = true;
            this.lbl_sonHaftalikYikama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sonHaftalikYikama.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_sonHaftalikYikama.Location = new System.Drawing.Point(152, 134);
            this.lbl_sonHaftalikYikama.Name = "lbl_sonHaftalikYikama";
            this.lbl_sonHaftalikYikama.Size = new System.Drawing.Size(13, 18);
            this.lbl_sonHaftalikYikama.TabIndex = 8;
            this.lbl_sonHaftalikYikama.Text = "-";
            // 
            // Simulasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 738);
            this.Controls.Add(this.tableLayoutPanel27);
            this.Controls.Add(this.panel_simulasyon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Simulasyon";
            this.Text = "Simulasyon";
            this.panel_simulasyon.ResumeLayout(false);
            this.panel_simulasyon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_yikamaTanki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pompa2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pompa1)).EndInit();
            this.tableLayoutPanel27.ResumeLayout(false);
            this.tblLayP_donenCevaplar.ResumeLayout(false);
            this.tblLayP_donenCevaplar.PerformLayout();
            this.tblLayP_kabinDurumu.ResumeLayout(false);
            this.tblLayP_kabinDurumu.PerformLayout();
            this.tblLayP_yikamaBilgileri.ResumeLayout(false);
            this.tblLayP_yikamaBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_simulasyon;
        private System.Windows.Forms.PictureBox pic_pompa1;
        private System.Windows.Forms.PictureBox pic_yikamaTanki;
        private System.Windows.Forms.PictureBox pic_pompa2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_nemValue;
        private System.Windows.Forms.Label lbl_sicaklikValue;
        private System.Windows.Forms.Label lbl_aktifPompaValue;
        private System.Windows.Forms.Label lbl_pompaHzValue;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_akisHiziValue;
        private System.Windows.Forms.Label lbl_akmValue;
        private System.Windows.Forms.Label lbl_phValue;
        private System.Windows.Forms.Label lbl_oksijenValue;
        private System.Windows.Forms.Label lbl_iletkenlikValue;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbl_koiValue;
        private System.Windows.Forms.Label label34;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Timer timer_PlcConnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.TableLayoutPanel tblLayP_donenCevaplar;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label lbl_istasyonAdi;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label106;
        public System.Windows.Forms.Label lbl_simId;
        protected System.Windows.Forms.Label lbl_istasyonIp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tblLayP_kabinDurumu;
        private System.Windows.Forms.Label lbl_nem;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label lbl_pompaDurum;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label lbl_sicaklik;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.TableLayoutPanel tblLayP_yikamaBilgileri;
        private System.Windows.Forms.Label lbl_birSonrakiHaftalikYikama;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label lbl_sonGunlukYikama;
        private System.Windows.Forms.Label lbl_birSonrakiGunlukYikama;
        private System.Windows.Forms.Label lbl_sonHaftalikYikama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}