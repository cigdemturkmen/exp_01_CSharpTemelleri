using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k04_YasamDongusu
{
    public partial class YasamDongusu : Form
    {
        // scope : {} arasındaki alanlar
        int GlobalDegisken = 100;
        public YasamDongusu() //constructor
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalDegisken += 5;
            txtDeger.Text = GlobalDegisken.ToString();
        }
    }
}
