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
            this.lbl_LastQuery = new System.Windows.Forms.Label();
            this.tblLayP_donenCevaplar = new System.Windows.Forms.TableLayoutPanel();
            this.label101 = new System.Windows.Forms.Label();
            this.lbl_CevapVeriSagligi = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.lbl_CevapHaftalikYikama = new System.Windows.Forms.Label();
            this.lbl_CevapGunlukYikama = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CevapKalibrasyon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_CevapAkisHizi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_CevapTekrarVeri = new System.Windows.Forms.Label();
            this.tblLayP_kabinDurumu = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_AcilStop = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.lbl_Duman = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.lbl_SuBaskini = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Enerji = new System.Windows.Forms.Label();
            this.tblLayP_kalibrasyonBilgileri = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_pH = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.lbl_AKM = new System.Windows.Forms.Label();
            this.lbl_KOi = new System.Windows.Forms.Label();
            this.lbl_Iletkenlik = new System.Windows.Forms.Label();
            this.Timer_SendData = new System.Windows.Forms.Timer(this.components);
            this.panel_simulasyon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_yikamaTanki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pompa2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pompa1)).BeginInit();
            this.tableLayoutPanel27.SuspendLayout();
            this.tblLayP_donenCevaplar.SuspendLayout();
            this.tblLayP_kabinDurumu.SuspendLayout();
            this.tblLayP_kalibrasyonBilgileri.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel27.Controls.Add(this.lbl_LastQuery, 0, 3);
            this.tableLayoutPanel27.Controls.Add(this.tblLayP_donenCevaplar, 0, 0);
            this.tableLayoutPanel27.Controls.Add(this.tblLayP_kabinDurumu, 0, 1);
            this.tableLayoutPanel27.Controls.Add(this.tblLayP_kalibrasyonBilgileri, 0, 2);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(1066, 0);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 4;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.86824F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.49137F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.64038F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(344, 738);
            this.tableLayoutPanel27.TabIndex = 3;
            // 
            // lbl_LastQuery
            // 
            this.lbl_LastQuery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_LastQuery.AutoSize = true;
            this.lbl_LastQuery.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LastQuery.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_LastQuery.Location = new System.Drawing.Point(63, 716);
            this.lbl_LastQuery.Name = "lbl_LastQuery";
            this.lbl_LastQuery.Size = new System.Drawing.Size(217, 18);
            this.lbl_LastQuery.TabIndex = 9;
            this.lbl_LastQuery.Text = "Son Sorgu: Henüz Sorgu Yapılmadı";
            // 
            // tblLayP_donenCevaplar
            // 
            this.tblLayP_donenCevaplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblLayP_donenCevaplar.BackColor = System.Drawing.Color.White;
            this.tblLayP_donenCevaplar.ColumnCount = 1;
            this.tblLayP_donenCevaplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayP_donenCevaplar.Controls.Add(this.label101, 0, 0);
            this.tblLayP_donenCevaplar.Controls.Add(this.lbl_CevapVeriSagligi, 0, 2);
            this.tblLayP_donenCevaplar.Controls.Add(this.label102, 0, 1);
            this.tblLayP_donenCevaplar.Controls.Add(this.label106, 0, 5);
            this.tblLayP_donenCevaplar.Controls.Add(this.lbl_CevapHaftalikYikama, 0, 6);
            this.tblLayP_donenCevaplar.Controls.Add(this.lbl_CevapGunlukYikama, 0, 4);
            this.tblLayP_donenCevaplar.Controls.Add(this.label8, 0, 3);
            this.tblLayP_donenCevaplar.Controls.Add(this.label1, 0, 7);
            this.tblLayP_donenCevaplar.Controls.Add(this.lbl_CevapKalibrasyon, 0, 8);
            this.tblLayP_donenCevaplar.Controls.Add(this.label3, 0, 9);
            this.tblLayP_donenCevaplar.Controls.Add(this.lbl_CevapAkisHizi, 0, 10);
            this.tblLayP_donenCevaplar.Controls.Add(this.label7, 0, 11);
            this.tblLayP_donenCevaplar.Controls.Add(this.lbl_CevapTekrarVeri, 0, 12);
            this.tblLayP_donenCevaplar.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.tblLayP_donenCevaplar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblLayP_donenCevaplar.Location = new System.Drawing.Point(13, 10);
            this.tblLayP_donenCevaplar.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayP_donenCevaplar.Name = "tblLayP_donenCevaplar";
            this.tblLayP_donenCevaplar.Padding = new System.Windows.Forms.Padding(5);
            this.tblLayP_donenCevaplar.RowCount = 13;
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
            this.tblLayP_donenCevaplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_donenCevaplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_donenCevaplar.Size = new System.Drawing.Size(317, 266);
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
            this.label101.Location = new System.Drawing.Point(41, 9);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(234, 19);
            this.label101.TabIndex = 6;
            this.label101.Text = "BAKANLIKTAN DÖNEN CEVAPLAR";
            // 
            // lbl_CevapVeriSagligi
            // 
            this.lbl_CevapVeriSagligi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CevapVeriSagligi.AutoSize = true;
            this.lbl_CevapVeriSagligi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CevapVeriSagligi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CevapVeriSagligi.Location = new System.Drawing.Point(152, 50);
            this.lbl_CevapVeriSagligi.Name = "lbl_CevapVeriSagligi";
            this.lbl_CevapVeriSagligi.Size = new System.Drawing.Size(13, 18);
            this.lbl_CevapVeriSagligi.TabIndex = 5;
            this.lbl_CevapVeriSagligi.Text = "-";
            // 
            // label102
            // 
            this.label102.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label102.AutoSize = true;
            this.label102.BackColor = System.Drawing.Color.Transparent;
            this.label102.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label102.Location = new System.Drawing.Point(130, 33);
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
            this.label106.Location = new System.Drawing.Point(120, 109);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(76, 13);
            this.label106.TabIndex = 9;
            this.label106.Text = "Haftalık Yıkama";
            // 
            // lbl_CevapHaftalikYikama
            // 
            this.lbl_CevapHaftalikYikama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CevapHaftalikYikama.AutoSize = true;
            this.lbl_CevapHaftalikYikama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CevapHaftalikYikama.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_CevapHaftalikYikama.Location = new System.Drawing.Point(152, 126);
            this.lbl_CevapHaftalikYikama.Name = "lbl_CevapHaftalikYikama";
            this.lbl_CevapHaftalikYikama.Size = new System.Drawing.Size(13, 18);
            this.lbl_CevapHaftalikYikama.TabIndex = 8;
            this.lbl_CevapHaftalikYikama.Text = "-";
            // 
            // lbl_CevapGunlukYikama
            // 
            this.lbl_CevapGunlukYikama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CevapGunlukYikama.AutoSize = true;
            this.lbl_CevapGunlukYikama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CevapGunlukYikama.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CevapGunlukYikama.Location = new System.Drawing.Point(152, 88);
            this.lbl_CevapGunlukYikama.Name = "lbl_CevapGunlukYikama";
            this.lbl_CevapGunlukYikama.Size = new System.Drawing.Size(13, 18);
            this.lbl_CevapGunlukYikama.TabIndex = 7;
            this.lbl_CevapGunlukYikama.Text = "-";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(121, 71);
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
            this.label1.Location = new System.Drawing.Point(128, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kalibrasyon";
            // 
            // lbl_CevapKalibrasyon
            // 
            this.lbl_CevapKalibrasyon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CevapKalibrasyon.AutoSize = true;
            this.lbl_CevapKalibrasyon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CevapKalibrasyon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_CevapKalibrasyon.Location = new System.Drawing.Point(152, 164);
            this.lbl_CevapKalibrasyon.Name = "lbl_CevapKalibrasyon";
            this.lbl_CevapKalibrasyon.Size = new System.Drawing.Size(13, 18);
            this.lbl_CevapKalibrasyon.TabIndex = 8;
            this.lbl_CevapKalibrasyon.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(136, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Akış Hızı";
            // 
            // lbl_CevapAkisHizi
            // 
            this.lbl_CevapAkisHizi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CevapAkisHizi.AutoSize = true;
            this.lbl_CevapAkisHizi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CevapAkisHizi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_CevapAkisHizi.Location = new System.Drawing.Point(152, 202);
            this.lbl_CevapAkisHizi.Name = "lbl_CevapAkisHizi";
            this.lbl_CevapAkisHizi.Size = new System.Drawing.Size(13, 18);
            this.lbl_CevapAkisHizi.TabIndex = 8;
            this.lbl_CevapAkisHizi.Text = "-";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(130, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tekrar Veri";
            // 
            // lbl_CevapTekrarVeri
            // 
            this.lbl_CevapTekrarVeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CevapTekrarVeri.AutoSize = true;
            this.lbl_CevapTekrarVeri.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CevapTekrarVeri.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_CevapTekrarVeri.Location = new System.Drawing.Point(152, 240);
            this.lbl_CevapTekrarVeri.Name = "lbl_CevapTekrarVeri";
            this.lbl_CevapTekrarVeri.Size = new System.Drawing.Size(13, 18);
            this.lbl_CevapTekrarVeri.TabIndex = 8;
            this.lbl_CevapTekrarVeri.Text = "-";
            // 
            // tblLayP_kabinDurumu
            // 
            this.tblLayP_kabinDurumu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblLayP_kabinDurumu.BackColor = System.Drawing.Color.White;
            this.tblLayP_kabinDurumu.ColumnCount = 1;
            this.tblLayP_kabinDurumu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayP_kabinDurumu.Controls.Add(this.lbl_AcilStop, 0, 6);
            this.tblLayP_kabinDurumu.Controls.Add(this.label121, 0, 0);
            this.tblLayP_kabinDurumu.Controls.Add(this.label108, 0, 1);
            this.tblLayP_kabinDurumu.Controls.Add(this.lbl_Duman, 0, 2);
            this.tblLayP_kabinDurumu.Controls.Add(this.label110, 0, 3);
            this.tblLayP_kabinDurumu.Controls.Add(this.lbl_SuBaskini, 0, 4);
            this.tblLayP_kabinDurumu.Controls.Add(this.label112, 0, 5);
            this.tblLayP_kabinDurumu.Controls.Add(this.label5, 0, 7);
            this.tblLayP_kabinDurumu.Controls.Add(this.lbl_Enerji, 0, 8);
            this.tblLayP_kabinDurumu.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.tblLayP_kabinDurumu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblLayP_kabinDurumu.Location = new System.Drawing.Point(13, 294);
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
            // lbl_AcilStop
            // 
            this.lbl_AcilStop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_AcilStop.AutoSize = true;
            this.lbl_AcilStop.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AcilStop.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_AcilStop.Location = new System.Drawing.Point(152, 128);
            this.lbl_AcilStop.Name = "lbl_AcilStop";
            this.lbl_AcilStop.Size = new System.Drawing.Size(13, 18);
            this.lbl_AcilStop.TabIndex = 8;
            this.lbl_AcilStop.Text = "-";
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
            // lbl_Duman
            // 
            this.lbl_Duman.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Duman.AutoSize = true;
            this.lbl_Duman.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Duman.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Duman.Location = new System.Drawing.Point(152, 52);
            this.lbl_Duman.Name = "lbl_Duman";
            this.lbl_Duman.Size = new System.Drawing.Size(13, 18);
            this.lbl_Duman.TabIndex = 4;
            this.lbl_Duman.Text = "-";
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
            // lbl_SuBaskini
            // 
            this.lbl_SuBaskini.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_SuBaskini.AutoSize = true;
            this.lbl_SuBaskini.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SuBaskini.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_SuBaskini.Location = new System.Drawing.Point(152, 90);
            this.lbl_SuBaskini.Name = "lbl_SuBaskini";
            this.lbl_SuBaskini.Size = new System.Drawing.Size(13, 18);
            this.lbl_SuBaskini.TabIndex = 6;
            this.lbl_SuBaskini.Text = "-";
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
            // lbl_Enerji
            // 
            this.lbl_Enerji.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Enerji.AutoSize = true;
            this.lbl_Enerji.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Enerji.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Enerji.Location = new System.Drawing.Point(152, 166);
            this.lbl_Enerji.Name = "lbl_Enerji";
            this.lbl_Enerji.Size = new System.Drawing.Size(13, 18);
            this.lbl_Enerji.TabIndex = 8;
            this.lbl_Enerji.Text = "-";
            // 
            // tblLayP_kalibrasyonBilgileri
            // 
            this.tblLayP_kalibrasyonBilgileri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblLayP_kalibrasyonBilgileri.BackColor = System.Drawing.Color.White;
            this.tblLayP_kalibrasyonBilgileri.ColumnCount = 1;
            this.tblLayP_kalibrasyonBilgileri.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayP_kalibrasyonBilgileri.Controls.Add(this.lbl_pH, 0, 8);
            this.tblLayP_kalibrasyonBilgileri.Controls.Add(this.label114, 0, 0);
            this.tblLayP_kalibrasyonBilgileri.Controls.Add(this.label115, 0, 1);
            this.tblLayP_kalibrasyonBilgileri.Controls.Add(this.label117, 0, 3);
            this.tblLayP_kalibrasyonBilgileri.Controls.Add(this.label119, 0, 5);
            this.tblLayP_kalibrasyonBilgileri.Controls.Add(this.label120, 0, 7);
            this.tblLayP_kalibrasyonBilgileri.Controls.Add(this.lbl_AKM, 0, 2);
            this.tblLayP_kalibrasyonBilgileri.Controls.Add(this.lbl_KOi, 0, 4);
            this.tblLayP_kalibrasyonBilgileri.Controls.Add(this.lbl_Iletkenlik, 0, 6);
            this.tblLayP_kalibrasyonBilgileri.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.tblLayP_kalibrasyonBilgileri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblLayP_kalibrasyonBilgileri.Location = new System.Drawing.Point(13, 506);
            this.tblLayP_kalibrasyonBilgileri.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayP_kalibrasyonBilgileri.Name = "tblLayP_kalibrasyonBilgileri";
            this.tblLayP_kalibrasyonBilgileri.Padding = new System.Windows.Forms.Padding(5);
            this.tblLayP_kalibrasyonBilgileri.RowCount = 9;
            this.tblLayP_kalibrasyonBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayP_kalibrasyonBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_kalibrasyonBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_kalibrasyonBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_kalibrasyonBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_kalibrasyonBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_kalibrasyonBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_kalibrasyonBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblLayP_kalibrasyonBilgileri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayP_kalibrasyonBilgileri.Size = new System.Drawing.Size(317, 201);
            this.tblLayP_kalibrasyonBilgileri.TabIndex = 1;
            this.tblLayP_kalibrasyonBilgileri.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tblLayP_kalibrasyonBilgileri_CellPaint);
            // 
            // lbl_pH
            // 
            this.lbl_pH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pH.AutoSize = true;
            this.lbl_pH.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pH.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_pH.Location = new System.Drawing.Point(152, 172);
            this.lbl_pH.Name = "lbl_pH";
            this.lbl_pH.Size = new System.Drawing.Size(13, 18);
            this.lbl_pH.TabIndex = 9;
            this.lbl_pH.Text = "-";
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
            // lbl_AKM
            // 
            this.lbl_AKM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_AKM.AutoSize = true;
            this.lbl_AKM.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AKM.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_AKM.Location = new System.Drawing.Point(152, 58);
            this.lbl_AKM.Name = "lbl_AKM";
            this.lbl_AKM.Size = new System.Drawing.Size(13, 18);
            this.lbl_AKM.TabIndex = 6;
            this.lbl_AKM.Text = "-";
            // 
            // lbl_KOi
            // 
            this.lbl_KOi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_KOi.AutoSize = true;
            this.lbl_KOi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KOi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_KOi.Location = new System.Drawing.Point(152, 96);
            this.lbl_KOi.Name = "lbl_KOi";
            this.lbl_KOi.Size = new System.Drawing.Size(13, 18);
            this.lbl_KOi.TabIndex = 7;
            this.lbl_KOi.Text = "-";
            // 
            // lbl_Iletkenlik
            // 
            this.lbl_Iletkenlik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Iletkenlik.AutoSize = true;
            this.lbl_Iletkenlik.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Iletkenlik.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Iletkenlik.Location = new System.Drawing.Point(152, 134);
            this.lbl_Iletkenlik.Name = "lbl_Iletkenlik";
            this.lbl_Iletkenlik.Size = new System.Drawing.Size(13, 18);
            this.lbl_Iletkenlik.TabIndex = 8;
            this.lbl_Iletkenlik.Text = "-";
            // 
            // Timer_SendData
            // 
            this.Timer_SendData.Enabled = true;
            this.Timer_SendData.Interval = 60000;
            this.Timer_SendData.Tick += new System.EventHandler(this.Timer_SendData_Tick);
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
            this.tableLayoutPanel27.PerformLayout();
            this.tblLayP_donenCevaplar.ResumeLayout(false);
            this.tblLayP_donenCevaplar.PerformLayout();
            this.tblLayP_kabinDurumu.ResumeLayout(false);
            this.tblLayP_kabinDurumu.PerformLayout();
            this.tblLayP_kalibrasyonBilgileri.ResumeLayout(false);
            this.tblLayP_kalibrasyonBilgileri.PerformLayout();
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
        private System.Windows.Forms.Timer timer_PlcConnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.TableLayoutPanel tblLayP_donenCevaplar;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label106;
        public System.Windows.Forms.Label lbl_CevapHaftalikYikama;
        protected System.Windows.Forms.Label lbl_CevapGunlukYikama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_CevapKalibrasyon;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_CevapAkisHizi;
        private System.Windows.Forms.TableLayoutPanel tblLayP_kabinDurumu;
        private System.Windows.Forms.Label lbl_AcilStop;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label lbl_Duman;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label lbl_SuBaskini;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.TableLayoutPanel tblLayP_kalibrasyonBilgileri;
        private System.Windows.Forms.Label lbl_pH;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label lbl_AKM;
        private System.Windows.Forms.Label lbl_KOi;
        private System.Windows.Forms.Label lbl_Iletkenlik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Enerji;
        private System.Windows.Forms.Timer Timer_SendData;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lbl_CevapTekrarVeri;
        private System.Windows.Forms.Label lbl_LastQuery;
        protected System.Windows.Forms.Label lbl_CevapVeriSagligi;
    }
}