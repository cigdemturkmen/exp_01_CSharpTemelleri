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
    public partial class Form1 : Form
    {
        /*
         Metodlar
        Kod tekrarını önler. Kodların daha düzenli tutulmasın sağlar.m Metod her yerde tanımlanabiliyor(sınıf içinde!). Metodlar sadece çağırıldığı zaman çalışır.
        1.parametre almayan, geriye değer döndürmeyen metodlar
        2.parametre alan, geriye değer döndürmeyen metodlar
        3.parametre almayan, geriye değer döndüren metodlar
        4.parametre alan, geriye değer döndüren metodlar

        [access modifier] gerideğerdönmedurumu MetodAdı (varsa parametreler)
        {
          //metodun yapmasını istediğin işlemler
        }

        Eğer metod geriye değer döndürmeyecekse void ile oluşturulur. Değer döndüren bir metod ise void yerine fonksiyondan dönen verinin veri tipi yazılarak oluşturulur, örn: private int Multiply(int x, int y){}
        
        Metod isimlendirme kuralları:
        1. PascalCase ile yazılır.
        2. Başta rakam ve _ olmaz.
        3.Emir kipleri ile tanımlanırlar. (Write.., Show.., Find.. etc.)
         */

        #region Metodlar
        //1.Parametre almayan, geriye değer döndürmeyen metodlar
        private void AdSoyadYazdir()
        {
            MessageBox.Show("Rabia Nur Öztürk");
        }

        //2.Parametre alan, geriye değer döndürmeyen metodlar
        private void AdSoyadYazdir(string adSoyad)
        {
            MessageBox.Show(adSoyad); ;
        }

        private void AdSoyadYazdir(string ad, string soyad)
        {
            MessageBox.Show($"{ad} {soyad}");
        }

        //3.Parametre almayan, geriye değer döndüren metodlar. 
        //Metodun başında void değil de bir veri tipi yazıyorsa, o metot veri döndüren bir metoddur.
        private string AdSoyadGetir()
        {
            var isim = "Rabia Nur Öztürk";
            return isim;
        }

        //4.parametre alan, geriye değer döndüren metodlar
        private int Topla(int sayi1, int sayi2)
        {
            var toplam = sayi1 + sayi2;
            return toplam;
        }

        /*String 3 parametre alsın. sonuç olarak int döndürsün. Aldığı stringleri int'e çevirecek, toplayacak ve sonuc dönecek.(matematiksek olarak alacağı string değerleri int'e çevirir sonrasında mat toplayarak sonuçta gösterir)
        */

        //METOD OLUŞTURDUKTAN SONRA /// YAZ VE ŞU SUMMARY KISMMINI DOLDUR. DAHA SONRADAN METODA BAKTIĞINDA HEMEN ANLARSIN NE İŞE YARADIĞINI;
        /// <summary>
        /// Fonksiyon ne yapar onun açıklaması
        /// </summary>
        /// <param name="x">parametre tipi</param>
        /// <param name="y">parametre tipi</param>
        /// <param name="z">parametre tipi</param>
        /// <returns>ne döndürür</returns>
        private int Topla(string x, string y, string z) //int burada metdun döndüğü değerin veri tipidir.
        {
            try
            {
                var sayi1 = Convert.ToInt32(x);
                var sayi2 = Convert.ToInt32(y);
                var sayi3 = Convert.ToInt32(z);

                var toplam = sayi1 + sayi2 + sayi3;
                return toplam;
            }
            catch (Exception)
            {
                MessageBox.Show("Sayisal veriler giriniz");
                throw; //Bunu yorum satırına alırsan fonksiyon hata verir. Throw da bir return tipidir.
            }
        }
        #endregion

        public Form1() //constructure içinden de metodlarımı çağırabilirim. çünkü bu cnstr aynı class'ın içinde.
        {
            InitializeComponent();
            AdSoyadYazdir(); //button click eventin içinde de kullanabilirdin.
            AdSoyadYazdir("Leyla");
            AdSoyadYazdir("Leyla", "Taş");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            AdSoyadYazdir(txtAd.Text, txtSoyad.Text);
        }

        private void btnIsimYazdir_Click(object sender, EventArgs e)
        {
            AdSoyadGetir();
            MessageBox.Show(AdSoyadGetir());
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1);
            int sayi2 = Convert.ToInt32(txtSayi2);
            var toplam = Topla(sayi1, sayi2);
            MessageBox.Show(toplam.ToString());
        }
    }
}
