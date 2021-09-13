using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k07_Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // DÖNGÜLER - BOXING - UNBOXING  //CONTINUE - BREAK - RETURN

        private void btn1den100e_Click(object sender, EventArgs e)
        {
            //1'den 100'e kadar sayıları listbox'da göster.
            for (int i = 1; i < 101; i++)
            {
                lstSonuc.Items.Add(i);
            }
        }

        private void btn100den1e_Click(object sender, EventArgs e)
        {
            //100'den 1'e geri sayım yazdır lisbox'a.
            for (int i = 100; i > 0; i--)
            {
                lstSonuc.Items.Add(i);
            }
        }

        private void btn10dan50ye3er_Click(object sender, EventArgs e)
        {
            //10'dan 50'ye kadar 3'er arttırarak yazdır.
            for (int i = 10; i < 51; i += 3)
            {
                lstSonuc.Items.Add(i);
            }
        }

        private void btnAdanZye_Click(object sender, EventArgs e)
        {
            //A'dan Z'ye kadar harfleri yazdır.
            for (char i = 'A'; i <= 'Z'; i++)
            {
                lstSonuc.Items.Add($"{i} -> ASCII Karşılığı: {Convert.ToInt32(i)}");
            }
        }

        private void btn20den100ecift_Click(object sender, EventArgs e)
        {
            //20'den 100'e kadar çift sayıları yazdır. i +=2'yi kullanmadan yap bunu.
            for (int i = 20; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    lstSonuc.Items.Add(i);
                }
            }
        }

        private void btn1den11eToplam_Click(object sender, EventArgs e)
        {
            //[1-11] arasındaki sayilarin toplamini messagebox'ta göster.
            int toplam = 0;

            for (int i = 1; i < 12; i++)
            {
                toplam += i;
            }

            MessageBox.Show(toplam.ToString());
        }

        private void btn10la30arasiTekSayilarTopla_Click(object sender, EventArgs e)
        {
            //10'la 30 arasındaki tek sayıların toplamını bulunuz. Yine artış miktarıyla değil if ile yapınız.
            int toplam = 0;

            for (int i = 10; i < 31; i++)
            {
                if (i % 2 == 1)
                {
                    lstSonuc.Items.Add(i);
                    toplam += i; //toplam = toplam + i;
                }
            }

            MessageBox.Show(toplam.ToString());
        }

        private void btn2000ve2020_Click(object sender, EventArgs e)
        {
            //2000 ile 2020 arasındaki yılları combobox'a yazdıralım. Sonrasında combobox'tan bir yıl seçelim ve textbox'ta gösterelim.
            for (int i = 2000; i < 2021; i++)
            {
                cmbYears.Items.Add(i); //BOXING: Bir veri tipini object tipine çevirmek. Veri, belirsiz bir veri tipine dönüşür.
                //listBox.Items.Add(buraya OBJECT tipinde veri alır)
            }
        }

        private void cmbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboboxtan veri seçimi yapmak için; (veri seçimi indexine göre yapılır. -1 indexi hiçbir seçim yapılmadığını anlatır.)
            if (cmbYears.SelectedIndex != -1) //selected index değeri herhangi bir seçim olmazsa otomatik olarak -1 değerini alır.
            //veya cmbYears.SelectedIndex != null --NULL CHECK (null değerini convert edemezsiniz!!!)
            {
                var secilenYil = cmbYears.SelectedItem;
                txtSecilenYil.Text = secilenYil.ToString();
                //var secilenYil = Convert.ToDouble(cmbYears.SelectedItem); //UNBOXING: Object veri tipindeki bir veriyi kendi veri tipine değiştirmek.
            }
        }

        private void btnRastgele_Click(object sender, EventArgs e)
        {
            //rastgele sayılar üretip, listbox'ta göster. Aynı sayılar gelmesin!

            Random rnd = new Random(); //!!!!!!!!!!Bunu bloğun dışında yazdık çünkü içinde olursa doğru çalışmıyor; hep aynı sayılar geliyor.!!!!!!!!!!

            for (int i = 0; i < 10; i++)
            {
                int rastgeleSayi = rnd.Next(1, 11);

                if (lstSonuc.Items.Contains(rastgeleSayi) == false)
                {
                    lstSonuc.Items.Add(rastgeleSayi);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //listbox'taki bilgileri temizle.
            lstSonuc.Items.Clear();
        }

        private void BtnRandom10Numbers_Click(object sender, EventArgs e)
        {
            //1'den 10'a kadar sayıları rastgele sırayla listbox'a yazdır.

            Random random = new Random();//!!!!!!!!!!Bunu bloğun dışında yazdık çünkü içinde olursa doğru çalışmıyor; hep aynı sayılar geliyor.!!!!!!!!!!

            while (lstSonuc.Items.Count < 10)
            {
                int randomNumber = random.Next(1, 11);

                if (lstSonuc.Items.Contains(randomNumber) == false)
                {
                    lstSonuc.Items.Add(randomNumber);
                }
            }
        }

        private void BtnMultiplicationTable_Click(object sender, EventArgs e)
        {
            //1-10 arasındaki sayılar için çarpım tablosu oluştur.

            for (int i = 1; i < 11; i++)
            {
                lstSonuc.Items.Add($"{i}'LER TABLOSU");
                for (int j = 1; j < 11; j++)
                {
                    lstSonuc.Items.Add($"{i} x {j} = {i * j}");
                }
            }
        }

        private void BtnSquare_Click(object sender, EventArgs e)
        {
            //X'lerden 10'a 10 kare oluştur. label nesnesinde göster.

            for (int i = 0; i < 8; i++)
            {
                LblSquare.Text = LblSquare.Text + "\n";
                for (int j = 0; j < 10; j++)
                {
                    LblSquare.Text = $"{LblSquare.Text} X";
                }
            }
        }

        //CONTINUE, BREAK, RETURN

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //1-30 arasındaki sayıları yazdır, 8'in katlarını atla.
            for (int i = 1; i < 31; i++)
            {
                if (i % 8 == 0)
                {
                    continue; //Şarttaki değeri atlar ve devam eder.
                }
                lstSonuc.Items.Add(i);
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            //1-30 arasındaki sayıları yazdır, 9'un katı olan ilk sayıda duralım ve döngü sonlandı diye mesaj verelim.
            for (int i = 1; i < 31; i++)
            {
                if (i % 9 == 0)
                {
                    break; //Şarttaki koşul sağlanınca döngüye son verir. Döngüden sonraki kod parçalarından çalışmaya devam eder.
                }
                lstSonuc.Items.Add(i);
            }

            MessageBox.Show("Döngü sonlandı!");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 31; i++)
            {
                //1-30 arasında 4'ün katı olan ilk sayıda duralım.(sondaki mesaj kutusu çalışmayacak)
                if (i % 4 == 0)
                {
                    return; //Şarttaki koşul sağlanınca döngüye son verir. Döngüden sonraki kod parçaları çalışmaz.

                    //İçinde bulunulan metoddan(private void btnReturn_Click(object sender, EventArgs e)) çıkılması için kullanılır. 
                }
                lstSonuc.Items.Add(i);
            }
            MessageBox.Show("Döngü sonlandı. Bu mesaj kutusu açılmayacak.");
        }
    }
}

