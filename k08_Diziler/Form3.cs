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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //test test test chagnce to my form.
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            /*kullanıcı şifre oluşturmak için bir şifre girsin ve kontrol için ikinci kez aynısını girsin, kaydet butonuna bassın. Şifre ve şifre(tekrar)ının aynı olması gerekiyor. Şifre uzunluğu >= 8 ve en az 1 büyük harf, 1 küçük harf, 1 rakam ve 1 sembol içermesi gerekiyor.*/

            int uzunluk = txtSifre.Text.Length;

            char[] buyukHarfler = new char[0];
            char[] kucukHarfler = new char[0];
            int[] rakamlar = new int[0];
            char[] semboller = new char[0];
            int j = 0;

            for (var i = 'A'; i <= 'Z'; i++)
            {
                Array.Resize(ref buyukHarfler, j++);
                buyukHarfler[j] = i;
                j++;
            }

            for (char i = 'a'; i <= 'z'; i++)
            {
                Array.Resize(ref kucukHarfler, j++);
                kucukHarfler[j] = i;
                j++;
            }

            for (int i = 0; i <= 9; i++)
            {
                Array.Resize(ref rakamlar, j++);
                rakamlar[j] = i;
                j++;
            }


            for (char i = '!'; i <= '/'; i++)
            {
                Array.Resize(ref semboller, j++);
                semboller[j] = i;
                j++;

            }

            if (uzunluk < 8)
            {
                MessageBox.Show("Lütfen en az 8 karakterli bir şifre oluşturunuz.");
            }

            //if (txtSifre.Text.Contains(buyukHarfler.ToString()))
            //{
            //    MessageBox.Show("Şifreniz başarıyla kaydedilmiştir.");
            //}

            //int[] buyukHarf = 

            //if (uzunluk > 8 && txtSifre.Text.Contains(buyukHarf) && txtSifre.Text.Contains(kucukHarf) && txtSifre.Text.Contains(sembol))
            //{
            //    MessageBox.Show("Şifreniz başarıyla kaydedildi.");
            //}
            //else
            //{
            //    MessageBox.Show("Tekrar deneyin!");
            //}


        }
    }
}
