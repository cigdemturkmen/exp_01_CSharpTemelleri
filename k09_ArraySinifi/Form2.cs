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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        string[] ziyaretciler = new string[0];

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //RESIZE ORNEGI!!!

            /*Textbox'tan alınan adı ve soyadı bir dizide toplayalım, sonrasında listbox'a ekleyelim.*/
            var adSoyad = txtAdSoyad.Text;
            Array.Resize(ref ziyaretciler, ziyaretciler.Length+1);

            ziyaretciler[ziyaretciler.Length - 1] = adSoyad;

            lstZiyaretciler.Items.Add(adSoyad);
        }
    }
}
