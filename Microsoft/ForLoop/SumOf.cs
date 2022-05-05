using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ForLoop
{
    class SumOf
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                sum = sum + num;
            }
            Console.WriteLine("Sum of number is"+sum);

        }
    }
}
