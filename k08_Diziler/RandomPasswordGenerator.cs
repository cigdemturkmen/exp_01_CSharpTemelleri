using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k08_Diziler
{
    public partial class RandomPasswordGenerator : Form
    {
        public RandomPasswordGenerator()
        {
            InitializeComponent();
        }

        private void RandomPasswordGenerator_Load(object sender, EventArgs e)
        {

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            txtSifre.Text = "";
            Random rnd = new Random();

            var rastgeleBuyuk = rnd.Next(65, 91);
            char buyukHarf = Convert.ToChar(rastgeleBuyuk);

            var rastgeleKucuk = rnd.Next(97, 123);
            char kucukHarf = Convert.ToChar(rastgeleKucuk);

            var charSembol = rnd.Next(33, 48);
            char sembol = Convert.ToChar(charSembol);

            var rakam = rnd.Next(0, 10);

            if (string.IsNullOrEmpty(txtKarakterSayisi.Text))
            {
                MessageBox.Show("Şifreniz için karakter sayısı giriniz.");
            }
            else
            {
                if (cbBuyukHarf.Checked)
                {
                    txtSifre.Text += buyukHarf.ToString();
                }
                if (cbKucukHarf.Checked)
                {
                    txtSifre.Text += kucukHarf.ToString();
                }
                if (cbSembol.Checked)
                {
                    txtSifre.Text += sembol.ToString();
                }
                if (cbRakam.Checked)
                {
                    txtSifre.Text += rakam.ToString();
                }


                string girilenKarakterSayisi = txtKarakterSayisi.Text;
                int karakterUzunlugu = Convert.ToInt32(girilenKarakterSayisi);
                var password = txtSifre.Text;

                Random rnd2 = new Random();

                for (int i = password.Length; i < karakterUzunlugu; i++)
                {
                    
                    var asciiKucukHarfler = rnd2.Next(97, 123);
                    char rastgeleharfler = Convert.ToChar(asciiKucukHarfler);
                    txtSifre.Text += rastgeleharfler.ToString();
                }
            }

            
            
           

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTest.Text))
            {
                MessageBox.Show("Bir şey gir");
            }
            else
            {
                MessageBox.Show("Aferin");
            }
        }
    }
}
