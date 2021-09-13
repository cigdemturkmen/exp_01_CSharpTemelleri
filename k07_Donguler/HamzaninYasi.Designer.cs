
namespace k07_Donguler
{
    partial class HamzaninYasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HamzaninYasi));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtGunluk = new System.Windows.Forms.TextBox();
            this.txtHaftalik = new System.Windows.Forms.TextBox();
            this.txtAylik = new System.Windows.Forms.TextBox();
            this.txtYillik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hamza kaç günlük?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(16, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hamza kaç haftalık?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hamza kaç aylık?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(16, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "Hamza kaç yaşında?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtGunluk
            // 
            this.txtGunluk.Location = new System.Drawing.Point(16, 83);
            this.txtGunluk.Name = "txtGunluk";
            this.txtGunluk.Size = new System.Drawing.Size(238, 22);
            this.txtGunluk.TabIndex = 4;
            // 
            // txtHaftalik
            // 
            this.txtHaftalik.Location = new System.Drawing.Point(16, 194);
            this.txtHaftalik.Name = "txtHaftalik";
            this.txtHaftalik.Size = new System.Drawing.Size(238, 22);
            this.txtHaftalik.TabIndex = 5;
            // 
            // txtAylik
            // 
            this.txtAylik.Location = new System.Drawing.Point(12, 303);
            this.txtAylik.Name = "txtAylik";
            this.txtAylik.Size = new System.Drawing.Size(242, 22);
            this.txtAylik.TabIndex = 6;
            // 
            // txtYillik
            // 
            this.txtYillik.Location = new System.Drawing.Point(16, 416);
            this.txtYillik.Name = "txtYillik";
            this.txtYillik.Size = new System.Drawing.Size(238, 22);
            this.txtYillik.TabIndex = 7;
            // 
            // HamzaninYasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.txtYillik);
            this.Controls.Add(this.txtAylik);
            this.Controls.Add(this.txtHaftalik);
            this.Controls.Add(this.txtGunluk);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "HamzaninYasi";
            this.Text = "HamzaninYasi";
            this.Load += new System.EventHandler(this.HamzaninYasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtGunluk;
        private System.Windows.Forms.TextBox txtHaftalik;
        private System.Windows.Forms.TextBox txtAylik;
        private System.Windows.Forms.TextBox txtYillik;
    }
}