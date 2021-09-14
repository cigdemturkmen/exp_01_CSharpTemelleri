namespace k11_Metodlar
{
    partial class Form3
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
            this.btnOut = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnParams = new System.Windows.Forms.Button();
            this.txti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(47, 158);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(173, 55);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(260, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 264);
            this.listBox1.TabIndex = 1;
            // 
            // btnParams
            // 
            this.btnParams.Location = new System.Drawing.Point(47, 32);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(173, 47);
            this.btnParams.TabIndex = 2;
            this.btnParams.Text = "Params";
            this.btnParams.UseVisualStyleBackColor = true;
            // 
            // txti
            // 
            this.txti.Location = new System.Drawing.Point(47, 132);
            this.txti.Name = "txti";
            this.txti.Size = new System.Drawing.Size(173, 20);
            this.txti.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kaç tane sayı eklemek istiyorsunuz:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txti);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOut);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.TextBox txti;
        private System.Windows.Forms.Label label1;
    }
}