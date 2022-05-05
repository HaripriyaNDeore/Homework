using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class MinArray
    {
        static void Main(string[] args)
        {
            int[] arr= { 5, 8, 6, 3, 9 };
            int min = 0;
            Console.WriteLine("Array is ");
            for (int i = 0; i < arr.Length; i++)
            {
                
                Console.Write(arr[i]+" ");
                if (min < arr[i])
                {
                    min = arr[i];
                }
                
            }
            Console.WriteLine("");
            Console.WriteLine("Minimum number is "+min);
            //USing for each///

            min = 0;
            foreach(int a in arr)
            {
                if(min<a)
                {
                    min = a;
                }
            }
            Console.WriteLine("Minimum number is " + min);
            Console.ReadLine();
        }
    }
}
