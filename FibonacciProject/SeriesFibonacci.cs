using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class SeriesFibonacci
    {
        public void FibonacciSeries()
        {
            int i, n, dig1 = 0, dig2 = 1, dig3;

            Console.Write("Enter number of elements: ");
            n = int.Parse(Console.ReadLine());

            Console.Write(dig1 + " " + dig2 + " ");

            for (i = 2; i < n; i++)
            {
                dig3 = dig1 + dig2;
                Console.Write(dig3 + " ");
                dig1 = dig2;
                dig2 = dig3;
            }
            Console.WriteLine();
        }
    }
}
