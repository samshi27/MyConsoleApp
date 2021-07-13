using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class PerfectNumber
    {
        public void IsPerfect()
        {
            int i, n, sum = 0;

            Console.WriteLine("Enter an integer: ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i<n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }

            if (sum == n)
                Console.WriteLine("Perfect Number");
            else
                Console.WriteLine("Not a Perfect Number");
        }
    }
}
