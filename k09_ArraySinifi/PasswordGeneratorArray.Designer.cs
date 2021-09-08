namespace k09_ArraySinifi
{
    partial class PasswordGeneratorArray
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
            this.cbBuyukHarf = new System.Windows.Forms.CheckBox();
            this.cbKucukHarf = new System.Windows.Forms.CheckBox();
            this.cbRakam = new System.Windows.Forms.CheckBox();
            this.cbSembol = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.lstSifreler = new System.Windows.Forms.ListBox();
            this.txtKarakterSayisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbBuyukHarf
            // 
            this.cbBuyukHarf.AutoSize = true;
            this.cbBuyukHarf.Location = new System.Drawing.Point(8, 54);
            this.cbBuyukHarf.Name = "cbBuyukHarf";
            this.cbBuyukHarf.Size = new System.Drawing.Size(79, 17);
            this.cbBuyukHarf.TabIndex = 0;
            this.cbBuyukHarf.Text = "Büyük Harf";
            this.cbBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // cbKucukHarf
            // 
            this.cbKucukHarf.AutoSize = true;
            this.cbKucukHarf.Location = new System.Drawing.Point(8, 77);
            this.cbKucukHarf.Name = "cbKucukHarf";
            this.cbKucukHarf.Size = new System.Drawing.Size(80, 17);
            this.cbKucukHarf.TabIndex = 1;
            this.cbKucukHarf.Text = "Küçük Harf";
            this.cbKucukHarf.UseVisualStyleBackColor = true;
            // 
            // cbRakam
            // 
            this.cbRakam.AutoSize = true;
            this.cbRakam.Location = new System.Drawing.Point(8, 100);
            this.cbRakam.Name = "cbRakam";
            this.cbRakam.Size = new System.Drawing.Size(60, 17);
            this.cbRakam.TabIndex = 2;
            this.cbRakam.Text = "Rakam";
            this.cbRakam.UseVisualStyleBackColor = true;
            // 
            // cbSembol
            // 
            this.cbSembol.AutoSize = true;
            this.cbSembol.Location = new System.Drawing.Point(8, 123);
            this.cbSembol.Name = "cbSembol";
            this.cbSembol.Size = new System.Drawing.Size(61, 17);
            this.cbSembol.TabIndex = 3;
            this.cbSembol.Text = "Sembol";
            this.cbSembol.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kaç karakterli şifre:";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(8, 180);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(119, 34);
            this.btnOlustur.TabIndex = 5;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // lstSifreler
            // 
            this.lstSifreler.FormattingEnabled = true;
            this.lstSifreler.Location = new System.Drawing.Point(8, 220);
            this.lstSifreler.Name = "lstSifreler";
            this.lstSifreler.Size = new System.Drawing.Size(120, 95);
            this.lstSifreler.TabIndex = 6;
            // 
            // txtKarakterSayisi
            // 
            this.txtKarakterSayisi.Location = new System.Drawing.Point(115, 18);
            this.txtKarakterSayisi.Name = "txtKarakterSayisi";
            this.txtKarakterSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKarakterSayisi.TabIndex = 7;
            // 
            // PasswordGeneratorArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKarakterSayisi);
            this.Controls.Add(this.lstSifreler);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSembol);
            this.Controls.Add(this.cbRakam);
            this.Controls.Add(this.cbKucukHarf);
            this.Controls.Add(this.cbBuyukHarf);
            this.Name = "PasswordGeneratorArray";
            this.Text = "PasswordGeneratorArray";
            this.Load += new System.EventHandler(this.PasswordGeneratorArray_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbBuyukHarf;
        private System.Windows.Forms.CheckBox cbKucukHarf;
        private System.Windows.Forms.CheckBox cbRakam;
        private System.Windows.Forms.CheckBox cbSembol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.ListBox lstSifreler;
        private System.Windows.Forms.TextBox txtKarakterSayisi;
    }
}