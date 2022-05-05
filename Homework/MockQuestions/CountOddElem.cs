using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class CountOddElem
    {
        static void Main(string[] args)
        {
            int[] arr = { 5,8,6,3,9,19};
            int counto = 0,counte=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 ==0)
                { 
                    counto++;
                }
                else
                {
                    counte++;
                }
            }
            Console.WriteLine("Odd number is "+ counto);
            Console.WriteLine("Even number is " + counte);
            Console.ReadLine();
        }
    }
}
