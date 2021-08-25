using System;

namespace k02_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı giriniz");
            var sayi1 = Console.ReadLine();
            int intsayi1 = Convert.ToInt32(sayi1);

            Console.WriteLine("Birinci sayıyı giriniz");
            var sayi2 = Console.ReadLine();
            int intsayi2 = Convert.ToInt32(sayi2);

            var stringToplamı = sayi1 + sayi2;
            int gercekToplam = intsayi1 + intsayi2;

            Console.WriteLine(stringToplamı);
            Console.WriteLine(gercekToplam);

            var deneme = Convert.ToByte(sayi2);
            Console.WriteLine(deneme);
        }
    }
}
