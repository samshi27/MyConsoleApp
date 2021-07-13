using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class ArmstrongNumber
    {
        public void IsArmstrong()
        {
            // sum of cubes of digts must be equal to the number itself

            int num, n, sum = 0, digit;
            Console.Write("Enter an integer: ");
            n = int.Parse(Console.ReadLine());
            num = n;

            while (n != 0)
            {
                digit = n % 10;
                sum += (int)Math.Pow(digit, 3);
                n /= 10;
            }

            if (sum == num)
                Console.WriteLine("Armstrong Number");
            else
                Console.WriteLine("Not an Armstrong Number");
        }
    }
}
