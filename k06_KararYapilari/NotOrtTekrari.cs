using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k06_KararYapilari
{
    public partial class NotOrtTekrari : Form
    {
        public NotOrtTekrari()
        {
            InitializeComponent();
        }

        private void NotOrtTekrari_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            
            try
            {
                var girilenVize = txtVize.Text;
                var girilenFinal = txtFinal.Text;

                double vize = Convert.ToDouble(girilenVize);
                double final = Convert.ToDouble(girilenFinal);

                double dAvarage = (vize * 0.30 + final * 0.70);
                string avarage = Convert.ToString(dAvarage);

                if (vize < 30)
                {
                    lblNotOrtalamasi.Text = avarage;
                    lblHarfNotu.Text = "FF";
                    lblDurum.Text = "Kaldı";
                }
                else if (vize >= 30 && vize < 50)
                {
                    lblNotOrtalamasi.Text = avarage;
                    lblHarfNotu.Text = "DD";
                    lblDurum.Text = "Kaldınız";
                }

                else if (vize >= 50 && vize < 60)
                {
                    lblNotOrtalamasi.Text = avarage;
                    lblHarfNotu.Text = "CC";
                    lblDurum.Text = "Geçtiniz";
                }

                else if (vize >= 60 && vize < 85)
                {
                    lblNotOrtalamasi.Text = avarage;
                    lblHarfNotu.Text = "BB";
                    lblDurum.Text = "Geçtiniz";
                }

                else if (vize >= 85 && vize <= 100)
                {
                    lblNotOrtalamasi.Text = avarage;
                    lblHarfNotu.Text = "AA";
                    lblDurum.Text = "Geçtiniz";
                }

                else
                {
                    MessageBox.Show("Lütfen 0 ve 100 arasında bir değer giriniz");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir sayı giriniz");
            }
        }

        
    }
}
