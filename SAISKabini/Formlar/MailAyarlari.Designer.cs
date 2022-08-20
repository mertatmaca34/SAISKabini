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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullanıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailDurumlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.panel_content);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 738);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcılarToolStripMenuItem,
            this.mailDurumlarıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1410, 72);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcılarToolStripMenuItem
            // 
            this.kullanıcılarToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcılarToolStripMenuItem.Image = global::SAISKabini.Properties.Resources.users_96px;
            this.kullanıcılarToolStripMenuItem.Name = "kullanıcılarToolStripMenuItem";
            this.kullanıcılarToolStripMenuItem.Size = new System.Drawing.Size(153, 68);
            this.kullanıcılarToolStripMenuItem.Text = "Kullanıcılar";
            // 
            // mailDurumlarıToolStripMenuItem
            // 
            this.mailDurumlarıToolStripMenuItem.Enabled = false;
            this.mailDurumlarıToolStripMenuItem.Image = global::SAISKabini.Properties.Resources.signature_96px;
            this.mailDurumlarıToolStripMenuItem.Name = "mailDurumlarıToolStripMenuItem";
            this.mailDurumlarıToolStripMenuItem.Size = new System.Drawing.Size(188, 68);
            this.mailDurumlarıToolStripMenuItem.Text = "Mail Durumları";
            // 
            // panel_content
            // 
            this.panel_content.Location = new System.Drawing.Point(0, 75);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(1410, 663);
            this.panel_content.TabIndex = 1;
            // 
            // MailAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 738);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MailAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailAyarlari";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailDurumlarıToolStripMenuItem;
        private System.Windows.Forms.Panel panel_content;
    }
}