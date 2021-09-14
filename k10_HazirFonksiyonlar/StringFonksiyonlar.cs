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
    public partial class StringFonksiyonlar : Form
    {
        public StringFonksiyonlar()
        {
            InitializeComponent();
            //1. sırada bu çalışır.(constructure)
        }

        private void StringFonksiyonlar_Load(object sender, EventArgs e)
        {
            //2. sırada bu çalışır. (form load event)
        }
        string ornekIfade = "bilge adam";
        private void button11_Click(object sender, EventArgs e)
        {
            /*karşılaştırma yapılan değer alfabedeki karşılaştırılan değerden sonraysa 1 değeri, aynıysa 0, değerden önceyse -1 değerini döner. */

            //Compareto: which string comes first in dictionary karşılaştırması

            var sonuc = ornekIfade.CompareTo("abilge adam"); //1
            var sonuc1 = ornekIfade.CompareTo("zbilge adam"); //-1
            var sonuc2 = ornekIfade.CompareTo("bilge adam"); //0
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            //içerme durumunu kontrol eder. cantains = true  doesnt contain = false
            var sonuc = ornekIfade.Contains("ilge");
        }

        private void btnStartWithEndWith_Click(object sender, EventArgs e)
        {
            //ternary if
            var sonuc = ornekIfade.StartsWith("bilge") ? MessageBox.Show("Bilge ile başlıyor") : MessageBox.Show("bu değerle başlamıyor");

            var sonuc1 = ornekIfade.EndsWith("adam") ? MessageBox.Show("bitiyor") : MessageBox.Show("bitmiyor");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sonuc = ornekIfade.IndexOf('a'); //6. index'te ilk a harfiyle karşılaştı
            var sonuc1 = ornekIfade.LastIndexOf("adam"); //6. index'te adam kelimesi başladı
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var sonuc = ornekIfade.Remove(4); //4. index'ten başalayıp sona kadar siler.
            var sonuc1 = ornekIfade.Remove(3, 4); //3. index'ten başlayıp 4 karakter sildi.
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            var sonuc = ornekIfade.Replace('a', 'e').Replace('e', 'ı'); //bilge edem-  ???check

            var sonuc1 = ornekIfade.Replace("adam", "kadın"); //bilge kadın
        }

        private void btnMailOlustur_Click(object sender, EventArgs e)
        {
            //ad soyad al, türkçe karakterleri çeviril mail adresi oluştur
            string adSoyad = txtAdSoyad.Text;

            string adSoyadKucuk = adSoyad.ToLower();

            var engKarakterkliAd = adSoyadKucuk.Replace('ç', 'c').Replace('ğ', 'g').Replace('ı', 'i').Replace('ö', 'o').Replace('ü', 'u').Replace('ş', 's').Replace(' ', '.');

            MessageBox.Show($"{engKarakterkliAd}@gmail.com");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ornekIfade.Insert(0, "çok "); //çok bilge adam

            ornekIfade.Insert(5, "cik");
        }

        private void btnToLowerToUpper_Click(object sender, EventArgs e)
        {
            //CultureInfo bilgisi önemli I -ı  ya da I-i
            //işletim sisteminizin dili ne ise burası default dili o algılar
            var sonuc = ornekIfade.ToLower();
            var sonuc1 = ornekIfade.ToUpper();
            var x = ornekIfade.ToLower(new System.Globalization.CultureInfo("en-US", false));
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            var sonuc = ornekIfade.Substring(5); // " adam"
            var sonuc1 = ornekIfade.Substring(6, 4); //"adam"
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            var ayrilanlar = ornekIfade.Split(' '); //"bilge", "adam" //burada çıkan sonuç bir array oluyor!!

            var metin = "merhaba, benim adım, nur";
            var ayrilanlar1 = metin.Split(',', ' '); //params //hem ,'e hem ' 'a göre ayırır.
        }

        //ÖDEV: lorem ipsum metninden belli bir kısmı textbox'a giriniz ve kaç kelimeden olş bulunuz


        private void btnToCharArray_Click(object sender, EventArgs e)
        {
            //char[] harflerDizisi = new char[0];
            //foreach (var harf in ornekIfade)
            //{
            //    Array.Resize(ref harflerDizisi, harflerDizisi.Length + 1);
            //    harflerDizisi[harflerDizisi.Length - 1] = harf;
            //}

            char[] harfler = ornekIfade.ToCharArray();
            char[] harfler2 = ornekIfade.ToCharArray(6, 4);
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            var metin = "  bilge adam  ";
            var bosluksuz = metin.Trim(); //TrimStart ve TrimEnd
        }
    }
}
