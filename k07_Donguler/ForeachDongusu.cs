using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k07_Donguler
{
    public partial class ForeachDongusu : Form
    {
        /*Foreach, liste veya dizi gibi bir koleksiyonda döner ve her dönüşte gelen değeri bir değişken üzerinde tutar. Koleksiyon içinde okunacak değer olduğu sürece dönmeye devam eder.*/

        public ForeachDongusu()
        {
            InitializeComponent();

            string[] isimler = { "ali", "veli", "ayşe" };

            foreach (var isim in isimler)
            {
                MessageBox.Show(isim);
            }

            //Bu foreach'in aynısını for'la yaz:

            for (int i = 0; i < isimler.Length; i++)
            {
                MessageBox.Show(isimler[i]);
            }

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    var isim = isimler[];
            //    MessageBox.Show($"{i}. öğrenci {isim}");
            //}
        }

        private void ForeachDongusu_Load(object sender, EventArgs e)
        {

        }
    }
}
