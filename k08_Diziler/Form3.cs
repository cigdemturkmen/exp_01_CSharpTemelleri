using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k08_Diziler
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            /*şifre ve şifre(tekrar)ının aynı olması gerekiyor. şifre uzunluğu > 8 ve en az 1 büyük ve 1 küçük harf ve 1 rakam ve 1 sembol içermesi gerekiyor.*/
            int uzunluk = txtSifre.Text.Length;
            int[] buyukHarf = 

            if (uzunluk > 8 && txtSifre.Text.Contains(buyukHarf) && txtSifre.Text.Contains(kucukHarf) && txtSifre.Text.Contains(sembol))
            {
                MessageBox.Show("Şifreniz başarıyla kaydedildi.");
            }
            else
            {
                MessageBox.Show("Tekrar deneyin!");
            }


        }
    }
}
