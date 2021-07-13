using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Factorial
    {
        public void CalculateFact()
        {
            int fact = 1, i, n;

            Console.Write("Enter an integer: ");
            n = int.Parse(Console.ReadLine());

            for(i = 1; i <= n; i++)
            {
                fact *= i;
            }

            Console.WriteLine("Factorial of " + n + " is " + fact);
        }
    }
}
