
namespace k08_Diziler
{
    partial class RandomPasswordGenerator
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
            this.txtKarakterSayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBuyukHarf = new System.Windows.Forms.CheckBox();
            this.cbKucukHarf = new System.Windows.Forms.CheckBox();
            this.cbSembol = new System.Windows.Forms.CheckBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.cbRakam = new System.Windows.Forms.CheckBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaç karakterli şifre oluşturmak istediğinizi giriniz:";
            // 
            // txtKarakterSayisi
            // 
            this.txtKarakterSayisi.Location = new System.Drawing.Point(330, 9);
            this.txtKarakterSayisi.Name = "txtKarakterSayisi";
            this.txtKarakterSayisi.Size = new System.Drawing.Size(100, 22);
            this.txtKarakterSayisi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifreniz için istediğiniz özellikler:";
            // 
            // cbBuyukHarf
            // 
            this.cbBuyukHarf.AutoSize = true;
            this.cbBuyukHarf.Location = new System.Drawing.Point(15, 66);
            this.cbBuyukHarf.Name = "cbBuyukHarf";
            this.cbBuyukHarf.Size = new System.Drawing.Size(143, 21);
            this.cbBuyukHarf.TabIndex = 3;
            this.cbBuyukHarf.Text = "Büyük harf içersin";
            this.cbBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // cbKucukHarf
            // 
            this.cbKucukHarf.AutoSize = true;
            this.cbKucukHarf.Location = new System.Drawing.Point(15, 93);
            this.cbKucukHarf.Name = "cbKucukHarf";
            this.cbKucukHarf.Size = new System.Drawing.Size(143, 21);
            this.cbKucukHarf.TabIndex = 4;
            this.cbKucukHarf.Text = "Küçük harf içersin";
            this.cbKucukHarf.UseVisualStyleBackColor = true;
            // 
            // cbSembol
            // 
            this.cbSembol.AutoSize = true;
            this.cbSembol.Location = new System.Drawing.Point(164, 66);
            this.cbSembol.Name = "cbSembol";
            this.cbSembol.Size = new System.Drawing.Size(122, 21);
            this.cbSembol.TabIndex = 5;
            this.cbSembol.Text = "Sembol içersin";
            this.cbSembol.UseVisualStyleBackColor = true;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(15, 147);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(415, 35);
            this.btnOlustur.TabIndex = 6;
            this.btnOlustur.Text = "Şifre Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(15, 188);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(415, 22);
            this.txtSifre.TabIndex = 7;
            // 
            // cbRakam
            // 
            this.cbRakam.AutoSize = true;
            this.cbRakam.Location = new System.Drawing.Point(164, 93);
            this.cbRakam.Name = "cbRakam";
            this.cbRakam.Size = new System.Drawing.Size(119, 21);
            this.cbRakam.TabIndex = 8;
            this.cbRakam.Text = "Rakam içersin";
            this.cbRakam.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(648, 401);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 23);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Test Button";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(648, 373);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(100, 22);
            this.txtTest.TabIndex = 10;
            // 
            // RandomPasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.cbRakam);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.cbSembol);
            this.Controls.Add(this.cbKucukHarf);
            this.Controls.Add(this.cbBuyukHarf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKarakterSayisi);
            this.Controls.Add(this.label1);
            this.Name = "RandomPasswordGenerator";
            this.Text = "RandomPasswordGenerator";
            this.Load += new System.EventHandler(this.RandomPasswordGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKarakterSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbBuyukHarf;
        private System.Windows.Forms.CheckBox cbKucukHarf;
        private System.Windows.Forms.CheckBox cbSembol;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.CheckBox cbRakam;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtTest;
    }
}