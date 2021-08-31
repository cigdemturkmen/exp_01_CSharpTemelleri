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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            //girilen şifrenin uzunluğu 8den küçükse şifre güvensiz yaz eşitse daha güçlü şifre yazılabilir. 8den büyükse güçlü şifre yaz.

            var sifre = txtPassword.Text;

            if (sifre.Length <8)
            {
                MessageBox.Show("güvensiz şifre");
            }
            else if (sifre.Length == 8)
            {
                MessageBox.Show("daha güçlü şifre yazılabilir");
            }
            else
            {
                MessageBox.Show("güçlü şifre");
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var kullaniciAdi = txtKullaniciAdi.Text.ToLower();
            var password = txtKullaniciParolasi.Text.ToString();

            if (kullaniciAdi == "admin" && password == "1234" )
            {
                MessageBox.Show("Hoşgeldiniz!");
            }
            else if (kullaniciAdi != "admin" && password == "1234")
            {
                MessageBox.Show("Kullanıcı adınız hatalı!");
            }
            else if (password != "1234" && kullaniciAdi == "admin")
            {
                MessageBox.Show("Şifreniz hatalı");
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız ve şifreniz hatalı!");
            }

            //checkbox'ın işaretlenip işaretlenmediğini almak için:
            if (chbBeniHatirla.Checked)
            {
                MessageBox.Show("Beni hatırla işaretlendi");
            }
        }
    }
}
