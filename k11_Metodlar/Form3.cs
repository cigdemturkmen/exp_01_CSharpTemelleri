using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k11_Metodlar
{
    public partial class Form3 : Form
    {
        /*
         * params
         * out
         * ref
         */
        #region Params

        private int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        private int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        private int Topla(int sayi1, int sayi2, int sayi3, int sayi4)
        {
            return sayi1 + sayi2 + sayi3 + sayi4;
        }

        //Instead of the above overloads, simply use params keyword to take as many parameters as you want

        private int Topla(params int[] sayilar)
        {
            var toplam = 0;

            foreach (var item in sayilar)
            {
                toplam += item;
            }
            return toplam;
        }
        #endregion
        #region Out
        /*Geriye değer döndürmeyen metodlardan bir değer taşımak için kullanılır veya geriye değer döndüren metodlardan döndürülen değer dışında ekstra bir bilgi taşımak istediğimiz durumlarda kullandığımız anahtar kelimedir.*/

        private void RandomSayiUret(int girilenSayi, out int donusSayisi) //DateTime TryParse böyle...
        {
            Random rnd = new Random();
            int sayac = 0;

            for (int i = 0; i < girilenSayi; i++) //while kullanırsan aynı sayılar gelse bile belirttiğin miktar kadar sayı yazdırabilirsin. for ile bunu yapamazsın. 
            {
                var randomSayi = rnd.Next(1, 101);
                if (!listBox1.Items.Contains(randomSayi))
                {
                    listBox1.Items.Add(randomSayi);
                }
                sayac++;
            }
            donusSayisi = sayac;
        }

        /// <summary>
        /// 1-100 arasında kullanıcının ist. kadar sayı üretip dizi olarak geri döndürür
        /// </summary>
        /// <param name="uretilecekRastgeleSayi"></param>
        /// <param name="donusSayisi"></param>
        /// <returns></returns>
        private int[] rastgeleSayilarUret(int uretilecekRastgeleSayi, out int donusSayisi)
        {
            var sayilar = new int[0];
            Random rnd = new Random();
            int sayac = 0;
            while (sayilar.Length < uretilecekRastgeleSayi)
            {
                
                var rastgeleSayi = rnd.Next(1, 100);
                if (!sayilar.Contains(rastgeleSayi))
                {
                    Array.Resize(ref sayilar, sayilar.Length + 1); //int'de default değer 0'dır.
                    sayilar[sayilar.Length - 1] = rastgeleSayi;
                }
                sayac++;
            }
            donusSayisi = sayac;
            return sayilar; //return'den sonra yazılan hiçbir şey çalışmaz, unutma.
        }
        #endregion

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            //random sayı üreterek lisboxa bu sayıları ekleyen bir metod yazınız.
            //kaç tane random sayı üretmek istediğimizi kullanıcıya soralım
            //listbox'a daha önce eklenen bir sayı bir daha eklenmesin
            //RandomSayiUret(10)
            int donguKacKezDondu = 0; //out kullanımı için yaptık.
            var girdi = Convert.ToInt32(txti.Text);
            RandomSayiUret(girdi, out donguKacKezDondu);
            this.Text = donguKacKezDondu.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO bunu sil sonra
        }

        private void btnRandomArray_Click(object sender, EventArgs e)
        {
            int girdi = Convert.ToInt32(txti.Text);
            int kacKezDondu = 0;
            var sayilar = rastgeleSayilarUret(girdi, out kacKezDondu);

            foreach (var item in sayilar)
            {
                comboBox1.Items.Add(item);
            }
            
            MessageBox.Show($"Ddl'deki elemanları üretmek için döngü {kacKezDondu} kez döndü.");
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            /* ref: metodlara parametre geçtiğiniz zaman, ana değişken üzerinden bir değişiklik olmaz çünkü metodlara gönderilen parametreler için kopya oluşturulur. ref deyince referansını değil de kendisini metodun içine yolladığını düşün. içeride nasıl değişirse, asıl değer de değişir.*/
        }

        private double UstAl(int sayi, int ust = 2) //ust değişkenine default olarak 2 değerini atadık.
        {
            return Math.Pow(sayi, ust);
        }
        private void btnDefaultDeger_Click(object sender, EventArgs e)
        {
            //metotların parametrelerini opsiyonel yapmak isteyebilirsiniz, bu durumda o parametre boş geçilirse default olarak bir değer vermeniz gerekir.
            //value type'lar normalde default değeri ile ram'de oluşturulurlar. örn: int sayi; (int sayi, int? ust = 2)
            //? yazıldığında o değere null geçilebileceğini anlatır.

            //TODO bunun örneğini yaz
        }
    }
}
