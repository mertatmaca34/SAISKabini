namespace SAISKabini
{
    partial class Ayarlar
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
            this.panel_content = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_mailDurumlari = new System.Windows.Forms.Button();
            this.btn_istasyonAyarlari = new System.Windows.Forms.Button();
            this.panel_content.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_content
            // 
            this.panel_content.Controls.Add(this.tableLayoutPanel1);
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(0, 0);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(1410, 738);
            this.panel_content.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_mailDurumlari, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_istasyonAyarlari, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(374, 251);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 237);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btn_mailDurumlari
            // 
            this.btn_mailDurumlari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mailDurumlari.BackColor = System.Drawing.Color.White;
            this.btn_mailDurumlari.BackgroundImage = global::SAISKabini.Properties.Resources.Xbox_Series_X_100px;
            this.btn_mailDurumlari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_mailDurumlari.FlatAppearance.BorderSize = 0;
            this.btn_mailDurumlari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btn_mailDurumlari.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btn_mailDurumlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mailDurumlari.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_mailDurumlari.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_mailDurumlari.Location = new System.Drawing.Point(397, 18);
            this.btn_mailDurumlari.Name = "btn_mailDurumlari";
            this.btn_mailDurumlari.Size = new System.Drawing.Size(200, 200);
            this.btn_mailDurumlari.TabIndex = 2;
            this.btn_mailDurumlari.Text = "PLC Ayarları";
            this.btn_mailDurumlari.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_mailDurumlari.UseVisualStyleBackColor = false;
            // 
            // btn_istasyonAyarlari
            // 
            this.btn_istasyonAyarlari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_istasyonAyarlari.BackColor = System.Drawing.Color.White;
            this.btn_istasyonAyarlari.BackgroundImage = global::SAISKabini.Properties.Resources.settings_96px;
            this.btn_istasyonAyarlari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_istasyonAyarlari.FlatAppearance.BorderSize = 0;
            this.btn_istasyonAyarlari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btn_istasyonAyarlari.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btn_istasyonAyarlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_istasyonAyarlari.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_istasyonAyarlari.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_istasyonAyarlari.Location = new System.Drawing.Point(65, 18);
            this.btn_istasyonAyarlari.Name = "btn_istasyonAyarlari";
            this.btn_istasyonAyarlari.Size = new System.Drawing.Size(200, 200);
            this.btn_istasyonAyarlari.TabIndex = 3;
            this.btn_istasyonAyarlari.Text = "İstasyon Ayarları";
            this.btn_istasyonAyarlari.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_istasyonAyarlari.UseVisualStyleBackColor = false;
            this.btn_istasyonAyarlari.Click += new System.EventHandler(this.btn_istasyonAyarlari_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 738);
            this.Controls.Add(this.panel_content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ayarlar";
            this.Text = "Raporlar";
            this.panel_content.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_mailDurumlari;
        private System.Windows.Forms.Button btn_istasyonAyarlari;
    }
}