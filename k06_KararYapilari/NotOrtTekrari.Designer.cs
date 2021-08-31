namespace k06_KararYapilari
{
    partial class NotOrtTekrari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotOrtTekrari));
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNot = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNotOrtalamasi = new System.Windows.Forms.Label();
            this.lblHarfNotu = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.SystemColors.Control;
            this.btnHesapla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHesapla.Location = new System.Drawing.Point(9, 143);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 41);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(6, 36);
            this.txtVize.Multiline = true;
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(100, 20);
            this.txtVize.TabIndex = 1;
         
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(9, 100);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vize notunuzu giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Final notunuzu giriniz:";
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.ForeColor = System.Drawing.Color.Black;
            this.lblNot.Location = new System.Drawing.Point(3, 223);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(79, 13);
            this.lblNot.TabIndex = 5;
            this.lblNot.Text = "Not Ortalaması:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Harf Notu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Durum:";
            // 
            // lblNotOrtalamasi
            // 
            this.lblNotOrtalamasi.AutoSize = true;
            this.lblNotOrtalamasi.ForeColor = System.Drawing.Color.Black;
            this.lblNotOrtalamasi.Location = new System.Drawing.Point(93, 223);
            this.lblNotOrtalamasi.Name = "lblNotOrtalamasi";
            this.lblNotOrtalamasi.Size = new System.Drawing.Size(16, 13);
            this.lblNotOrtalamasi.TabIndex = 8;
            this.lblNotOrtalamasi.Text = "...";
            // 
            // lblHarfNotu
            // 
            this.lblHarfNotu.AutoSize = true;
            this.lblHarfNotu.ForeColor = System.Drawing.Color.Black;
            this.lblHarfNotu.Location = new System.Drawing.Point(93, 256);
            this.lblHarfNotu.Name = "lblHarfNotu";
            this.lblHarfNotu.Size = new System.Drawing.Size(16, 13);
            this.lblHarfNotu.TabIndex = 9;
            this.lblHarfNotu.Text = "...";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.ForeColor = System.Drawing.Color.Black;
            this.lblDurum.Location = new System.Drawing.Point(93, 293);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(16, 13);
            this.lblDurum.TabIndex = 10;
            this.lblDurum.Text = "...";
            // 
            // NotOrtTekrari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblHarfNotu);
            this.Controls.Add(this.lblNotOrtalamasi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFinal);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.MaximumSize = new System.Drawing.Size(550, 500);
            this.MinimumSize = new System.Drawing.Size(550, 500);
            this.Name = "NotOrtTekrari";
            this.Tag = "";
            this.Text = "NotOrtTekrari";
            this.Load += new System.EventHandler(this.NotOrtTekrari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNotOrtalamasi;
        private System.Windows.Forms.Label lblHarfNotu;
        private System.Windows.Forms.Label lblDurum;
    }
}