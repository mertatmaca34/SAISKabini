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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullanıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailDurumlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPIAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_content = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcılarToolStripMenuItem,
            this.mailDurumlarıToolStripMenuItem,
            this.aPIAyarlarıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1410, 72);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcılarToolStripMenuItem
            // 
            this.kullanıcılarToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcılarToolStripMenuItem.Image = global::SAISKabini.Properties.Resources.settings_96px;
            this.kullanıcılarToolStripMenuItem.Name = "kullanıcılarToolStripMenuItem";
            this.kullanıcılarToolStripMenuItem.Size = new System.Drawing.Size(186, 68);
            this.kullanıcılarToolStripMenuItem.Text = "İstasyon Ayarları";
            this.kullanıcılarToolStripMenuItem.Click += new System.EventHandler(this.kullanıcılarToolStripMenuItem_Click);
            // 
            // mailDurumlarıToolStripMenuItem
            // 
            this.mailDurumlarıToolStripMenuItem.Image = global::SAISKabini.Properties.Resources.Xbox_Series_X_100px;
            this.mailDurumlarıToolStripMenuItem.Name = "mailDurumlarıToolStripMenuItem";
            this.mailDurumlarıToolStripMenuItem.Size = new System.Drawing.Size(167, 68);
            this.mailDurumlarıToolStripMenuItem.Text = "PLC Ayarları";
            this.mailDurumlarıToolStripMenuItem.Click += new System.EventHandler(this.mailDurumlarıToolStripMenuItem_Click);
            // 
            // aPIAyarlarıToolStripMenuItem
            // 
            this.aPIAyarlarıToolStripMenuItem.Image = global::SAISKabini.Properties.Resources.Rest_API_100px;
            this.aPIAyarlarıToolStripMenuItem.Name = "aPIAyarlarıToolStripMenuItem";
            this.aPIAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(166, 68);
            this.aPIAyarlarıToolStripMenuItem.Text = "API Ayarları";
            // 
            // panel_content
            // 
            this.panel_content.Location = new System.Drawing.Point(0, 75);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(1410, 663);
            this.panel_content.TabIndex = 0;
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 738);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ayarlar";
            this.Text = "Raporlar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailDurumlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPIAyarlarıToolStripMenuItem;
        private System.Windows.Forms.Panel panel_content;
    }
}