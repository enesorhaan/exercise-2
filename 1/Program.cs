using System;
using System.Collections;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeNumber = new ArrayList();
            ArrayList notPrimeNumber = new ArrayList();
            int kontrol = 0;
            int asalToplam= 0;
            int asalOlmayanToplam = 0;

            Console.WriteLine("20 adet dogal sayi giriniz: ");

            for (int i = 0; i < 20; i++)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                if(sayi>=0){
                    if(sayi==0 || sayi ==1){
                        notPrimeNumber.Add(sayi);
                    }
                    else{
                        for (int j = 2; j < sayi; j++)
                        {
                            if (sayi % j == 0)
                                kontrol++;
                        }
                        if(kontrol == 0)
                            primeNumber.Add(sayi);
                        else
                            notPrimeNumber.Add(sayi);
                        kontrol=0;
                    }
                }
                else
                {
                    Console.WriteLine("Hatali Sayi Girdiniz...");
                }
            }
            primeNumber.Sort();
            notPrimeNumber.Sort();

            Console.WriteLine("***** Asal Sayilar *****");
            foreach (var sayi in primeNumber){
                Console.WriteLine(sayi);
                asalToplam = asalToplam + Convert.ToInt32(sayi);
            }

            Console.WriteLine("***** Asal Olmayan Sayilar *****");
            foreach (var sayi in notPrimeNumber){
                Console.WriteLine(sayi);
                asalOlmayanToplam = asalOlmayanToplam + Convert.ToInt32(sayi);
            }
            
            Console.WriteLine("Asal Sayi Listesinin Eleman Sayisi: " + primeNumber.Count);
            Console.WriteLine("Asal Sayilarin Ortalamasi: " + (float)asalToplam/primeNumber.Count);
            Console.WriteLine("Asal Olmayan Sayi Listesinin Eleman Sayisi: " + notPrimeNumber.Count);
            Console.WriteLine("Asal Olmayan Sayilarin Ortalamasi: " + (float)asalOlmayanToplam/notPrimeNumber.Count);
        }
    }
}
