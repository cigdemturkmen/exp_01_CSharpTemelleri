namespace k06_KararYapilari
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTikla = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnSayi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTekCift = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bir isim giriniz.";
            // 
            // btnTikla
            // 
            this.btnTikla.Location = new System.Drawing.Point(124, 129);
            this.btnTikla.Name = "btnTikla";
            this.btnTikla.Size = new System.Drawing.Size(75, 23);
            this.btnTikla.TabIndex = 2;
            this.btnTikla.Text = "Tıklayınız";
            this.btnTikla.UseVisualStyleBackColor = true;
            this.btnTikla.Click += new System.EventHandler(this.btnTikla_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(424, 86);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(216, 20);
            this.txtSayi.TabIndex = 3;
            // 
            // btnSayi
            // 
            this.btnSayi.Location = new System.Drawing.Point(424, 112);
            this.btnSayi.Name = "btnSayi";
            this.btnSayi.Size = new System.Drawing.Size(216, 30);
            this.btnSayi.TabIndex = 4;
            this.btnSayi.Text = "geçti/kaldı";
            this.btnSayi.UseVisualStyleBackColor = true;
            this.btnSayi.Click += new System.EventHandler(this.btnSayi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTekCift
            // 
            this.txtTekCift.Location = new System.Drawing.Point(520, 287);
            this.txtTekCift.Name = "txtTekCift";
            this.txtTekCift.Size = new System.Drawing.Size(100, 20);
            this.txtTekCift.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bir sayi giriniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTekCift);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSayi);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnTikla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTikla;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnSayi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTekCift;
        private System.Windows.Forms.Label label2;
    }
}

