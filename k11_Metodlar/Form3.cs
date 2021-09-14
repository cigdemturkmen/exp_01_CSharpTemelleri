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
    public partial class Form3 : Form
    {
        /*
         * params
         * out
         * ref
         */
        #region Params

        private int Topla (int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        private int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        private int Topla(int sayi1, int sayi2, int sayi3, int sayi4)
        {
            return sayi1 + sayi2 + sayi3 + sayi4;
        }

        //Instead of the above overloads, simply use params keyword to take as many parameters as you want

        private int Topla(params int[] sayilar)
        {
            var toplam = 0;

            foreach (var item in sayilar)
            {
                toplam += item;
            }
            return toplam;
        }
        #endregion
        #region Out

        #endregion

        private void RandomSayiUret(int girilenSayi)
        {
            Random rnd = new Random();
            var randomSayi = rnd.Next(1, 101);
            
            for (int i = 0; i < girilenSayi; i++)
            {
                if (!listBox1.Items.Contains(randomSayi))
                {
                    
                    listBox1.Items.Add(randomSayi);
                }
                
            }
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            //random sayı üreterek lisboxa bu sayıları ekleyen bir metod yazınız.
            //kaç tane random sayı üretmek istediğimizi kullanıcıya soralım
            //listbox'a daha önce eklenen bir sayı bir daha eklenmesin
            //RandomSayiUret(10)
            var girdi = Convert.ToInt32(txti.Text);
            RandomSayiUret(girdi);
        }
    }
}
