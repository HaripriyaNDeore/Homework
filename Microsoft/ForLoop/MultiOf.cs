using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ForLoop
{
    class MultiOf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
                sum = sum * i;

            }
            Console.WriteLine("Multiplication of number is "+sum);
            Console.Read();

        }
    }
}
