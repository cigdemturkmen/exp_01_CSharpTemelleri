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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        //kullanıcıdan alınan ürün bilgisine göre yönlendirilecek reyonu gösteren bir uygulama yapınız.

        private void btnAra_Click(object sender, EventArgs e)
        {
            //WOW! ToLower ve ToString metodlarını art arda kullanabiliyoruz.
            var urun = txtUrunAdi.Text.ToString().ToLower();

            if (urun == "bilgisayar" || urun == "cep telefonu" || urun == "minibook")
            {
                lblYonlendirme.Text = "Teknoloji reyonuna ilerleyiniz";
            }

            else if (urun == "parfüm" || urun == "deodorant" || urun == "şampuan")
            {
                lblYonlendirme.Text = "Kişisel bakım reyonuna ilerleyiniz";
            }

            else if (urun == "domates" || urun == "biber" || urun == "patlıcan")
            {
                lblYonlendirme.Text = "Sebze reyonuna ilerleyiniz";
            }

            else
            {
                lblYonlendirme.Text = "Bu ürün bulunmamaktadır";
            }
        }


    }
}
