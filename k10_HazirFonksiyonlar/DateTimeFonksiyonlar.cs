using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k10_HazirFonksiyonlar
{
    public partial class DateTimeFonksiyonlar : Form
    {
        public DateTimeFonksiyonlar()
        {
            InitializeComponent();
        }

        private void DateTimeFonksiyonlar_Load(object sender, EventArgs e)
        {

        }

        DateTime simdikiZaman = DateTime.Now;

        private void btnSimdikiZaman_Click(object sender, EventArgs e)
        {
            
            lblSonuc.Text = simdikiZaman.ToString();
        }

        private void btnUzunZaman_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = simdikiZaman.ToLongDateString();
            MessageBox.Show(simdikiZaman.ToLongTimeString());
        }

        private void btnKisaZaman_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = simdikiZaman.ToShortDateString();
            MessageBox.Show(simdikiZaman.ToShortTimeString());
        }

        private void btnGun_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = simdikiZaman.Day.ToString();
        }

        private void btnAy_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = simdikiZaman.Month.ToString();
        }

        private void btnYil_Click(object sender, EventArgs e)
        {
            // d: day
            //M : Month (name of it)
            //y: year
            //m: minute
            //H: Hour
            //s: second
            lblSonuc.Text = simdikiZaman.Year.ToString();
            //lblSonuc.Text = simdikiZaman.Year.ToString("dd/MMM/yyyy HH:mm:ss");
        }

        private void btnZamanEkle_Click(object sender, EventArgs e)
        { 
            var zaman1 = simdikiZaman.AddDays(35);

            var zaman2 = simdikiZaman.AddMonths(4);

            var zaman3 = simdikiZaman.AddYears(45);
        }

        private void btnYasHesaplama_Click(object sender, EventArgs e)
        {
            //İki tarih arasındaki fark
            DateTime dogumTarihi = new DateTime(1991, 6, 2);
            var fark = simdikiZaman - dogumTarihi;

            var yas = fark.Days / 365;

            lblSonuc.Text = yas.ToString();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            //string formatındaki tarihi DateTime formatına çevirir
            var tarih1 = DateTime.Parse("2021-05-13");
            var tarih2 = DateTime.Parse("2021/13/05"); //TR tanımlı bilgisayarda bu kod çalışmaz. Runtime hatası gönderir

            DateTime cevirilenTarih;
            var cevirebildinMi = DateTime.TryParse("2021/13/05", out cevirilenTarih); 
            //çeviriyosa değeri cevirilenTarihe atar, çeviremezse hata vermez. (try catch'e almana gerek yok bu durumda)

            //DateTime, parasal(currency) formatları, harf : sıkıntılı arkadaşlar
        }
    }
}
