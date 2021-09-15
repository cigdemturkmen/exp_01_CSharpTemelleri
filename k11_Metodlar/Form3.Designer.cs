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
            this.btnRandomArray = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnDefaultDeger = new System.Windows.Forms.Button();
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
            // btnRandomArray
            // 
            this.btnRandomArray.Location = new System.Drawing.Point(523, 56);
            this.btnRandomArray.Name = "btnRandomArray";
            this.btnRandomArray.Size = new System.Drawing.Size(121, 23);
            this.btnRandomArray.TabIndex = 5;
            this.btnRandomArray.Text = "Rastgele Dizi Üret";
            this.btnRandomArray.UseVisualStyleBackColor = true;
            this.btnRandomArray.Click += new System.EventHandler(this.btnRandomArray_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(523, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(523, 132);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(121, 39);
            this.btnRef.TabIndex = 7;
            this.btnRef.Text = "Ref";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnDefaultDeger
            // 
            this.btnDefaultDeger.Location = new System.Drawing.Point(541, 244);
            this.btnDefaultDeger.Name = "btnDefaultDeger";
            this.btnDefaultDeger.Size = new System.Drawing.Size(103, 23);
            this.btnDefaultDeger.TabIndex = 8;
            this.btnDefaultDeger.Text = "Default Deger";
            this.btnDefaultDeger.UseVisualStyleBackColor = true;
            this.btnDefaultDeger.Click += new System.EventHandler(this.btnDefaultDeger_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDefaultDeger);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRandomArray);
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
        private System.Windows.Forms.Button btnRandomArray;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnDefaultDeger;
    }
}