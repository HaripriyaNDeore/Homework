using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class Replace0to1Array
    {
        static void Main(string[] args)
        {
            int[] Arr = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            Console.WriteLine("Given Array is ");
            Console.WriteLine(" ");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("After replacing 0 with 1 Array is ");
            Console.WriteLine(" ");
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] ==0)
                {
                    Console.Write(1+" ");
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
