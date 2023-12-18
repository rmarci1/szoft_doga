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
                Console.WriteLine("Kérek egy számot, Vége:0");
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam != 0)
                {
                    list.Add(szam);
                }
               
            }
            
            Console.ReadKey();

        }
    }
}
