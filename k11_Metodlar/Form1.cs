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
        Kod tekrarını önler. Kodların daha düzenli tutulmasın sağlar.
        1.parametre almayan, geriye değer döndürmeyen metodlar
        2.parametre alan, geriye değer döndürmeyen metodlar
        3.parametre almayan, geriye değer döndüren metodlar
        4.parametre alan, geriye değer döndüren metodlar

        [access modifier] gerideğerdönmedurumu MetodAdı (varsa parametreler)
        {
        //metodun yapmasını ist. işlemler
        }

        eğer metod geriye değer döndürmeyecekse void ile oluşturulur.
        metod her yerde tanımlanabiliyor (sınıf içinde).
        metodlar çağırıldığı zaman çalışır.

        metod adı kuralları:
        1. PascalCase
        2. başta rakam olmaz
        3.Emir kipleri ile tanımlanırlar

         */

        #region Metodlar
        //1.parametre almayan, geriye değer döndürmeyen metodlar
        private void AdSoyadYazdir()
        {
            MessageBox.Show("Rabia Nur Öztürk"); //button click eventin içinde de kullanabilirdin.
        }

        //2.parametre alan, geriye değer döndürmeyen metodlar
        private void AdSoyadYazdir(string adSoyad)
        {
            MessageBox.Show("Rabia Nur Öztürk");
        }

        private void AdSoyadYazdir(string ad, string soyad)
        {
            MessageBox.Show($"{ad} {soyad}");
        }

        //3.parametre almayan, geriye değer döndüren metodlar. 
        //Metodun başında void değil de bir veri tipi yazıyorsa, o metod veri döndüren bir metoddur.
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

        //string 3 parametre alsın. sonuç olarak in döndürsün. aldığı stringleri int'e çevirecek topl ve sonuc dönecek
        //matematiksek olarak alacağı string değerleri int'e çevirir sonrasında mat toplayarak sonuçta gösterir

        /// <summary>
        /// Fonksiyon ne yapar onun açıklaması
        /// </summary>
        /// <param name="x">parametre tipi</param>
        /// <param name="y">parametre tipi</param>
        /// <param name="z">parametre tipi</param>
        /// <returns>ne döndürür</returns>
        private int Topla(string x, string y, string z) //int burada döndüğü değerin veri tipidir
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
                throw; //bunu yorum satırına alırsan fonksiyon hata verir. throw da bir return tipidir.
            }
            
        }


        #endregion

        public Form1()
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
