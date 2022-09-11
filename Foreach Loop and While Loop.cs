using System;

namespace ForeachLoopAndWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ortalama Program
            Console.WriteLine("Bir Sayı Giriniz!");

            int sayac = int.Parse(Console.ReadLine());
            int top = 0;
            int sayac1 = sayac;
            while (0 < sayac1)
            {
                top += sayac1;
                sayac1--;
            }
            Console.WriteLine("Sayı ortlaması:{0}", (top / sayac));

            char kar = 'a';

            while (kar <= 'z')
            {
                Console.Write(kar);
                kar++;
            }

            //Console.Write aynı satıra yazar
            //Console.WriteLine satır başı yapar

            string[] arabalar = { "Audi", "Bmw", "Mercedes", "Kia" };

            foreach (string item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
