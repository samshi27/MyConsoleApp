using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class StarPattern
    {
       public void StarPrint()
       {
            int rows, i, j;

            Console.Write("Enter number of rows: ");
            rows = int.Parse(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
       }
    }
}
