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
    public partial class Form2 : Form
    {
        //1-100 arasında döngü kuran ve listbox'a yazdıran metodu yaz.
        //Bitiş değerini parametre olarak alıp 1'den bitişe kadar döngü kuran ve listbox'a yazdıran metodu yaz.
      //Başlangıç ve bitiş değerini parametre olarak alan ve başlangıçtan bitişe döngü kurduran ve listbx'a yzdrn metodu yaz

        
        private void Say ()
        {
            for (int i = 1; i < 101; i++)
            {
                lstSonuc.Items.Add(i);
            }
        }

        private void Say (int i)
        {   
            for (int j = 1 ; j <=i ; j++)
            {
                lstSonuc.Items.Add(j);
            }
        }

        private void Say(int i, int j)
        {
            for (int x = i; x <= j; x++)
            {
                lstSonuc.Items.Add(x);
            }
        }

        //Array veri tipini kullanarak yazdığım metot:

        private int[] SayilarDizisiniVer (int baslangic, int bitis)
        {
            int[] sayiDizisi = new int[0];
            int j = 0;

            for (int i = baslangic; i <= bitis; i++)
            {
                Array.Resize(ref sayiDizisi, j+1); // (ref sayiDizisi, sayilar.Length +1);
                sayiDizisi[j] = i; // [sayilar.Length-1] = i;
                j++;
            }
            return sayiDizisi;
        }

        private void MailAyristir ()
        {
            var ayrilanMailler = txtMailler.Text.Split(',', ';');

            foreach (var item in ayrilanMailler)
            {
                lstSonuc.Items.Add(item);
            } 
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn1To100_Click(object sender, EventArgs e)
        {
            Say();
        }

        private void btn1Toi_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txti1.Text);
            Say(i);
        }

        private void btniToj_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txti2.Text);
            int j = Convert.ToInt32(txtj2.Text);
            Say(i, j);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(txti2.Text);
            int bitis = Convert.ToInt32(txtj2.Text);

            var dizi = SayilarDizisiniVer(baslangic, bitis);

            foreach (var item in dizi)
            {
                lstSonuc.Items.Add(item); //AddRange'i sadece referans veri tiplerini eklerken kullanabilirsin.
            }
        }

        private void btnMailleriAyristir_Click(object sender, EventArgs e)
        {
            //txtMailler textboxına ; ve , ile birden fazla mail girişi yapılacak
            //bu mailleri sembollerine göre ayırarak geri döndüren bir metod yazınız
            //metoddan dönen sonucu listbox'ta gösterelim

            MailAyristir();

        }
    }
}
