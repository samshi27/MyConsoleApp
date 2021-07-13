using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class ArrayList
    {
        public void ArraySum()
        {
            // array neeeds memory loaction at runtime hence we need to use 'new' keyword

            int sum = 0;
            Console.Write("Enter size of array: ");
            int n = int.Parse(Console.ReadLine());
            
            int[] arr = new int[n];

            for (int i = 0; i< n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of array elements: " + sum);

        }
    }
}
