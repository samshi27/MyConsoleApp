using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class ArrayReverse
    {
        public void ReverseArray()
        {
            Console.Write("Enter array length: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter array elements: ");
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            int temp;

            for (int i = 0; i < n / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[n- i - 1];
                arr[n - i - 1] = temp;
            }

            Console.WriteLine("Reversed array elements: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
