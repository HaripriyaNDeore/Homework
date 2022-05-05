using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class ReverseArr
    {
        static void Main(string[] args)
        {
            
            int[] a = new int[100];
            Console.Write("Enter size of array :");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of elements in the array :", size);
            for (int i = 0; i < size; i++)
            {
                Console.Write(i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Value in Array is ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(a[i]+" ");
            }
            Console.WriteLine("After reversing the array value is ");
            for(int i=size-1;i>=0;i--)
            {
                Console.WriteLine(a[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
