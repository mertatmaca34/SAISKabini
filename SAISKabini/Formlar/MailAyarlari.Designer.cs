namespace SAISKabini
{
    partial class MailAyarlari
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_content = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_mailServerAyarlari = new System.Windows.Forms.Button();
            this.btn_mailDurumlari = new System.Windows.Forms.Button();
            this.btn_kullanicilar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_content.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_content);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 738);
            this.panel1.TabIndex = 1;
            // 
            // panel_content
            // 
            this.panel_content.Controls.Add(this.tableLayoutPanel1);
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(0, 0);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(1410, 738);
            this.panel_content.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_mailServerAyarlari, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_mailDurumlari, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_kullanicilar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(374, 251);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 237);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_mailServerAyarlari
            // 
            this.btn_mailServerAyarlari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mailServerAyarlari.BackColor = System.Drawing.Color.White;
            this.btn_mailServerAyarlari.BackgroundImage = global::SAISKabini.Properties.Resources.mail_with_wings_96px;
            this.btn_mailServerAyarlari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_mailServerAyarlari.FlatAppearance.BorderSize = 0;
            this.btn_mailServerAyarlari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btn_mailServerAyarlari.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btn_mailServerAyarlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mailServerAyarlari.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_mailServerAyarlari.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_mailServerAyarlari.Location = new System.Drawing.Point(452, 18);
            this.btn_mailServerAyarlari.Name = "btn_mailServerAyarlari";
            this.btn_mailServerAyarlari.Size = new System.Drawing.Size(200, 200);
            this.btn_mailServerAyarlari.TabIndex = 1;
            this.btn_mailServerAyarlari.Text = "Mail Server Ayarları";
            this.btn_mailServerAyarlari.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_mailServerAyarlari.UseVisualStyleBackColor = false;
            this.btn_mailServerAyarlari.Click += new System.EventHandler(this.btn_mailServerAyarlari_Click);
            // 
            // btn_mailDurumlari
            // 
            this.btn_mailDurumlari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mailDurumlari.BackColor = System.Drawing.Color.White;
            this.btn_mailDurumlari.BackgroundImage = global::SAISKabini.Properties.Resources.signature_96px;
            this.btn_mailDurumlari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_mailDurumlari.FlatAppearance.BorderSize = 0;
            this.btn_mailDurumlari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btn_mailDurumlari.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btn_mailDurumlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mailDurumlari.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_mailDurumlari.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_mailDurumlari.Location = new System.Drawing.Point(231, 18);
            this.btn_mailDurumlari.Name = "btn_mailDurumlari";
            this.btn_mailDurumlari.Size = new System.Drawing.Size(200, 200);
            this.btn_mailDurumlari.TabIndex = 2;
            this.btn_mailDurumlari.Text = "Mail Durumları";
            this.btn_mailDurumlari.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_mailDurumlari.UseVisualStyleBackColor = false;
            this.btn_mailDurumlari.Click += new System.EventHandler(this.btn_mailDurumlari_Click);
            // 
            // btn_kullanicilar
            // 
            this.btn_kullanicilar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_kullanicilar.BackColor = System.Drawing.Color.White;
            this.btn_kullanicilar.BackgroundImage = global::SAISKabini.Properties.Resources.users_96px;
            this.btn_kullanicilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_kullanicilar.FlatAppearance.BorderSize = 0;
            this.btn_kullanicilar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btn_kullanicilar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btn_kullanicilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kullanicilar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_kullanicilar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kullanicilar.Location = new System.Drawing.Point(10, 18);
            this.btn_kullanicilar.Name = "btn_kullanicilar";
            this.btn_kullanicilar.Size = new System.Drawing.Size(200, 200);
            this.btn_kullanicilar.TabIndex = 3;
            this.btn_kullanicilar.Text = "Kullanıcılar";
            this.btn_kullanicilar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kullanicilar.UseVisualStyleBackColor = false;
            this.btn_kullanicilar.Click += new System.EventHandler(this.btn_kullanicilar_Click);
            // 
            // MailAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 738);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MailAyarlari";
            this.Text = "MailAyarlari";
            this.panel1.ResumeLayout(false);
            this.panel_content.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_mailServerAyarlari;
        private System.Windows.Forms.Button btn_mailDurumlari;
        private System.Windows.Forms.Button btn_kullanicilar;
    }
}