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
            //dizi tanımlayıp dizinin elemanları hem tek tek hem de tek seferde listeye ekleyelim

            string[] iller = { "Ankara", "Eskişehir", "Adana", "Erzincan", "Nevşehir", "Trabzon", "Niğde" };

            //tek tek ekleme
            lstSonuc.Items.Add(iller[0]);
            lstSonuc.Items.Add(iller[1]);
            lstSonuc.Items.Add(iller[2]);
            lstSonuc.Items.Add(iller[3]);
            lstSonuc.Items.Add(iller[4]);
            lstSonuc.Items.Add(iller[5]);
            lstSonuc.Items.Add(iller[6]);

            //genelde indexe ihtiyaç olduğu zaman for kullanılır.tek tek ekleme1;
            for (int i = 0; i < iller.Length; i++)
            {
                lstSonuc.Items.Add(iller[i]);
            }

            //tek tek ekleme2;
            foreach (var item in iller)
            {
                lstSonuc.Items.Add(item);
            }

            //tek seferde tüm diziyi bir anda eklemek için;
            lstSonuc.Items.AddRange(iller);


        }

        private void btnCifleriEkle_Click(object sender, EventArgs e)
        {
            //1'den 10a kadar dizi oluştur. sonrasında bir listeye çift olan sayıları ekle diğerine tekleri ekle.

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


        //***20 elemanlı boş bir dizi oluştur.sonrasında 1'den 20ye sayıları diziye ekle. sonra dizi elemanlarının hepsini lstSonuc listesinde göster
        //***bool için default değer false. int, byte, short,long 0. float,docuble, decimal 0.0. string null.

        private void btnDizeninSonElemani_Click(object sender, EventArgs e)
        {
            //iller dizisini tanımla, 5 il ekle, son elemanı seçip messageboxta göster.

            string[] iller = { "Ankara", "İzmir", "Diyarbakır", "Adana", "İstanbul" };

            MessageBox.Show(iller[iller.Length - 1]);
        }

        string[] isimler = { "Leyla", "Yasemin", "Bahar", "Ömer", "Serdar", "Orkun", "Eray", "Batuhan", "Çiğdem", "Mustafa", "Mert" };

        private void btnRastgeleEleman_Click(object sender, EventArgs e)
        {
            /*global olarak isimler dizisi oluştur sonra butona her basıldığında rastgele bir index seçsin ve bu indexteki isim listbox'a eklensin. bir eklenen isim bir daha eklenmesin ve tüm isimler bitince mb'da uyarı versin*/

            Random rnd = new Random();

            if (lstSonuc.Items.Contains(lstSonuc.Items) == false)
            {
                lstSonuc.Items.Add(isimler[rnd.Next(0, isimler.Length)]);
            }

            // MessageBox.Show("Ekleyecek eleman kalmadı!");
        }

        Random rnd = new Random();

        private void btnTopla_Click(object sender, EventArgs e)
        {
            /*sayılar dizisi oluşturalım en az 7 tane sayı eklensin(rastgele sayılar oluşturulsun). sonra butona basıldığında dizideki elemanları listeye ekle ve eklenenlerin toplamı formun başlığında gösterilsin.*/
            var sayilar1 = new int[7];
            int rastgele = rnd.Next(1, 11);

            sayilar1[0] = rastgele;
            sayilar1[1] = rastgele;
            sayilar1[2] = rastgele;
            sayilar1[3] = rastgele;
            sayilar1[4] = rastgele;
            sayilar1[5] = rastgele;
            sayilar1[6] = rastgele;

            foreach (var item in sayilar1)
            {
                //lstSonuc.Items.AddRange(item);
            }
            //instance: nesneden kopya almak demektir. 
            //this içinde bulunduğunuz sınıfı temsil eder. yani burada form2'yi temsil eder.
            //this.Text = toplam
        }

        private void btnSesliSessiz_Click(object sender, EventArgs e)
        {
            /*textboxta yazılan metni alıp sesli ve sessiz harflerini labellarda gösterelim.
            8 tane sesli harfi tanımladıktan sonra metnin her bir harfini tek tek inceleriz. eğer gelen harf sesliHarfler dizisinde yer alıyorsa sesli almıyorsa sessiz label'ına eklenir.*/
            //string: karakterler dizisidir.

            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'i' };
            var girilen = txtSesliSessiz.Text;

            foreach (var harf in girilen)
            {
                if (sesliHarfler.Contains(harf))
                {
                    lblSesli.Text += harf.ToString();
                }

                else
                {
                    lblSessiz.Text += harf.ToString();
                }
            }

            
        }
    }
}
