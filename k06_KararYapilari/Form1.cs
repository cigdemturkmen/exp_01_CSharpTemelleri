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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //formun üzerine çift tıklyarak formun load tetikleme işleminin kodunu yazdırdık.
        private void Form1_Load(object sender, EventArgs e)
        {
            //if-else
            //switch - case
            //ternary if

            //try-catch-finally: hata alması muhtemel kodlar try bloğu içine yazılır. catch içine ise Run Time Error oluştuğu zaman yapılacak işlem kodlanır.

            //try-catch bloğundan sonra finally {} bloğu kullanılırsa, hata oluşsa da oluşmasa da bu bloğun içindeki kodlar çalışır.

        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            //dışarıdan alınan bir verinin nur değerine eşit olm durumunda çalışan ve ekrana girilen değer NUR yazan uygulamayı yapalım 
            if (txtName.Text == "nur")
            {
                MessageBox.Show("Ekrana girilen değer: NUR'dur.");
            }

            else
            {
                MessageBox.Show("Giriş hatalı. Lütfen bilgilerinizi kontrol ediniz.");
            }
        }

        private void btnSayi_Click(object sender, EventArgs e)
        {
            //kullanıcı notunu girsin ve mesaj kutusunda geçtiği veya kaldığı yazsın
            try
            {
                int Not = Convert.ToInt32(txtSayi.Text);

                if (Not <= 50 && Not >= 0)
                {
                    MessageBox.Show("Kaldınız :( ");
                }
                else if (Not > 50 && Not <= 100)
                {
                    MessageBox.Show("Geçtiniz!");
                }

                else
                {
                    MessageBox.Show("Uygun bir sayı giriniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bir sayı giriniz.");
                //MessageBox.Show($"Lütfen bir sayı giriniz. " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bir sayı alıp, mesaj kutusunda sayının tek mi çift mi olduğunu gösterelim
            try
            {
                int girilenSayi = Convert.ToInt32(txtTekCift.Text);

                if (girilenSayi % 2 == 0)
                {
                    MessageBox.Show("Bu sayı çift bir sayıdır.");
                }

                else
                {
                    MessageBox.Show("Bu sayı tek bir sayıdır.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bir sayı giriniz. " + ex.Message);
            }
        }
    }
}
