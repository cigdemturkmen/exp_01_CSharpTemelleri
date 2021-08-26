using System;

namespace k03_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //         +, - , * , / , %
            //      ++, -- , == , !


            /********* iki sayı al ve sonra toplamlarının karesini bul
            Console.WriteLine("Birinci sayıyı giriniz");
            var sayi1 = Console.ReadLine();
            int intsayi1 = Convert.ToInt32(sayi1);

            Console.WriteLine("İkinci sayıyı giriniz");
            var sayi2 = Console.ReadLine();
            int intsayi2 = Convert.ToInt32(sayi2);

            int toplam = intsayi1 + intsayi2;
            Console.WriteLine($"Toplam: {toplam}");
            var toplaminKaresi = Math.Pow(toplam , 2);  //bunun yerine???
            Console.WriteLine($"Toplamın karesi: {toplaminKaresi}");
            *********/

            // vize notunun yüzde 30 u finain 70ini hesaplayarak ortalamayı bulunuz

            /*
            Console.WriteLine("Vize notunu giriniz");
            var vize = Console.ReadLine();
            decimal decVize = Convert.ToDecimal(vize);

            Console.WriteLine("Final notunu giriniz");
            var final = Console.ReadLine();
            decimal decFinal = Convert.ToDecimal(final);

            decimal agirlik1 = decVize * 0.30m;
            Console.WriteLine(agirlik1);
            decimal agirlik2 = decFinal * 0.70m;
            Console.WriteLine(agirlik2);

            decimal notOrtalaması = (agirlik1 + agirlik2);
            Console.WriteLine(notOrtalaması);
            */


            Console.WriteLine("adınızı giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("soyadınızı giriniz");
            string soyad = Console.ReadLine();
            Console.WriteLine("mail uzantınızı giriniz");
            string mailUzantisi = Console.ReadLine();

            Console.WriteLine($"{ad}{soyad}@{mailUzantisi}.com");





        }
    }
}
