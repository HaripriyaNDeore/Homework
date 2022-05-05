using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class InsElemeSpePosi
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
                Console.WriteLine(a[i] + " ");
            }
            Console.WriteLine("Enter the element to insert");
            int ele = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the position to insert elements");
            int pos = Convert.ToInt32(Console.ReadLine());
            for (int i = size; i >= pos; i--)
            {
                a[pos-1] = ele;
            }
            Console.WriteLine("After inserting new element array is");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(a[i] + " ");
            }


            Console.ReadLine();

        }
    }
}
