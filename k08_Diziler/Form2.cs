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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //Dizi tanımlayıp dizinin elemanlarını hem tek tek hem de tek seferde listeye ekleyelim
            /*****AddRange kullanımı*****/

            //an easy rule: array.Length = son index + 1

            string[] iller = { "Ankara", "Eskişehir", "Adana", "Erzincan", "Nevşehir", "Trabzon", "Niğde" };

            //TEK TEK EKLEME1(genelde indexe ihtiyaç olduğu zaman for kullanılır):
            for (int i = 0; i < iller.Length; i++)
            {
                lstSonuc.Items.Add(iller[i]);
            }

            //TEK TEK EKLEME2:
            foreach (var item in iller)
            {
                lstSonuc.Items.Add(item);
            }

            //tek seferde tüm diziyi BİR ANDA eklemek için;
            lstSonuc.Items.AddRange(iller);


            //PARDON DA! TEK TEK EKLEMEK DİYE ŞUNA DENİR;
            //for (int i = 0; i < iller.Length; i++)
            //{
            //    if (!lstSonuc.Items.Contains(iller[i]))
            //    {
            //        lstSonuc.Items.Add(iller[i]);
            //        return;
            //    }
            //}
            //MessageBox.Show("Dizinin tüm elemanları eklendi.");
        }

        private void btnCifleriEkle_Click(object sender, EventArgs e)
        {
            //1'den 10a kadar dizi oluştur. Sonrasında bir listeye çift olan sayıları ekle diğerine tekleri ekle.

            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var item in sayilar)
            {
                if (item % 2 == 1)
                {
                    lstTek.Items.Add(item);
                }
                else
                {
                    lstCift.Items.Add(item);
                }
            }
        }

        private void btn20ekle_Click(object sender, EventArgs e)
        {
            //***20 elemanlı boş bir dizi oluştur. Sonrasında 1'den 20'ye kadar olan sayıları diziye ekle. Sonra dizi elemanlarının hepsini lstSonuc listesinde göster.

            int[] sayilar = new int[20]; //sayilar[0] = x

            for (int i = 0; i < 20; i++) //boş bir dizinin içini doldururken for kullanıyoruz.
            {
                sayilar[i] = i + 1;
            }

            //lstSonuc.Items.AddRange(sayilar); // bu kod çalışmadı. Halbuki yukarıdaki string dizinde çalışmıştı... ???!!!


            foreach (var sayi in sayilar)
            {
                lstSonuc.Items.Add(sayi);
            }
        }




        /*******************************************bool için default değer = false. int, byte, short,long için default değer = 0. float,double, decimal için default değer = 0.0. String için default değer = null *******************************************/




        private void btnDizeninSonElemani_Click(object sender, EventArgs e)
        {
            //iller dizisini tanımla, 5 il ekle, son elemanı seçip messageboxta göster.

            string[] iller = { "Ankara", "İzmir", "Diyarbakır", "Adana", "İstanbul" };

            MessageBox.Show(iller[iller.Length - 1]);
        }


        string[] isimler = { "Leyla", "Yasemin", "Bahar", "Ömer", "Serdar", "Orkun", "Eray", "Batuhan", "Çiğdem", "Mustafa", "Mert" };

        private void btnRastgeleEleman_Click(object sender, EventArgs e)
        {
            /*global olarak isimler dizisi oluştur(class'ın içinde; clickeventlerin içinde değil). Sonra butona her basıldığında rastgele bir index seçsin ve bu indexteki isim listbox'a eklensin. Bir eklenen isim bir daha eklenmesin ve tüm isimler bitince mb'da uyarı versin*/

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, isimler.Length);

            if (lstSonuc.Items.Contains(isimler[randomIndex]) == false)
            {
                lstSonuc.Items.Add(isimler[randomIndex]);
            }

            if (lstSonuc.Items.Count == isimler.Length)
            {
                btnRastgeleEleman.Enabled = false; //tüm elemanlar eklenince butonun inaktif hale gelmesi için.
                MessageBox.Show("Ekleyecek eleman kalmadı!");
            }
        }

        
        private void btnTopla_Click(object sender, EventArgs e)
        {
            /*sayılar dizisi oluşturalım en az 7 tane sayı eklensin(rastgele sayılar oluşturulsun). Sonra butona basıldığında dizideki elemanları listeye ekle ve eklenenlerin toplamı formun başlığında gösterilsin.*/
            Random rnd = new Random(); //instance: nesneden kopya almak demektir.
            var sayilar1 = new int[7];

            for (int i = 0; i < sayilar1.Length; i++)
            {
                int rastgeleSayi = rnd.Next(1, 101);
                sayilar1[i] = rastgeleSayi;
            }

            var toplam = 0;

            foreach (var item in sayilar1)
            {
                lstSonuc.Items.Add(item);
                toplam += item;
            }

            this.Text = toplam.ToString(); //this içinde bulunduğunuz sınıfı temsil eder. yani burada form2'yi temsil eder. this.Text = toplam -> formun başlığı demek.
        }

        private void btnSesliSessiz_Click(object sender, EventArgs e)
        {
            /*textboxta yazılan metni alıp sesli ve sessiz harflerini labellarda gösterelim.
            8 tane sesli harfi tanımladıktan sonra metnin her bir harfini tek tek inceleriz. eğer gelen harf sesliHarfler dizisinde yer alıyorsa sesli almıyorsa sessiz label'ına eklenir.*/
            //string: karakterler dizisidir.

            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            string girilen = txtSesliSessiz.Text;

            if (string.IsNullOrEmpty(txtSesliSessiz.Text))
            {
                MessageBox.Show("Lütfen bir şeyler yazıp tekrar deneyiniz");
            }

            foreach (char harf in girilen)
            {
                if (sesliHarfler.Contains(harf))
                {
                    lblSesliler.Text += harf.ToString().ToLower();
                }

                else
                {
                    lblSessizler.Text += harf.ToString().ToLower();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstSonuc.Items.Clear();
        }
    }
}
