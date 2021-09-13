namespace k06_KararYapilari
{
    partial class Form5
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
            this.txtMevsim = new System.Windows.Forms.TextBox();
            this.btnAylariGetir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAyAdi = new System.Windows.Forms.TextBox();
            this.BtnMevsimAdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mevsim giriniz:";
            // 
            // txtMevsim
            // 
            this.txtMevsim.Location = new System.Drawing.Point(31, 52);
            this.txtMevsim.Margin = new System.Windows.Forms.Padding(4);
            this.txtMevsim.Name = "txtMevsim";
            this.txtMevsim.Size = new System.Drawing.Size(147, 22);
            this.txtMevsim.TabIndex = 1;
            // 
            // btnAylariGetir
            // 
            this.btnAylariGetir.Location = new System.Drawing.Point(31, 82);
            this.btnAylariGetir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAylariGetir.Name = "btnAylariGetir";
            this.btnAylariGetir.Size = new System.Drawing.Size(147, 28);
            this.btnAylariGetir.TabIndex = 2;
            this.btnAylariGetir.Text = "Ayları Getir";
            this.btnAylariGetir.UseVisualStyleBackColor = true;
            this.btnAylariGetir.Click += new System.EventHandler(this.btnAylariGetir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ay giriniz:";
            // 
            // txtAyAdi
            // 
            this.txtAyAdi.Location = new System.Drawing.Point(31, 152);
            this.txtAyAdi.Name = "txtAyAdi";
            this.txtAyAdi.Size = new System.Drawing.Size(147, 22);
            this.txtAyAdi.TabIndex = 4;
            // 
            // BtnMevsimAdi
            // 
            this.BtnMevsimAdi.Location = new System.Drawing.Point(31, 180);
            this.BtnMevsimAdi.Name = "BtnMevsimAdi";
            this.BtnMevsimAdi.Size = new System.Drawing.Size(147, 28);
            this.BtnMevsimAdi.TabIndex = 5;
            this.BtnMevsimAdi.Text = "Hangi mevsim";
            this.BtnMevsimAdi.UseVisualStyleBackColor = true;
            this.BtnMevsimAdi.Click += new System.EventHandler(this.BtnMevsimAdi_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnMevsimAdi);
            this.Controls.Add(this.txtAyAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAylariGetir);
            this.Controls.Add(this.txtMevsim);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMevsim;
        private System.Windows.Forms.Button btnAylariGetir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAyAdi;
        private System.Windows.Forms.Button BtnMevsimAdi;
    }
}