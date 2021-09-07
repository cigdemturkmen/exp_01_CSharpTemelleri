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
    public partial class DersTekrarı : Form
    {
        public DersTekrarı()
        {
            InitializeComponent();
        }

        private void DersTekrarı_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1'den 10a kadar dizi oluştur. sonrasında bir listeye çift olan sayıları ekle diğerine tekleri ekle.

            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    listBox1.Items.Add(sayi);
                }
                else
                {
                    listBox2.Items.Add(sayi);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //***20 elemanlı boş bir dizi oluştur.sonrasında 1'den 20ye sayıları diziye ekle. sonra dizi elemanlarının hepsini lstSonuc listesinde göster

            int[] sayilar = new int[20];

            //sayilar[0] = x

            for (int i = 0; i < 20; i++)
            {
                sayilar[i] = i + 1;
            }

            //listBox1.Items.AddRange(sayilar); // bu kod çalışmadı.

            foreach (var sayi in sayilar)
            {
                listBox1.Items.Add(sayi);
            }
        }

  
        string[] isimler = new string[] { "ayşe", "fatma", "hatice", "nur", "kemal", "ege", "sare", "özlem", "ümit", "alpcan" };
        private void btnRastgeleIsimler_Click(object sender, EventArgs e)
        {
            /*global olarak isimler dizisi oluştur(class'ın içinde; clickeventlerin içinde değil). sonra butona her basıldığında rastgele bir index seçsin ve bu indexteki isim listbox'a eklensin. bir eklenen isim bir daha eklenmesin ve tüm isimler bitince mb'da uyarı versin*/

            Random rnd = new Random();

            //while (listBox1.Items.Count < isimler.Length+1)
            //{
            //    int randomNumber = rnd.Next(1, isimler.Length);
            //    if (listBox1.Items.Contains(isim) == false)
            //    {
            //        listBox1.Items.Add(isimler[randomNumber]);
            //    }

            //}
            //foreach (var isim in isimler)
            //{
            //    int randomNumber = rnd.Next(1, isimler.Length);
            //    if (listBox1.Items.Contains(isim) == false)
            //    {
            //        listBox1.Items.Add(isimler[randomNumber]);
            //    }
               
            //}

            //MessageBox.Show("Tüm isimler eklendi.");



        }
    }
}
