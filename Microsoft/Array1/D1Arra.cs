using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Recur
{
    class D1Arra
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            a[0] = 1;
            a[1] = 11;
            a[2] = 2;
            a[3] = 3;
            a[4] = 5;

            Console.WriteLine("All the elements in array is ");
            for(int i=0;i<5;i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
