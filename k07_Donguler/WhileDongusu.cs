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
        }

        private void WhileDongusu_Load(object sender, EventArgs e)
        {

        }

        private void btnOrn1_Click(object sender, EventArgs e)
        {
            //1den 100e kadar olan sayıları listeye yazdır.
            int i = 1;
            while (i < 101)
            {
                listBoxSonuc.Items.Add(i);
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //10 tane rastgele sayıyı listboxa ekle. Bu döngü kaç kez döndü saydırıp messageboxta göster.
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //do-while döngüsü
            int i = 0;
            do
            {
                MessageBox.Show("mrb");
                i++;
            } while (i < 3);

        }





    }
}
