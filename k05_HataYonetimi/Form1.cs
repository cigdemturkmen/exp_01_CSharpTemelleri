using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k05_HataYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {

                //dışarıdan alınan sayıya ulaş.
                var girilenSayi = txtSayi.Text;
                //convert et stringten integera vs.
                var sayi = Convert.ToInt32(girilenSayi);
                //karesini al
                var karesi = sayi * sayi;
                //kullanıcıya göster
                lblSonuc.Text = karesi.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu. Bir sayı girmeyi deneyin." + ex.Message);
                //YADA___throw new Exception("Karakter girişi yapılamaz");
               
            }
            //finally 
            //{
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
