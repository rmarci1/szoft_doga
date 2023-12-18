using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam = 1;
            List<int> list = new List<int>();
            while (szam!=0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write($"{list[i]},");
                }
                Console.WriteLine();
                Console.WriteLine("Kérek egy számot, Vége:0");
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam != 0)
                {
                    list.Add(szam);
                }         
            }
            int legnagyobb = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (legnagyobb < list[i])
                {
                    legnagyobb = list[i];
                }
            }
            Console.WriteLine($"A legnagyobb szám a listában az:{legnagyobb} ");

            Console.ReadKey();

        }
    }
}
