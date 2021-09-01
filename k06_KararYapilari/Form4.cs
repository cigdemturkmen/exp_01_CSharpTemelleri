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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }


        //kitap sipariş sayısı girilsin. 20den küçükse birin fiyat üzerinden satış yapılsın.20-50 %5 indirim. 50-100 %10. 100-200 %20. 200den fazla ise %25 indirim yaparak kullanıcıya ödemesi gereken tutarı gösteriniz.
        private void btnFiyatHesapla_Click(object sender, EventArgs e)
        {
            //var girilenKitapSayisi = txtKitapAdedi.Text;
            //int KitapAdedi = Convert.ToInt32(girilenKitapSayisi);
            //int kitapFiyati = 10;
            //double indirimOranı = 0;
           

            


            //if (KitapAdedi < 20 && KitapAdedi > 0)
            //{
            //    txtFiyat.Text = toplamTutar;
            //}

            //else if (KitapAdedi < 50 && KitapAdedi >=20)
            //{

            //}
            //else if (KitapAdedi < 100 && KitapAdedi >= 50)
            //{

            //}
            //else if (KitapAdedi < 200 && KitapAdedi >= 100)
            //{

            //}
            //else if (KitapAdedi >= 200)
            //{

            //}
            //else
            //{
            //    MessageBox.Show("Lütfen geçerli bir adet giriniz");
            //}

            //double toplamTutar = (KitapAdedi * kitapFiyati * indirimOranı);


            var girilenKitap = txtKitapAdedi.Text;
            var kitapSayisi = Convert.ToInt32(girilenKitap);
            double birimfiYAT = 10;
            double tutar = 0;
            double indirimOrani = 0;

            if (true)
            {
                indirimOranı = 0;
            }

            else if (true)
            {
                indirimOranı = 0.05;
            }
            else if (true)
            {
                
            }
            tutar = birimfiYAT * kitapSayisi * (1 - indirimOranı);
            txtFiyat.Text = tutar.ToString();
        }
     
    }
}
