using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k09_ArraySinifi
{
    public partial class PasswordGeneratorArray : Form
    {
        public PasswordGeneratorArray()
        {
            InitializeComponent();
        }

        private void PasswordGeneratorArray_Load(object sender, EventArgs e)
        {

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {

            // Kullanıcıdan kaç karakterli bir şifre oluşturmak istediğini alalım
            // şifrenin içinde hangi tip karakterler geçmesini istediğini soralım ( büyük harf(0), küçük harf(1), rakam(2) veya sembol(3)) en az bir seçim yapmak zorunda olsun
            // her biri için dizi oluşturalım
            // hangi diziden seçim yapacağını rastgele seçmesi lazım
            // Ju+w35
            // bütün karakterleri tek bir char[]'e koyarak rastgele bu char dizisinden değer seçtirebilirdik.??TODO



            //if (txtKarakterSayisi.Text == null || txtKarakterSayisi.Text == "") // txtbox boşsa hata verelim
            if (string.IsNullOrEmpty(txtKarakterSayisi.Text)) 
                // true ise(yani bu haliyle) null veya boş olabilir; false ise boş değildir.
            {
                MessageBox.Show("Karakter sayısını boş bırakmayınız.");
                return;
            }
            var karakterSayisi = Convert.ToInt32(txtKarakterSayisi.Text);

            if (!(cbBuyukHarf.Checked || cbKucukHarf.Checked || cbRakam.Checked || cbSembol.Checked))
            {
                MessageBox.Show("En az bir checkbox seçiniz.");
                return;
            }

            var buyukHarfler = new char[0];
            var kucukHarfler = new char[0];
            var rakamlar = new char[0];
            var semboller = new char[0];

            //dizi içleri for ile doldurulabilir
            for (char i = 'A'; i <= 'Z'; i++)
           
            {
                Array.Resize(ref buyukHarfler, buyukHarfler.Length + 1);
                buyukHarfler[buyukHarfler.Length - 1] = i;
            }


            for (char i = 'a'; i <= 'z'; i++)
            {
                Array.Resize(ref kucukHarfler, kucukHarfler.Length + 1);
                kucukHarfler[kucukHarfler.Length - 1] = i;
            }

            for (char i = '0'; i <= '9'; i++)
            {
                Array.Resize(ref rakamlar, rakamlar.Length + 1);
                rakamlar[rakamlar.Length - 1] = i;
            }

            for (int i = 33; i <= 47; i++)
            {
                Array.Resize(ref semboller, semboller.Length + 1);
                semboller[semboller.Length - 1] = Convert.ToChar(i);
            }

            Random rnd = new Random();
            var sifre = "";
            

            //if (hangiDizidenSecimYapilsin == 0)
            //{
            //    //buyuk harflerden rastgele seçip şifrenin içine ekleyeceğiz.
            //} 
            //if'li bloku switch-case'le yaptık. sonra while eklemek zorunda kaldık.for olmadı.

            while (sifre.Length < karakterSayisi) // lenght değeri hiç karakter yoksa 0 alır.
            {
                var hangiDizidenSecimYapilsin = rnd.Next(0, 4); //0, 1, 2, 3

                switch (hangiDizidenSecimYapilsin)
                {
                    case 0:
                        //buyuklerden seç
                        if (cbBuyukHarf.Checked)
                        {
                            var rastgeleIndex = rnd.Next(0, buyukHarfler.Length);
                            var secilenHarf = buyukHarfler[rastgeleIndex];
                            sifre += secilenHarf;
                        }
                        break;
                    case 1:
                        //kucuklerden sec
                        if (cbKucukHarf.Checked)
                        {
                            var rastgeleIndex = rnd.Next(0, kucukHarfler.Length);
                            var secilenHarf = kucukHarfler[rastgeleIndex];
                            sifre += secilenHarf;
                        }
                        break;
                    case 2:
                        //rakamlardan sec
                        if (cbRakam.Checked)
                        {
                            var rastgeleIndex = rnd.Next(0, rakamlar.Length);
                            var secilenHarf = rakamlar[rastgeleIndex];
                            sifre += secilenHarf;
                        }
                        break;
                    case 3:
                        //sembollerden sec
                        if (cbSembol.Checked)
                        {
                            var rastgeleIndex = rnd.Next(0, semboller.Length);
                            var secilenHarf = semboller[rastgeleIndex];
                            sifre += secilenHarf;
                        }
                        break;

                        //default:
                }

            }

            lstSifreler.Items.Add(sifre);
        }
    }
}
