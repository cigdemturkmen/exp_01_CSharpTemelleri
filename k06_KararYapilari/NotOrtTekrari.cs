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

            //olası hatalar: negatif değer girebilir. 100 üstü bir değer girebilir. harf girebilir.

            
            try
            {
                var girilenVize = txtVize.Text;
                var girilenFinal = txtFinal.Text;

                double vize = Convert.ToDouble(girilenVize);
                double final = Convert.ToDouble(girilenFinal);

                double dAvarage = (vize * 0.30 + final * 0.70);
                string avarage = Convert.ToString(dAvarage);

                if (dAvarage < 30)
                {
                    lblNotOrtalamasi.Text = avarage;
                    lblHarfNotu.Text = "FF";
                    lblDurum.Text = "Kaldı";
                }
                else if (dAvarage >= 30 && dAvarage < 50)
                {
                    lblNotOrtalamasi.Text = avarage;
                    lblHarfNotu.Text = "DD";
                    lblDurum.Text = "Kaldınız";
                }

                else if (dAvarage >= 50 && dAvarage < 60)
                {
                    lblNotOrtalamasi.Text = avarage;
                    lblHarfNotu.Text = "CC";
                    lblDurum.Text = "Geçtiniz";
                }

                else if (dAvarage >= 60 && dAvarage < 85)
                {
                    lblNotOrtalamasi.Text = avarage;
                    lblHarfNotu.Text = "BB";
                    lblDurum.Text = "Geçtiniz";
                }

                else if (dAvarage >= 85 && dAvarage <= 100)
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
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen bir sayı giriniz");
            }
        }

      
    }
}
