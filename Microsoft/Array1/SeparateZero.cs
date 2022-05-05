using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class SeparateZero
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];
            int i;
            Console.WriteLine("Enter the array ");
            for (i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int size = arr.Length;
            int pos = 0;
            for ( i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[pos] = arr[i];
                    pos++;
                }
            }
            while (pos < arr.Length)
            {
                arr[pos] = 0;
                pos++;
            }
           Console.WriteLine("The array created is: ");
            for (i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The array created is: " + arr[i]);
            }
            Console.ReadLine();

        }
    }
}
