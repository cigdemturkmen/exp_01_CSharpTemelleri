namespace k11_Metodlar
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
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.btn1To100 = new System.Windows.Forms.Button();
            this.btn1Toi = new System.Windows.Forms.Button();
            this.btniToj = new System.Windows.Forms.Button();
            this.txti2 = new System.Windows.Forms.TextBox();
            this.txti1 = new System.Windows.Forms.TextBox();
            this.txtj2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMailler = new System.Windows.Forms.TextBox();
            this.btnMailleriAyristir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.Location = new System.Drawing.Point(456, 25);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(120, 368);
            this.lstSonuc.TabIndex = 0;
            // 
            // btn1To100
            // 
            this.btn1To100.Location = new System.Drawing.Point(56, 25);
            this.btn1To100.Name = "btn1To100";
            this.btn1To100.Size = new System.Drawing.Size(117, 23);
            this.btn1To100.TabIndex = 1;
            this.btn1To100.Text = "1\'den 100\'e";
            this.btn1To100.UseVisualStyleBackColor = true;
            this.btn1To100.Click += new System.EventHandler(this.btn1To100_Click);
            // 
            // btn1Toi
            // 
            this.btn1Toi.Location = new System.Drawing.Point(56, 51);
            this.btn1Toi.Name = "btn1Toi";
            this.btn1Toi.Size = new System.Drawing.Size(117, 23);
            this.btn1Toi.TabIndex = 2;
            this.btn1Toi.Text = "1\'den i\'ye";
            this.btn1Toi.UseVisualStyleBackColor = true;
            this.btn1Toi.Click += new System.EventHandler(this.btn1Toi_Click);
            // 
            // btniToj
            // 
            this.btniToj.Location = new System.Drawing.Point(56, 80);
            this.btniToj.Name = "btniToj";
            this.btniToj.Size = new System.Drawing.Size(117, 23);
            this.btniToj.TabIndex = 3;
            this.btniToj.Text = "i\'den j\'ye";
            this.btniToj.UseVisualStyleBackColor = true;
            this.btniToj.Click += new System.EventHandler(this.btniToj_Click);
            // 
            // txti2
            // 
            this.txti2.Location = new System.Drawing.Point(179, 83);
            this.txti2.Name = "txti2";
            this.txti2.Size = new System.Drawing.Size(100, 20);
            this.txti2.TabIndex = 4;
            // 
            // txti1
            // 
            this.txti1.Location = new System.Drawing.Point(179, 54);
            this.txti1.Name = "txti1";
            this.txti1.Size = new System.Drawing.Size(100, 20);
            this.txti1.TabIndex = 5;
            // 
            // txtj2
            // 
            this.txtj2.Location = new System.Drawing.Point(285, 83);
            this.txtj2.Name = "txtj2";
            this.txtj2.Size = new System.Drawing.Size(100, 20);
            this.txtj2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sayı dizisini ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMailler
            // 
            this.txtMailler.Location = new System.Drawing.Point(56, 181);
            this.txtMailler.Multiline = true;
            this.txtMailler.Name = "txtMailler";
            this.txtMailler.Size = new System.Drawing.Size(100, 118);
            this.txtMailler.TabIndex = 8;
            // 
            // btnMailleriAyristir
            // 
            this.btnMailleriAyristir.Location = new System.Drawing.Point(56, 305);
            this.btnMailleriAyristir.Name = "btnMailleriAyristir";
            this.btnMailleriAyristir.Size = new System.Drawing.Size(100, 23);
            this.btnMailleriAyristir.TabIndex = 10;
            this.btnMailleriAyristir.Text = "Mailleri Ayrıştır";
            this.btnMailleriAyristir.UseVisualStyleBackColor = true;
            this.btnMailleriAyristir.Click += new System.EventHandler(this.btnMailleriAyristir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMailleriAyristir);
            this.Controls.Add(this.txtMailler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtj2);
            this.Controls.Add(this.txti1);
            this.Controls.Add(this.txti2);
            this.Controls.Add(this.btniToj);
            this.Controls.Add(this.btn1Toi);
            this.Controls.Add(this.btn1To100);
            this.Controls.Add(this.lstSonuc);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.Button btn1To100;
        private System.Windows.Forms.Button btn1Toi;
        private System.Windows.Forms.Button btniToj;
        private System.Windows.Forms.TextBox txti2;
        private System.Windows.Forms.TextBox txti1;
        private System.Windows.Forms.TextBox txtj2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMailler;
        private System.Windows.Forms.Button btnMailleriAyristir;
    }
}