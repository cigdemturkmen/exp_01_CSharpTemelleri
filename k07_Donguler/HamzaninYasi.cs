using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace k07_Donguler
{
    public partial class HamzaninYasi : Form
    {
        public HamzaninYasi()
        {
            InitializeComponent();
        }

        private void HamzaninYasi_Load(object sender, EventArgs e)
        {

        }
    
        DateTime today = DateTime.Now;
        DateTime birthday = new DateTime(2021, 7, 9);

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan difference = today - birthday;
            txtGunluk.Text = difference.Days.ToString();  
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            TimeSpan difference = today - birthday;
            int hafta = Convert.ToInt32(difference.Days);
            int kacHaftalik = hafta / 7;
            txtHaftalik.Text = kacHaftalik.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeSpan difference = today - birthday;
            var ay = Convert.ToInt32(difference.Days);
            int aylik = ay / 30;
            txtAylik.Text = aylik.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimeSpan difference = today - birthday;
            var yil = Convert.ToInt32(difference.Days);
            int yillik = yil / 365;
            txtYillik.Text = yillik.ToString();
        }
    }
}
