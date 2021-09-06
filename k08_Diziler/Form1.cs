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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //ARRAY SYNTAX:dizi elemanları curly braces içinde yazılır.

            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] sayilar2 = new int[] { 10, 11, 12, 13, 14};

            //var isimler = { "ali", "veli", "ayşe" }; böyle yazamazsın

            var isimler2 = new string[] { "ali", null, "ayşe" };

            var iller = new string[3]; //bu gösterimde elemanları aynı ayrı tanımlaman lazım. bu içi boş bir dizidir.;
            iller[0] = "Ankara";
            iller[1] = "İstanbul";
            //iller[2] = "İzmir"; //boş olan elemanlar NULL olur.
            //iller[3] = "Ankara"; //System.IndexOutOfRangeException: 'Dizin, dizi sınırlarının dışındaydı.'

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
