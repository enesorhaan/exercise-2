using System;
using System.Collections;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cumle giriniz: ");
            string cumle = Console.ReadLine();
            string sesliHarfler = "aeıioöuü";

            ArrayList sesliDizi = new ArrayList();

            if(!string.IsNullOrEmpty(cumle))
            {
                string cumleKucuk = cumle.ToLower();
                for (int i = 0; i < cumle.Length; i++)
                {
                    if(sesliHarfler.Contains(cumleKucuk[i]))
                        sesliDizi.Add(cumleKucuk[i]);
                }
            }

            sesliDizi.Sort();

            foreach (var harf in sesliDizi)
                Console.WriteLine(harf);
        }
    }
}
