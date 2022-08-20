namespace SAISKabini
{
    partial class MailAyarlari_Kullanicilar
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
            this.tablelyp_Left = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbox_Mail = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtbox_Soyad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbox_Ad = new System.Windows.Forms.TextBox();
            this.tablelyp_Right = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Duzenle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TableLayoutPanel_UserMailList = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_KaydetDurumSec = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.timer_AlarmKontrol = new System.Windows.Forms.Timer(this.components);
            this.tablelyp_Left.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tablelyp_Right.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.TableLayoutPanel_UserMailList.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablelyp_Left
            // 
            this.tablelyp_Left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablelyp_Left.BackColor = System.Drawing.Color.White;
            this.tablelyp_Left.ColumnCount = 1;
            this.tablelyp_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelyp_Left.Controls.Add(this.groupBox1, 0, 0);
            this.tablelyp_Left.Location = new System.Drawing.Point(211, 23);
            this.tablelyp_Left.Name = "tablelyp_Left";
            this.tablelyp_Left.Padding = new System.Windows.Forms.Padding(10);
            this.tablelyp_Left.RowCount = 1;
            this.tablelyp_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelyp_Left.Size = new System.Drawing.Size(477, 304);
            this.tablelyp_Left.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btn_Kaydet);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(451, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Ekle";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.AutoSize = true;
            this.btn_Kaydet.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Kaydet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_Kaydet.Location = new System.Drawing.Point(13, 206);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(428, 35);
            this.btn_Kaydet.TabIndex = 4;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.txtbox_Mail);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(13, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 79);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MAIL";
            // 
            // txtbox_Mail
            // 
            this.txtbox_Mail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtbox_Mail.Location = new System.Drawing.Point(6, 26);
            this.txtbox_Mail.Name = "txtbox_Mail";
            this.txtbox_Mail.Size = new System.Drawing.Size(415, 27);
            this.txtbox_Mail.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.txtbox_Soyad);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(230, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(211, 79);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SOYAD";
            // 
            // txtbox_Soyad
            // 
            this.txtbox_Soyad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtbox_Soyad.Location = new System.Drawing.Point(6, 26);
            this.txtbox_Soyad.Name = "txtbox_Soyad";
            this.txtbox_Soyad.Size = new System.Drawing.Size(199, 27);
            this.txtbox_Soyad.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.txtbox_Ad);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(13, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AD";
            // 
            // txtbox_Ad
            // 
            this.txtbox_Ad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtbox_Ad.Location = new System.Drawing.Point(6, 26);
            this.txtbox_Ad.Name = "txtbox_Ad";
            this.txtbox_Ad.Size = new System.Drawing.Size(199, 27);
            this.txtbox_Ad.TabIndex = 0;
            // 
            // tablelyp_Right
            // 
            this.tablelyp_Right.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablelyp_Right.BackColor = System.Drawing.Color.White;
            this.tablelyp_Right.ColumnCount = 1;
            this.tablelyp_Right.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelyp_Right.Controls.Add(this.groupBox5, 0, 0);
            this.tablelyp_Right.Location = new System.Drawing.Point(711, 23);
            this.tablelyp_Right.Name = "tablelyp_Right";
            this.tablelyp_Right.Padding = new System.Windows.Forms.Padding(10);
            this.tablelyp_Right.RowCount = 1;
            this.tablelyp_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelyp_Right.Size = new System.Drawing.Size(477, 304);
            this.tablelyp_Right.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.btn_Sil);
            this.groupBox5.Controls.Add(this.btn_Duzenle);
            this.groupBox5.Controls.Add(this.listView1);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(13, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox5.Size = new System.Drawing.Size(451, 278);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kullanıcılar";
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Sil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.Color.Black;
            this.btn_Sil.Location = new System.Drawing.Point(232, 230);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(209, 35);
            this.btn_Sil.TabIndex = 2;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Duzenle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Duzenle.ForeColor = System.Drawing.Color.Black;
            this.btn_Duzenle.Location = new System.Drawing.Point(13, 230);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(209, 35);
            this.btn_Duzenle.TabIndex = 1;
            this.btn_Duzenle.Text = "Düzenle";
            this.btn_Duzenle.UseVisualStyleBackColor = false;
            this.btn_Duzenle.Click += new System.EventHandler(this.btn_Duzenle_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Calibri", 12F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(428, 194);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.btn_Duzenle_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadı";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mail";
            this.columnHeader3.Width = 227;
            // 
            // TableLayoutPanel_UserMailList
            // 
            this.TableLayoutPanel_UserMailList.BackColor = System.Drawing.Color.White;
            this.TableLayoutPanel_UserMailList.ColumnCount = 1;
            this.TableLayoutPanel_UserMailList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_UserMailList.Controls.Add(this.groupBox6, 0, 0);
            this.TableLayoutPanel_UserMailList.Location = new System.Drawing.Point(211, 355);
            this.TableLayoutPanel_UserMailList.Name = "TableLayoutPanel_UserMailList";
            this.TableLayoutPanel_UserMailList.RowCount = 1;
            this.TableLayoutPanel_UserMailList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_UserMailList.Size = new System.Drawing.Size(977, 281);
            this.TableLayoutPanel_UserMailList.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_KaydetDurumSec);
            this.groupBox6.Controls.Add(this.checkedListBox1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(10, 10);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(957, 261);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Seçili Kullanıcı: -";
            // 
            // btn_KaydetDurumSec
            // 
            this.btn_KaydetDurumSec.AutoSize = true;
            this.btn_KaydetDurumSec.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_KaydetDurumSec.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KaydetDurumSec.ForeColor = System.Drawing.Color.White;
            this.btn_KaydetDurumSec.Location = new System.Drawing.Point(13, 217);
            this.btn_KaydetDurumSec.Name = "btn_KaydetDurumSec";
            this.btn_KaydetDurumSec.Size = new System.Drawing.Size(931, 35);
            this.btn_KaydetDurumSec.TabIndex = 4;
            this.btn_KaydetDurumSec.Text = "Kaydet";
            this.btn_KaydetDurumSec.UseVisualStyleBackColor = false;
            this.btn_KaydetDurumSec.Click += new System.EventHandler(this.btn_KaydetDurumSec_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "pH Limit Aşmı",
            "AKM Limit Aşımı",
            "KOi Limit Aşımı",
            "Duman Alarmı",
            "Su Baskını Alarmı",
            "Elektrik Alarmı",
            "Kapı Alarmı",
            "Pompa 1 Alarmı",
            "Pompa 2 Alarmı",
            "Temiz Su Pompa Termik",
            "Yikama Tankı Alarm",
            "Veri Durumu"});
            this.checkedListBox1.Location = new System.Drawing.Point(13, 31);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(10);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(931, 176);
            this.checkedListBox1.TabIndex = 1;
            // 
            // timer_AlarmKontrol
            // 
            this.timer_AlarmKontrol.Interval = 60000;
            this.timer_AlarmKontrol.Tick += new System.EventHandler(this.timer_AlarmKontrol_Tick);
            // 
            // MailAyarlari_Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 663);
            this.Controls.Add(this.TableLayoutPanel_UserMailList);
            this.Controls.Add(this.tablelyp_Left);
            this.Controls.Add(this.tablelyp_Right);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MailAyarlari_Kullanicilar";
            this.Text = "MailAyarlari_Kullanicilar";
            this.tablelyp_Left.ResumeLayout(false);
            this.tablelyp_Left.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tablelyp_Right.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.TableLayoutPanel_UserMailList.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablelyp_Left;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbox_Mail;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtbox_Soyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbox_Ad;
        private System.Windows.Forms.TableLayoutPanel tablelyp_Right;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Duzenle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_UserMailList;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_KaydetDurumSec;
        private System.Windows.Forms.Timer timer_AlarmKontrol;
    }
}