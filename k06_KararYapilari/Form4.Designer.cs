namespace k06_KararYapilari
{
    partial class Form4
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
            this.btnFiyatHesapla = new System.Windows.Forms.Button();
            this.txtKitapAdedi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFiyatHesapla
            // 
            this.btnFiyatHesapla.Location = new System.Drawing.Point(165, 150);
            this.btnFiyatHesapla.Name = "btnFiyatHesapla";
            this.btnFiyatHesapla.Size = new System.Drawing.Size(100, 23);
            this.btnFiyatHesapla.TabIndex = 0;
            this.btnFiyatHesapla.Text = "Fiyat Hesapla";
            this.btnFiyatHesapla.UseVisualStyleBackColor = true;
            this.btnFiyatHesapla.Click += new System.EventHandler(this.btnFiyatHesapla_Click);
            // 
            // txtKitapAdedi
            // 
            this.txtKitapAdedi.Location = new System.Drawing.Point(165, 102);
            this.txtKitapAdedi.Name = "txtKitapAdedi";
            this.txtKitapAdedi.Size = new System.Drawing.Size(100, 20);
            this.txtKitapAdedi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitap adedini giriniz:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(168, 179);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 3;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKitapAdedi);
            this.Controls.Add(this.btnFiyatHesapla);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiyatHesapla;
        private System.Windows.Forms.TextBox txtKitapAdedi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiyat;
    }
}