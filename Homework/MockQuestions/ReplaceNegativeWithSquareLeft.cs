using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class ReplaceNegativeWithSquareLeft
    {
        static void Main(string[] args)
        {
            int[] Arr = {12, 3,-19, 29, 5, -61, 44, 7, -9};
            Console.WriteLine("Given Array is ");
            Console.WriteLine(" ");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("After replacing Negative number with left number Square  ");
            Console.WriteLine(" ");
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] < 0)
                {
                    Console.Write(Arr[i-1]*Arr[i-1] + " ");
                }
                else
                {
                    Console.Write(Arr[i] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
