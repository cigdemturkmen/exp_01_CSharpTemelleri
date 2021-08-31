namespace k06_KararYapilari
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKullaniciParolasi = new System.Windows.Forms.TextBox();
            this.chbBeniHatirla = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifrenizi giriniz";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(58, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Location = new System.Drawing.Point(83, 71);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(75, 23);
            this.btnKontrolEt.TabIndex = 2;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı adınızı giriniz:";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(359, 329);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(75, 23);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(334, 259);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parolanızı giriniz:";
            // 
            // txtKullaniciParolasi
            // 
            this.txtKullaniciParolasi.Location = new System.Drawing.Point(334, 292);
            this.txtKullaniciParolasi.Name = "txtKullaniciParolasi";
            this.txtKullaniciParolasi.PasswordChar = '*';
            this.txtKullaniciParolasi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciParolasi.TabIndex = 7;
            // 
            // chbBeniHatirla
            // 
            this.chbBeniHatirla.AutoSize = true;
            this.chbBeniHatirla.Location = new System.Drawing.Point(247, 332);
            this.chbBeniHatirla.Name = "chbBeniHatirla";
            this.chbBeniHatirla.Size = new System.Drawing.Size(83, 17);
            this.chbBeniHatirla.TabIndex = 9;
            this.chbBeniHatirla.Text = "Beni Hatırla!";
            this.chbBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chbBeniHatirla);
            this.Controls.Add(this.txtKullaniciParolasi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKullaniciParolasi;
        private System.Windows.Forms.CheckBox chbBeniHatirla;
    }
}