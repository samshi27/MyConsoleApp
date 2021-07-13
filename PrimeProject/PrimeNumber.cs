using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class PrimeNumber
    {
        public void PrimeSolution()
        {
            // prime number -  a prime number is only divisible by 1 and itself

            int n, flag = 0, i;

            Console.Write("Enter the value of n: ");
            n = int.Parse(Console.ReadLine());

            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is prime.");
            else
                Console.WriteLine("Number is not prime");
        }
    }
}
