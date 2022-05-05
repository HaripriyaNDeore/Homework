using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ForLoop
{
    class PrimeNo
    {
        static void Main(string[] args)
        {
            int count=0;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine("No is prime");
            }
            else
            {
                Console.WriteLine("No is Not Prime");
            }
            Console.Read();
        }
    }
}
