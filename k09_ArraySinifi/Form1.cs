using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k09_ArraySinifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Array Sınıfı: dizilerle ilgili bazı işlemleri(kopyalama, yeniden boyutlandırma, sıralama vb) yapmamıza yardımcı olan metodları içerir.*/
        }

        string[] isimler = { "ömer", "leyla", "batuhan", "çiğdem", "bahar", "serdar", "orkun", "batuhan", "anıl", "mustafa", "utku", "yasemin", "eray", "kaan", "mert" };
        private void btnCopy_Click(object sender, EventArgs e)
        {
            //copy
            /*bu sınıftaki tüm öğrencilerin isimlerini bir dizi olarak tanımlayınız ve sonrasında online katılımcılar ve fiziksel katılımcılar isimli iki dizi yaparak buraya kopyalayınız.*/

            string[] fizikselKatilimcilar = new string[9];

            Array.Copy(isimler, fizikselKatilimcilar, 9);

            foreach (var item in fizikselKatilimcilar)
            {
                listBox1.Items.AddRange(fizikselKatilimcilar);
            }

            string[] onlineKatilimcilar = new string[6];
            Array.Copy(isimler, 9, onlineKatilimcilar, 0,6);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //isimlerde 2. indeksten başlayarak 3 elemanı sil(null ata)
            Array.Clear(isimler, 2, 3);

        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            //aradığınız eleman dizi içinde geçmiyorsa -1 döner.
            //aranılan değeri ilk bulduğu indexi döner.
            Array.IndexOf(isimler, "çiğdem");

            var bulunanIndex = Array.IndexOf(isimler, "çiğdem");

            if (bulunanIndex != -1)
            {
                MessageBox.Show($"Aradığınız isim {bulunanIndex}");
            }
            else
            {
                MessageBox.Show("Böyle bir eleman yok");
            }


        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            Array.LastIndexOf(isimler, "çiğdem");

            var bulunanIndex = Array.IndexOf(isimler, "çiğdem");

            if (bulunanIndex != -1)
            {
                MessageBox.Show($"Aradığınız isim {bulunanIndex}");
            }
            else
            {
                MessageBox.Show("Böyle bir eleman yok");
            }


        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            //reverse diziyi ters çevirir.
            Array.Reverse(isimler);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //a'dan z'ye veya 0'dan 9'a artan sıralama yapar

            Array.Sort(isimler);
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            //yeniden boyutlandırma yapar.
            Array.Resize(ref isimler, 20);
        }
    }
}
