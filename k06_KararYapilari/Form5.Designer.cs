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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "mevsim gir";
            // 
            // txtMevsim
            // 
            this.txtMevsim.Location = new System.Drawing.Point(12, 42);
            this.txtMevsim.Name = "txtMevsim";
            this.txtMevsim.Size = new System.Drawing.Size(100, 20);
            this.txtMevsim.TabIndex = 1;
            // 
            // btnAylariGetir
            // 
            this.btnAylariGetir.Location = new System.Drawing.Point(23, 68);
            this.btnAylariGetir.Name = "btnAylariGetir";
            this.btnAylariGetir.Size = new System.Drawing.Size(75, 23);
            this.btnAylariGetir.TabIndex = 2;
            this.btnAylariGetir.Text = "Ayları Getir";
            this.btnAylariGetir.UseVisualStyleBackColor = true;
            this.btnAylariGetir.Click += new System.EventHandler(this.btnAylariGetir_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAylariGetir);
            this.Controls.Add(this.txtMevsim);
            this.Controls.Add(this.label1);
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
    }
}