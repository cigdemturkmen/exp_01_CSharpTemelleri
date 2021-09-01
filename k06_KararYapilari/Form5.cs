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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }


        //if ve switch case ile mevsimler ve aylar. switchde case birleştirme. aylar hangi mevsime denk gelir?

        private void btnAylariGetir_Click(object sender, EventArgs e)
        {
            var girilenMevsim = txtMevsim.Text.ToString();
            var aylar = "";

            switch (girilenMevsim)
            {
                case "kış":
                    aylar = "Aralık, Ocak, Şubat";
                    break;
                case "ilkbahar":
                    aylar = "Mart, Nisan, Mayıs";
                    break;
                case "yaz":
                    aylar = "Haziran, Temmuz, Ağustos";
                    break;
                case "sonbahar":
                    aylar = "Eylül, Ekim, Kasım";
                    break;
                default:
                    aylar = "Geçerli bir mevsim giriniz";
                    break;

            }

            MessageBox.Show(aylar);
        }
    }
}


