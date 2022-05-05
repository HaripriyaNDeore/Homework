using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Recur
{
    class AlternateArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] c = new int[a.Length + b.Length]; // int[] c={10};

            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                c[i + a.Length] = b[i];
            }
            Console.WriteLine("After Merging Array is");
            for (int i = 0; i < c.Length; i++)
            {
                
                Console.Write(c[i] + ",");
            }

            Console.WriteLine("alternate position\n");
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c[k] = a[i];
                k = k + 2;
            }
            k = 1;
            for (int i = 0; i < b.Length; i++)
            {
                c[k] = b[i];
                k = k + 2;
            }
            
            Console.WriteLine("Array elements of c is");
            for (int i = 0; i < c.Length; i++)
            Console.Write(c[i]+",");
            Console.ReadLine();
        }
    }
}
