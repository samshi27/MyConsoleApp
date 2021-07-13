using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class MagicNumber
    {
        public void IsMagic()
        {
            // number whose sum of the digits is when multiplied by the reverse of the same sum results back the original number

            int n, num, sum1 = 0,  dig, res = 0, original;

            Console.Write("Enter an integer: ");
            n = int.Parse(Console.ReadLine());
            original = n;

            while (n != 0)
            {
                dig = n % 10;
                sum1 += dig;
                n /= 10;
            }

            num = sum1;

            while (num != 0)
            {
                dig = num % 10;
                res = res * 10 + dig;
                num /= 10;
            }

            if (sum1*res == original)
                Console.WriteLine("Magic Number");
            else
                Console.WriteLine("Not a Magic Number");
        }
    }
}
