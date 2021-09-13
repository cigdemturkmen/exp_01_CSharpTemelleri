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
    public partial class NotHesaplama : Form
    {
        public NotHesaplama()
        {
            InitializeComponent();
        }

        private void NotHesaplama_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double dblVize = Convert.ToDouble(txtVize.Text);
                double dblFinal = Convert.ToDouble(txtFinal.Text);

                var ortalama = (dblVize * 0.30) + (dblFinal * 0.70);
                string strOrtalama = Convert.ToString(ortalama);

                if (dblVize>100 || dblFinal>100 || dblVize<0 || dblFinal<0)
                {
                    MessageBox.Show("Lütfen 0 ile 100 arasında geçerli bir not giriniz.");
                    return;
                }

                if (ortalama <= 30)
                {
                    MessageBox.Show($"Not ortalamanız: {strOrtalama}. Notunuz FF. Kaldınız");
                }
                else if (ortalama > 30 && ortalama < 50)
                {
                    MessageBox.Show($"Not ortalamanız: {strOrtalama}. Notunuz DD. Kaldınız");
                }
                else if (ortalama >= 50 && ortalama < 60)
                {
                    MessageBox.Show($"Not ortalamanız: {strOrtalama}. Notunuz CC. Geçtiniz");
                }
                else if (ortalama >= 60 && ortalama < 80)
                {
                    MessageBox.Show($"Not ortalamanız: {strOrtalama}. Notunuz BB. Geçtiniz");
                }
                else if (ortalama >= 80 && ortalama <= 100)
                {
                    MessageBox.Show($"Not ortalamanız: {strOrtalama}. Notunuz AA. Geçtiniz");
                }
                txtVize.Text = "";
                txtFinal.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen vize ve final notları için geçerli sayılar giriniz.");
                
            }
        }
    }
}
