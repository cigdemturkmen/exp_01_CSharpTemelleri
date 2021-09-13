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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        //if ve switch case ile mevsimler ve aylar. switchde case birleştirme(if'le ayrı ayrı yapılırken, switch-case'te tek blokta kodlayabiliriz.

        private void btnAylariGetir_Click(object sender, EventArgs e)
        {
            //Girilen ay'a göre, aylar hangi mevsime denk gelir gösterelim

            var girilenMevsim = txtMevsim.Text.ToLower();
            string aylar;
            //Bu gösterim, şunun kısaltılmış halidir: string aylar = "";
            /***Değeri boş olan bir değişkenin şu gösteriminde "var" keywordünü kullanamıyoruz: var aylar; yazamayız(data type'ı yazmalısın var yerine)***/

            switch (girilenMevsim)
            {
                case "kış":
                    aylar = "Aralık, Ocak, Şubat";
                    break;
                case "ilkbahar":
                    aylar = "Mart, Nisan, Mayıs";
                    break;
                case "yaz":
                    aylar = "Haziran, Temmuz, Ağustos";
                    break;
                case "sonbahar":
                    aylar = "Eylül, Ekim, Kasım";
                    break;
                default: //case'lerdekinden farklı bir veri girildiyse veya NULL ise burası çalışır. NULL ise : bir değer girilmediyse...
                    aylar = "Geçerli bir mevsim giriniz";
                    break;
            }

            MessageBox.Show(aylar);
        }

        private void BtnMevsimAdi_Click(object sender, EventArgs e)
        {
            //Girilen ay ismine göre hangi mevsimde olduğumuzu mesaj kutusunda göster

            string girilenAy = txtAyAdi.Text.ToLower();
            string mevsim;

            //if (girilenAy == "aralık" || girilenAy == "ocak" || girilenAy == "şubat")
            //{
            //    mevsim = "kış";
            //    MessageBox.Show($"Mevsim {mevsim} mevsimidir.");
            //}

            //else if (girilenAy == "mart" || girilenAy == "nisan" || girilenAy == "mayıs")
            //{
            //    mevsim = "ilkbahar";
            //    MessageBox.Show($"Mevsim {mevsim} mevsimidir.");
            //}
            //else if (girilenAy == "haziran" || girilenAy == "temmuz" || girilenAy == "ağustos")
            //{
            //    mevsim = "yaz";
            //    MessageBox.Show($"Mevsim {mevsim} mevsimidir.");
            //}

            //else if (girilenAy == "eylül" || girilenAy == "ekim" || girilenAy == "kasım")
            //{
            //    mevsim = "sonbahar";
            //    MessageBox.Show($"Mevsim {mevsim} mevsimidir.");
            //}

            //else
            //{
            //    MessageBox.Show("Geçerli bir ay giriniz!");
            //}

            //VEYA BURDA: MessageBox.Show($"Mevsim {mevsim} mevsimidirR."); 

            switch (girilenAy)
            {
                case "aralık":
                case "ocak":
                case "şubat":
                    mevsim = "kış";
                    break;
                case "mart":
                case "nisan":
                case "mayıs":
                    mevsim = "ilkbahar";
                    break;
                case "haziran":
                case "temmuz":
                case "ağustos":
                    mevsim = "yaz";
                    break;
                case "eylül":
                case "ekim":
                case "kasım":
                    mevsim = "sonbahar";
                    break;
                default:
                    MessageBox.Show("Geçerli bir ay giriniz.");
                    return;
            }
            MessageBox.Show($"Mevsim {mevsim} mevsimidir.");

        }
    }
}


