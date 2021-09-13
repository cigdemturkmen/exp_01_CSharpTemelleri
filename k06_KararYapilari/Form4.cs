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
            //Burası constructure.
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*Kullanıcının aldığı kitap sayısına göre toplam fiyatı gerekli inidirimleri yaparak hesapla ve kullanıcıya göster.
         * Her kitabın fiyatı 10.
         * 20'den az kitap alıyorsa birim fiyat üzerinden işlem yap.
         * 20 ile 50 arasında kitap alıyorsa %5 indirim,
         * 50 ile 100 arasında kitap alıyorsa %10 indirim,
         * 100 ile 200 arasında kitap alıyorsa %20 indirim,
         * 200'den fazla kitap alıyorsa %25 indirim uygula.
         */
            try
            {
                int numberOfBooks = Convert.ToInt32(txtInput.Text);
                var bookPrice = 10;
                double discount = 0;

                if (numberOfBooks > 0 && numberOfBooks < 20)
                {
                    discount = 0;
                }
                else if (numberOfBooks >= 20 && numberOfBooks < 50)
                {
                    discount = 0.05;
                }
                else if (numberOfBooks >= 50 && numberOfBooks < 100)
                {
                    discount = 0.10;
                }
                else if (numberOfBooks >= 100 && numberOfBooks < 200)
                {
                    discount = 0.20;
                }
                else if (numberOfBooks >= 200)
                {
                    discount = 0.25;
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
                }

                txtPrice.Text = (numberOfBooks * bookPrice * (1 - discount)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen makul bir sayı giriniz."); //int'in sınırlarını aşan bir rakam girildiğinde catch'e düşecek.
            }
        }
    }
}
