namespace SAISKabini
{
    partial class Deneme
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
            this.baglan = new System.Windows.Forms.Button();
            this.sonuc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yikama = new System.Windows.Forms.Button();
            this.haftalikyikama = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baglan
            // 
            this.baglan.Location = new System.Drawing.Point(6, 20);
            this.baglan.Name = "baglan";
            this.baglan.Size = new System.Drawing.Size(100, 23);
            this.baglan.TabIndex = 1;
            this.baglan.Text = "Data Gönder";
            this.baglan.UseVisualStyleBackColor = true;
            this.baglan.Click += new System.EventHandler(this.baglan_Click);
            // 
            // sonuc
            // 
            this.sonuc.Location = new System.Drawing.Point(120, 20);
            this.sonuc.Multiline = true;
            this.sonuc.Name = "sonuc";
            this.sonuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sonuc.Size = new System.Drawing.Size(650, 400);
            this.sonuc.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.haftalikyikama);
            this.groupBox1.Controls.Add(this.yikama);
            this.groupBox1.Controls.Add(this.baglan);
            this.groupBox1.Controls.Add(this.sonuc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gönder";
            // 
            // yikama
            // 
            this.yikama.Location = new System.Drawing.Point(6, 131);
            this.yikama.Name = "yikama";
            this.yikama.Size = new System.Drawing.Size(100, 23);
            this.yikama.TabIndex = 1;
            this.yikama.Text = "Günlük Yıkama Gönder";
            this.yikama.UseVisualStyleBackColor = true;
            this.yikama.Click += new System.EventHandler(this.yikama_Click);
            // 
            // haftalikyikama
            // 
            this.haftalikyikama.Location = new System.Drawing.Point(6, 202);
            this.haftalikyikama.Name = "haftalikyikama";
            this.haftalikyikama.Size = new System.Drawing.Size(100, 23);
            this.haftalikyikama.TabIndex = 1;
            this.haftalikyikama.Text = "Haftalık Yıkama Gönder";
            this.haftalikyikama.UseVisualStyleBackColor = true;
            this.haftalikyikama.Click += new System.EventHandler(this.haftalikyikama_Click);
            // 
            // Deneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Deneme";
            this.Text = "Deneme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button baglan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button yikama;
        public System.Windows.Forms.TextBox sonuc;
        private System.Windows.Forms.Button haftalikyikama;
    }
}