using System;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            int[] enBuyukler = new int[3];
            int[] enKucukler = new int[3];

            for(int i=0;i<20;i++)
            {
               Console.WriteLine("{0}. Sayiyi giriniz:", i + 1);
               int sayi = Convert.ToInt32(Console.ReadLine());
               numbers[i] = sayi;
            }

            Array.Sort(numbers);

            for(int j=0;j<3;j++)
            {
               enKucukler[j] = numbers[j];
            }

            Array.Reverse(numbers);

            for (int j=0;j<3;j++)
            {
               enBuyukler[j] = numbers[j];
            }
            Console.WriteLine($"En büyüklerin ortalamasi:{Math.Round(enBuyukler.Average(),2)}");
            Console.WriteLine($"En küçüklerin ortalamasi:{Math.Round(enKucukler.Average(), 2)}");
            Console.WriteLine($"Ortalamaların toplami: {Math.Round((enBuyukler.Average() + enKucukler.Average())),2}");
        }
    }
}
