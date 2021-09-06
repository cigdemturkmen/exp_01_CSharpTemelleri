namespace k08_Diziler
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
            this.btnOrnek1 = new System.Windows.Forms.Button();
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.btnCifleriEkle = new System.Windows.Forms.Button();
            this.lstTek = new System.Windows.Forms.ListBox();
            this.lstCift = new System.Windows.Forms.ListBox();
            this.btn20ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Location = new System.Drawing.Point(12, 37);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(203, 32);
            this.btnOrnek1.TabIndex = 0;
            this.btnOrnek1.Text = "Elemanları Listeye Ekle";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.btnOrnek1_Click);
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.Location = new System.Drawing.Point(221, 37);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(165, 316);
            this.lstSonuc.TabIndex = 1;
            // 
            // btnCifleriEkle
            // 
            this.btnCifleriEkle.Location = new System.Drawing.Point(12, 89);
            this.btnCifleriEkle.Name = "btnCifleriEkle";
            this.btnCifleriEkle.Size = new System.Drawing.Size(203, 32);
            this.btnCifleriEkle.TabIndex = 2;
            this.btnCifleriEkle.Text = "çifleri ekle";
            this.btnCifleriEkle.UseVisualStyleBackColor = true;
            this.btnCifleriEkle.Click += new System.EventHandler(this.btnCifleriEkle_Click);
            // 
            // lstTek
            // 
            this.lstTek.FormattingEnabled = true;
            this.lstTek.Location = new System.Drawing.Point(95, 157);
            this.lstTek.Name = "lstTek";
            this.lstTek.Size = new System.Drawing.Size(120, 95);
            this.lstTek.TabIndex = 3;
            // 
            // lstCift
            // 
            this.lstCift.FormattingEnabled = true;
            this.lstCift.Location = new System.Drawing.Point(95, 258);
            this.lstCift.Name = "lstCift";
            this.lstCift.Size = new System.Drawing.Size(120, 95);
            this.lstCift.TabIndex = 4;
            // 
            // btn20ekle
            // 
            this.btn20ekle.Location = new System.Drawing.Point(12, 375);
            this.btn20ekle.Name = "btn20ekle";
            this.btn20ekle.Size = new System.Drawing.Size(203, 31);
            this.btn20ekle.TabIndex = 5;
            this.btn20ekle.Text = "button1";
            this.btn20ekle.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn20ekle);
            this.Controls.Add(this.lstCift);
            this.Controls.Add(this.lstTek);
            this.Controls.Add(this.btnCifleriEkle);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.btnOrnek1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.Button btnCifleriEkle;
        private System.Windows.Forms.ListBox lstTek;
        private System.Windows.Forms.ListBox lstCift;
        private System.Windows.Forms.Button btn20ekle;
    }
}