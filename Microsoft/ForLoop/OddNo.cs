using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ForLoop
{
    class OddNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to print odd Number and even Number between 1 to that number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ODD NUMBER IS");
            for (int i=1;i<=num;i=i+2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("EVEN NUMBER is");
            for (int i = 0; i <= num; i = i + 2)
            {
                
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
