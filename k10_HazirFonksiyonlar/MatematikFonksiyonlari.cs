using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k10_HazirFonksiyonlar
{
    public partial class MatematikFonksiyonlari : Form
    {
        /*Matematik Fonksiyonları
         Math kütühanesi içinde yer alan metodları inceleyelim.*/
        public MatematikFonksiyonlari()
        {
            InitializeComponent();
        }

        private void MatematikFonksiyonlari_Load(object sender, EventArgs e)
        {

        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            //pi sayısını alalım
           var piSayisi = Math.PI;

            //kullanıdan alınan bir yarıçapa göre dairenin alanını hesaplayiniz.

            double yariCap = Convert.ToDouble(txtYariCap.Text);

            var alan = piSayisi * yariCap * yariCap;

            MessageBox.Show(alan.ToString());
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            //mutlak değer
            var mutlakDeger = Math.Abs(-143);
            var md1 = Math.Abs(-1.143);
            txtSonuc.Text = mutlakDeger.ToString();
        }

        //Math.Ceiling(1.23m);  Math.Floor(1.55);  Math.Round(3.8);
        //Math.Round(43.122765, 2); sonuç= 43.12

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            //virgüllü sayının tam kısmını almak için kullanılır. ondalıklı kısmı boşaltır.
            var sayi = Math.Truncate(43.45679); //sonuç = 43
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //işaretli sayılar için (+,-) negatifse -1 döner pozitifse 1 ve 0 ise 0 değeri gelir.

            var sayi = Math.Sign(-23);
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            var sonuc = Math.Pow(2, 4); //2 üzeri 4

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            var sonuc = Math.Sqrt(25); //square root

        }

        //Math.Min(10, 2); sonuç 2 -- Math.Max(10, 2); sonuç 10

        private void button2_Click(object sender, EventArgs e)
        {
            //en büyük sayıyı buldur. 
            //TODO min max ile yapacaktın!
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int sayi3 = Convert.ToInt32(txtSayi3.Text);

            if (sayi1 > sayi2 && sayi1 > sayi2)
            {
                MessageBox.Show($"En üyük sayı {txtSayi1.Text}");
            }
            else if (sayi2 > sayi3)
            {
                MessageBox.Show($"En üyük sayı {txtSayi2.Text}");
            }
            else
            {
                MessageBox.Show($"En üyük sayı {txtSayi3.Text}");
            }
        }
    }
}
