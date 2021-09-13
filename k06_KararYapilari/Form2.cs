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
            //Bu bir denemedir. form açıldığında çalışacak mı bakacağım. Çalıştı :)
            MessageBox.Show("Form açılmak üzere.");
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            //Girilen şifrenin uzunluğu 8'den küçükse şifre güvensiz yaz; eşitse daha güçlü şifre yazılabilir yaz. 8'den büyükse güçlü şifre yaz

            var sifre = txtPassword.Text;

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Lütfen oluşturmak istediğiniz şifreyi giriniz.");
            }

            if (sifre.Length <8)
            {
                MessageBox.Show("Güvensiz şifre!");
            }
            else if (sifre.Length == 8)
            {
                MessageBox.Show("Daha güçlü bir şifre yazılabilir.");
            }
            else
            {
                MessageBox.Show("Güçlü şifre!");
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //Kullanıcı adi ve parola doğru yazılırsa "Giriş başarılı!" yazsın. Hatalı yazılırsa da ona göre mesaj kutusunda mesaj verilsin
            var kullaniciAdi = txtKullaniciAdi.Text.ToLower();
            var password = txtKullaniciParolasi.Text.ToString();

            if (kullaniciAdi == "" || password == "") //herhangi bir kutucuğa bilgi girilmezse bu blok çalışır
            {
                MessageBox.Show("Kullanıcı adı ve parolanızı giriniz.");
                return; //Bu kod bloğu çalışırsa, en sondaki else çalışmasın diye return; ekledim. return'den sonraki kodların hiçbiri çalışmaz.
            }

            if (kullaniciAdi == "admin" && password == "1234" )
            {
                MessageBox.Show("Giriş başarılı!");
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
