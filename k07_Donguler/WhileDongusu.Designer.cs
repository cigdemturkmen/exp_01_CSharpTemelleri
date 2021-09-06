namespace k07_Donguler
{
    partial class btnRastgele
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
            this.btnOrn1 = new System.Windows.Forms.Button();
            this.listBoxSonuc = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrn1
            // 
            this.btnOrn1.Location = new System.Drawing.Point(35, 26);
            this.btnOrn1.Name = "btnOrn1";
            this.btnOrn1.Size = new System.Drawing.Size(184, 28);
            this.btnOrn1.TabIndex = 0;
            this.btnOrn1.Text = "1den 100e sayılar";
            this.btnOrn1.UseVisualStyleBackColor = true;
            this.btnOrn1.Click += new System.EventHandler(this.btnOrn1_Click);
            // 
            // listBoxSonuc
            // 
            this.listBoxSonuc.FormattingEnabled = true;
            this.listBoxSonuc.Location = new System.Drawing.Point(242, 26);
            this.listBoxSonuc.Name = "listBoxSonuc";
            this.listBoxSonuc.Size = new System.Drawing.Size(218, 407);
            this.listBoxSonuc.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rastgele 10 Sayı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRastgele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxSonuc);
            this.Controls.Add(this.btnOrn1);
            this.Name = "btnRastgele";
            this.Text = "WhileDongusu";
            this.Load += new System.EventHandler(this.WhileDongusu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrn1;
        private System.Windows.Forms.ListBox listBoxSonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}