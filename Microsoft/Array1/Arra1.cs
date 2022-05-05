using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class Arra1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int even = 0, odd = 0;
            Console.WriteLine("Enter elements of an array:");
           
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{i}= ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                     
            }

            Console.Write("\nElements in array are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine( arr[i]);
                if (i % 2 == 0)
                {
                   /* Console.WriteLine(i + " No is Even");*/
                    even++;               
                }
                else
                {
                    /* Console.WriteLine(i + " No is Odd");*/
                    odd++;
                }
               
            }
            Console.WriteLine("Even Number is "+even++);
            Console.WriteLine("Even Number is " + odd++);
           
            
        }

    }

}
