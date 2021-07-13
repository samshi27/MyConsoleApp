using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class PalindromeNumber
    {
        public void IsPalindrome()
        {
            int n, num, digit, res = 0;

            Console.Write("Enter an integer: ");
            n = int.Parse(Console.ReadLine());

            num = n;

            while (n != 0)
            {
                digit = n % 10;
                res = res * 10 + digit;
                n /= 10;
            }

            if (res == num)
                Console.WriteLine("Palindrome Number");
            else
                Console.WriteLine("Not a Palindrome Number");
        }
    }
}
