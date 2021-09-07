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
            this.btnDizeninSonElemani = new System.Windows.Forms.Button();
            this.btnRastgeleEleman = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnSesliSessiz = new System.Windows.Forms.Button();
            this.txtSesliSessiz = new System.Windows.Forms.TextBox();
            this.lblSesli = new System.Windows.Forms.Label();
            this.lblSessiz = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Location = new System.Drawing.Point(16, 46);
            this.btnOrnek1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(271, 39);
            this.btnOrnek1.TabIndex = 0;
            this.btnOrnek1.Text = "Elemanları Listeye Ekle";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.btnOrnek1_Click);
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.ItemHeight = 16;
            this.lstSonuc.Location = new System.Drawing.Point(295, 46);
            this.lstSonuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(219, 388);
            this.lstSonuc.TabIndex = 1;
            // 
            // btnCifleriEkle
            // 
            this.btnCifleriEkle.Location = new System.Drawing.Point(16, 110);
            this.btnCifleriEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCifleriEkle.Name = "btnCifleriEkle";
            this.btnCifleriEkle.Size = new System.Drawing.Size(271, 39);
            this.btnCifleriEkle.TabIndex = 2;
            this.btnCifleriEkle.Text = "çifleri ekle";
            this.btnCifleriEkle.UseVisualStyleBackColor = true;
            this.btnCifleriEkle.Click += new System.EventHandler(this.btnCifleriEkle_Click);
            // 
            // lstTek
            // 
            this.lstTek.FormattingEnabled = true;
            this.lstTek.ItemHeight = 16;
            this.lstTek.Location = new System.Drawing.Point(16, 174);
            this.lstTek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTek.Name = "lstTek";
            this.lstTek.Size = new System.Drawing.Size(76, 116);
            this.lstTek.TabIndex = 3;
            // 
            // lstCift
            // 
            this.lstCift.FormattingEnabled = true;
            this.lstCift.ItemHeight = 16;
            this.lstCift.Location = new System.Drawing.Point(101, 174);
            this.lstCift.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCift.Name = "lstCift";
            this.lstCift.Size = new System.Drawing.Size(77, 116);
            this.lstCift.TabIndex = 4;
            // 
            // btn20ekle
            // 
            this.btn20ekle.Location = new System.Drawing.Point(16, 298);
            this.btn20ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn20ekle.Name = "btn20ekle";
            this.btn20ekle.Size = new System.Drawing.Size(271, 38);
            this.btn20ekle.TabIndex = 5;
            this.btn20ekle.Text = "1\'den 20\'ye kadar sayıları ekle";
            this.btn20ekle.UseVisualStyleBackColor = true;
            this.btn20ekle.Click += new System.EventHandler(this.btn20ekle_Click);
            // 
            // btnDizeninSonElemani
            // 
            this.btnDizeninSonElemani.Location = new System.Drawing.Point(16, 343);
            this.btnDizeninSonElemani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDizeninSonElemani.Name = "btnDizeninSonElemani";
            this.btnDizeninSonElemani.Size = new System.Drawing.Size(271, 28);
            this.btnDizeninSonElemani.TabIndex = 6;
            this.btnDizeninSonElemani.Text = "Dizenin son elemanını al";
            this.btnDizeninSonElemani.UseVisualStyleBackColor = true;
            this.btnDizeninSonElemani.Click += new System.EventHandler(this.btnDizeninSonElemani_Click);
            // 
            // btnRastgeleEleman
            // 
            this.btnRastgeleEleman.Location = new System.Drawing.Point(16, 379);
            this.btnRastgeleEleman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRastgeleEleman.Name = "btnRastgeleEleman";
            this.btnRastgeleEleman.Size = new System.Drawing.Size(271, 28);
            this.btnRastgeleEleman.TabIndex = 7;
            this.btnRastgeleEleman.Text = "Rastgele Eleman Ekle";
            this.btnRastgeleEleman.UseVisualStyleBackColor = true;
            this.btnRastgeleEleman.Click += new System.EventHandler(this.btnRastgeleEleman_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(16, 415);
            this.btnTopla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(271, 28);
            this.btnTopla.TabIndex = 8;
            this.btnTopla.Text = "Dizideki elemanları topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnSesliSessiz
            // 
            this.btnSesliSessiz.Location = new System.Drawing.Point(649, 162);
            this.btnSesliSessiz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSesliSessiz.Name = "btnSesliSessiz";
            this.btnSesliSessiz.Size = new System.Drawing.Size(241, 28);
            this.btnSesliSessiz.TabIndex = 9;
            this.btnSesliSessiz.Text = "Sesli ce sessiz harfleri ayır";
            this.btnSesliSessiz.UseVisualStyleBackColor = true;
            this.btnSesliSessiz.Click += new System.EventHandler(this.btnSesliSessiz_Click);
            // 
            // txtSesliSessiz
            // 
            this.txtSesliSessiz.Location = new System.Drawing.Point(649, 130);
            this.txtSesliSessiz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSesliSessiz.Name = "txtSesliSessiz";
            this.txtSesliSessiz.Size = new System.Drawing.Size(240, 22);
            this.txtSesliSessiz.TabIndex = 10;
            // 
            // lblSesli
            // 
            this.lblSesli.AutoSize = true;
            this.lblSesli.Location = new System.Drawing.Point(660, 230);
            this.lblSesli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSesli.Name = "lblSesli";
            this.lblSesli.Size = new System.Drawing.Size(83, 17);
            this.lblSesli.TabIndex = 11;
            this.lblSesli.Text = "Sesli harfler";
            // 
            // lblSessiz
            // 
            this.lblSessiz.AutoSize = true;
            this.lblSessiz.Location = new System.Drawing.Point(660, 274);
            this.lblSessiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSessiz.Name = "lblSessiz";
            this.lblSessiz.Size = new System.Drawing.Size(94, 17);
            this.lblSessiz.TabIndex = 12;
            this.lblSessiz.Text = "Sessiz harfler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(767, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(760, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSessiz);
            this.Controls.Add(this.lblSesli);
            this.Controls.Add(this.txtSesliSessiz);
            this.Controls.Add(this.btnSesliSessiz);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.btnRastgeleEleman);
            this.Controls.Add(this.btnDizeninSonElemani);
            this.Controls.Add(this.btn20ekle);
            this.Controls.Add(this.lstCift);
            this.Controls.Add(this.lstTek);
            this.Controls.Add(this.btnCifleriEkle);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.btnOrnek1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.Button btnCifleriEkle;
        private System.Windows.Forms.ListBox lstTek;
        private System.Windows.Forms.ListBox lstCift;
        private System.Windows.Forms.Button btn20ekle;
        private System.Windows.Forms.Button btnDizeninSonElemani;
        private System.Windows.Forms.Button btnRastgeleEleman;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnSesliSessiz;
        private System.Windows.Forms.TextBox txtSesliSessiz;
        private System.Windows.Forms.Label lblSesli;
        private System.Windows.Forms.Label lblSessiz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}