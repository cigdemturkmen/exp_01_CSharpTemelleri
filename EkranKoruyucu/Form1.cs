using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkranKoruyucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form içindekiler yüklendikten sonra resmin rastgele olarak yer değiştirmesini istiyoruz.
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timerın sadece 1 tane eventi vardır. o da bu.tick eventi
            Random rnd = new Random();

            var formunGenisligi = this.Width;
            var yukseklik = this.Height;

            var rastgele1 = rnd.Next(0, formunGenisligi);
            var rastgele2 = rnd.Next(0, yukseklik);

            pictureBox1.Left = rastgele1;
            pictureBox1.Top = rastgele2;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //koruyucu ekrandan çıkmak için click eventi.
            Application.Exit();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //koruyucu ekrandan çıkmak için klavyede bir şeye bas.
            Application.Exit();
        }

        //alt + tab ekran koruyucudan çıkar
    }
}
