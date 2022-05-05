using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class Average1D
    {
        static void Main(string[] args)
        {
            /*int[] arra = new int[10];*/
            /* arra[0] = 1;*/
            int[] arr = { 1, 2, 3, 4, 5, 6, 2, 7, 4, 8 };
            int length = arr.Length;
            int sum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]+" ");
                sum = sum + arr[i];
            }
            Console.WriteLine("sum of array is "+sum);
            Console.WriteLine("length og array is "+arr.Length);
            int Avg = sum / arr.Length;
            Console.WriteLine("Average of Array is"+Avg);
            Console.ReadLine();
        }
    }
    class Average1D1
    {
        static void Main(string[] args)
        {

            int[] ar = new int[100];
            Console.WriteLine("Enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            
            /* int length = ar.Length;*/

            Console.WriteLine("Enter the Array elements ");
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                Console.Write(i);
                ar[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + ar[i];
            }
            Console.WriteLine("Sum of Array is " + sum);
            int avg = sum / size;
            Console.WriteLine("Average of array is " + avg);
            Console.ReadLine();
        }
    }
}
