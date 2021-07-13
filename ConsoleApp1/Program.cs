using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int option;

            while(true)
            {
                Console.WriteLine("Press 1 to check for prime number");
                Console.WriteLine("Press 2 for array sum");
                Console.WriteLine("Press 3 for factorial");
                Console.WriteLine("Press 4 for a star pattern");
                Console.WriteLine("Press 5 to check for palindrome number");
                Console.WriteLine("Press 6 to check for armstrong number");
                Console.WriteLine("Press 7 for fibonacci series");
                Console.WriteLine("Press 8 to check for perfect number");
                Console.WriteLine("Press 9 to check for magic number");
                Console.WriteLine("Press 10 to reverse an array");
                Console.WriteLine("Enter 11 to exit");
                Console.Write("Your choice: ");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        PrimeNumber prime = new PrimeNumber();
                        prime.PrimeSolution();
                        Console.WriteLine();
                        break;
                    case 2:
                        ArrayList arrayList = new ArrayList();
                        arrayList.ArraySum();
                        Console.WriteLine();
                        break;
                    case 3:
                        Factorial factorial = new Factorial();
                        factorial.CalculateFact();
                        Console.WriteLine();
                        break;
                    case 4:
                        StarPattern starPattern = new StarPattern();
                        starPattern.StarPrint();
                        Console.WriteLine();
                        break;
                    case 5:
                        PalindromeNumber palindrome = new PalindromeNumber();
                        palindrome.IsPalindrome();
                        break;
                    case 6:
                        ArmstrongNumber armstrong = new ArmstrongNumber();
                        armstrong.IsArmstrong();
                        Console.WriteLine();
                        break;
                    case 7:
                        SeriesFibonacci fibonacci = new SeriesFibonacci();
                        fibonacci.FibonacciSeries();
                        Console.WriteLine();
                        break;
                    case 8:
                        PerfectNumber perfect = new PerfectNumber();
                        perfect.IsPerfect();
                        Console.WriteLine();
                        break;
                    case 9:
                        MagicNumber magic = new MagicNumber();
                        magic.IsMagic();
                        Console.WriteLine();
                        break;
                    case 10:
                        ArrayReverse arrayReverse = new ArrayReverse();
                        arrayReverse.ReverseArray();
                        Console.WriteLine();
                        break;
                    case 11:
                        return;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }

            }
        }
    }
}

    
