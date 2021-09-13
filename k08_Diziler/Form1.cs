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
        //Bu formda array'lerin farklı gösterim biçimleri anlatılıyor.
        public Form1()
        {
            InitializeComponent();

            //ARRAY SYNTAX:dizi elemanları curly braces içinde yazılır.

            //1. GÖSTERİM:
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //2.GÖSTERİM:
            int[] sayilar2 = new int[] { 10, 11, 12, 13, 14 };

            //var isimler = { "ali", "veli", "ayşe" }; böyle yazamazsın, ='den sonra data type yazmalısın!
            var isimler2 = new string[] { "ali", null, "ayşe" }; // yani = new var[] olmuyor :D

            //3.GÖSTERİM:
            var iller = new string[3]; 
            //Bu gösterimde elemanları ayrı ayrı aşağıdaki gibi tanımlaman lazım. Bu şu an boş bir dizidir. içi boş dizi oluştururken eleman sayısını belirtmek zorundasın.

            iller[0] = "Ankara";
            iller[1] = "İstanbul";
            //iller[2] = "İzmir"; //boş olan elemanlar NULL olur.
            //iller[3] = "Ankara"; //Dizinin 4. elemanı olmadığı için uyarı verir: System.IndexOutOfRangeException:'Dizin, dizi sınırlarının dışındaydı.' 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bu formda array'lerin farklı gösterim biçimleri anlatılıyor.
        }
    }
}
