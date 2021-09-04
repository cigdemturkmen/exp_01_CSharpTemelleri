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
            //10dan 50ye kadar 3er arttırarak yazdır.
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
                lstSonuc.Items.Add($"{i} ASCII -> {Convert.ToInt32(i)}");
            }
        }


        private void btn20den100ecift_Click(object sender, EventArgs e)
        {
            //20den 100e kadar çift sayıları yazdır. i +=2'yi kullanmadan yap bunu.
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
            //[1-11] arasındaki sayilarin toplamini messageboxta göster.
            int toplam = 0;

            for (int i = 1; i < 12; i++)
            {
                toplam = toplam + i;
            }

            MessageBox.Show(toplam.ToString());
        }

        private void btn10la30arasiTekSayilarTopla_Click(object sender, EventArgs e)
        {
            //10la 30 arasındaki tek sayıların toplamını bulunuz. yine artış miktarı değil if ile yapınız.
            int toplam = 0;
            for (int i = 10; i < 31; i++)
            {
                if (i % 2 == 1)
                {
                    lstSonuc.Items.Add(i);
                    //toplam = toplam + i;
                    toplam += i;
                }
            }

            MessageBox.Show(toplam.ToString());
        }


        //2000 ile 2020 arasındaki yılları comboboxa yazdıralım. sonrasında comboboxtan bir yıl seçelim ve textboxta gösterelim.
        private void btn2000ve2020_Click(object sender, EventArgs e)
        {
            for (int i = 2000; i < 2021; i++)
            {
                cmbYears.Items.Add(i); //boxing
            }
        }
        private void cmbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboboxtan veri seçimi yapmak için.
            if (cmbYears.SelectedIndex != -1) //selected index değeri herhangi bir seçim olmazsa otomatik olarak -1 değerini alır. veya cmbYears.SelectedIndex != null --NULL CHECK
                                              //null değerini convert edemezsiniz.
            {
                var secilenYil = cmbYears.SelectedItem;
                txtSecilenYil.Text = secilenYil.ToString();
                //var secilenYil = Convert.ToDouble(cmbYears.SelectedItem); //unboxing
            }


        }

        private void btnRastgele_Click(object sender, EventArgs e)
        {
            //rastgele sayılar üretip, listboxta göster. aynı sayılar gelmesin!

            Random rnd = new Random();

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

            Random random = new Random();

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
            //1-10 arasındaki sayılar için çarğım tablosu oluştur.

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
    }
}
