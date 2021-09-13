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
    public partial class btnRastgele : Form
    {
        public btnRastgele()
        {
            InitializeComponent();
            //WHILE, DO-WHILE, SAYAÇ KULLANIMI
            //Bu formun adına bişiler olmuş, asıl adı: btnRastgele
        }

        private void WhileDongusu_Load(object sender, EventArgs e)
        {

        }

        private void btnOrn1_Click(object sender, EventArgs e)
        {
            //1'den 100'e kadar olan sayıları listeye yazdır.
            int i = 1;

            while (i < 101)
            {
                listBoxSonuc.Items.Add(i);
                i++; //Bunu yazmazsak sonsuz döngüye oluşur.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //10 tane rastgele sayıyı listbox'a ekle. Bu döngü kaç kez döndü saydırıp messagebox'ta göster.
            Random rnd = new Random();
            int i = 0;

            while (listBoxSonuc.Items.Count < 10)
            {
                var rastgeleSayi = rnd.Next(1, 11);

                if (!listBoxSonuc.Items.Contains(rastgeleSayi))
                {
                    listBoxSonuc.Items.Add(rastgeleSayi);
                }

                i++;
            }

            MessageBox.Show($"Bu döngü {i} kez döndü.");
            listBoxSonuc.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //do-while döngüsü
            int i = 0;
            do
            {
                MessageBox.Show("Merhaba!");
                i++;
            } while (i < 3);
        }
    }
}
