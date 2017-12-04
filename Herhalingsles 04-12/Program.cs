using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herhalingsles_04_12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> namen = new List<String>(new String[] { "An", "Jan", "Ben", "Jos", "Maria", "Louise" });
            namen.Add("Annemarie");

            List<int> getallen = new List<int>() { -3, -5, -6, 4, 8, 6, 9 };
            List<int> gefilterdeGetallen = new List<int>(getallen);
            //PrintNamen(namen);
            //PrintGetallen(gefilterdeGetallen);

            Random rnd = new Random();
            int a = 5;
            int b = 7;
            int c = 3;
            a = Verhooging(a, rnd.Next(2, 10));
            b = Verhooging(b, rnd.Next(2, 10));
            c = Verhooging(c, rnd.Next(2, 10));

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }

        static void PrintGetallen(List<int> getallen)
        {
            foreach (int getal in getallen)
            {
                Console.WriteLine(getal);
            }
        }

        //static void PrintNamen(List<String> namen)
        //{
        //    foreach (String naam in namen)
        //    {
        //        Console.WriteLine(naam);
        //    }
        //}

        static int Verhooging(int n, int m)
        {
            return m + n;
        }

        //static List<String> FilterGetallen(List<int> getallen)
        //{
        //    List<int> filterd = new List<int>();
        //    foreach (var getal in getallen)
        //    {
        //        if (getal > 0 && getal < 10)
        //        {
        //            filterd.Add(getal);
        //        }
        //        return filterd;
        //    }
        //}

    }
}
