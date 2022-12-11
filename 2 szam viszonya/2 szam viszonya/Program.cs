using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_szam_viszonya
{
    class Program
    {
        static void Main(string[] args)
        {
            double szam1, szam2;
            Console.WriteLine("Kérek két számot!");
            Console.Write("Elsö szám = ");
            szam1 = Convert.ToDouble(Console.ReadLine());
           Console.Write("Második szám = ");
            szam2 = Convert.ToDouble(Console.ReadLine());
             if (szam1 < szam2) 
                {
                Console.WriteLine("\nA {0} kissebb,mint {1}.",szam1,szam2);
                 }
                else
                {
                if (szam1 == szam2) 
                    {
                    Console.WriteLine("\nA {0} egyenlő {1}-gyel.",szam1, szam2);
                    }
                    else
                    {
                    Console.WriteLine("\nA {1} kissebb,mint {0}.",szam1, szam2);
                    }
                }
            Console.ReadLine();
        }
    }
}
