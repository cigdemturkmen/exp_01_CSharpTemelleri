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


        //formun üzerine çift tıklyarak formun load işlemini gerçekleştirdik.
        private void Form1_Load(object sender, EventArgs e)
        {
            //if-else
            //switch - case
            //ternary if

            //dışarıdan alınan bir verinin nur değerine eşit olm durumunda çalışan ve ekrana girilen değer NUR yazan uygulamayı yapalım  
        }


        private void btnTikla_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "nur")
            {
                MessageBox.Show("Girdiğiniz değer: NUR'dur");
            }

            else
            {
                MessageBox.Show("Giriş hatalı. Bilgilerinizi kontrol ediniz.");
            }
        }




        private void btnSayi_Click(object sender, EventArgs e)
        {
            //var not = txtSayi.Text;
            //int Not = Convert.ToInt32(not);

            //if (Not <= 50)
            //{
            //    MessageBox.Show("kaldınız :( ");
            //}
            //else if (Not > 50)
            //{
            //    MessageBox.Show("geçtiniz!");
            //}

            //else
            //{
            //    MessageBox.Show("uygun bir sayı giriniz");
            //}
            try
            {
                var not = txtSayi.Text;
                int Not = Convert.ToInt32(not);

                if (Not <= 50)
                {
                    MessageBox.Show("kaldınız :( ");
                }
                else if (Not > 50)
                {
                    MessageBox.Show("geçtiniz!");
                }

                else
                {
                    MessageBox.Show("uygun bir sayı giriniz");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen bir sayı giriniz");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            try
            {
                var girilenDeger = txtTekCift.Text;
                int girilenSayi = Convert.ToInt32(girilenDeger);


                if (girilenSayi % 2 == 0)
                {
                    MessageBox.Show("bu bir çift sayı");
                }

                else
                {
                    MessageBox.Show("bu sayı tek bir sayı");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen bir sayı giriniz. " + ex.Message );
            }
        }
    }
}
