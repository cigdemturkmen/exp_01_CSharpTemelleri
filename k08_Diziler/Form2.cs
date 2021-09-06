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

        //20 elemanlı boş bir dizi oluştur.sonrasında 1'den 20ye sayıları diziye ekle. sonra dizi elemanlarının hepsini lstSonuc listesinde göster
        //bool için default değer false. int, byte, short,long 0. float,docuble, decimal 0.0. string null.
    }
}
