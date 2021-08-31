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

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            var vize = txtVize.Text;
            double dblVize = Convert.ToDouble(vize);
            var final = txtFinal.Text;
            double dblFinal = Convert.ToDouble(final);
            var ortalama = (dblVize * 0.30) + (dblFinal * 0.70);
            string strOrtalama = Convert.ToString(ortalama);

            if (ortalama <=30)
            {
                MessageBox.Show($"Not ortalamanız: {strOrtalama}. Notunuz FF. Kaldınız");
            }
            else if (ortalama > 30 && ortalama < 50)
            {
                MessageBox.Show($"Not ortalamanız: {strOrtalama}. Notunuz DD. Kaldınız");
            }
            else if (ortalama>=50 && ortalama<60 )
            {
                MessageBox.Show($"Not ortalamanız: {strOrtalama}. Notunuz CC. Geçtiniz");
            }
            else if (ortalama >= 60 && ortalama <= 100)
            {
                MessageBox.Show($"Not ortalamanız: {strOrtalama}. Notunuz AA. Geçtiniz");
            }
        }
    }
}
