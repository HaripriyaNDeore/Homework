using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class InserElementInPos
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];
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
            Console.WriteLine("Enter the data to insert");
            int data = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the position to insert elements");
            int pos = Convert.ToInt32(Console.ReadLine());
            if(pos==size)
            {
                a[size] = data;
                size++;
            }
            else if(pos>=0 && pos<size)
            {
                for (int k = size - 1; k >= pos; k--)
                {
                    a[k + 1] = a[k];
                }
                a[pos] = data;
            }
            else
            {
                Console.WriteLine("Index out of range");
            }
            Console.WriteLine("After inserting data Array is");
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]+" ");
            }
            Console.ReadLine();

        }
    }
}
