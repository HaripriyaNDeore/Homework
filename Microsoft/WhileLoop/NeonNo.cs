using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.WhileLoop
{
    class NeonNo
    {
        static void Main(string[] args)
        {
            int a=1,sum=0;
            Console.WriteLine("Enter the number to check whether it is Armstrong Or Not");
            int num = Convert.ToInt32(Console.ReadLine());
            int squ = a * a;
            while(squ>0)
            {
                int re = squ % 10;
                sum = sum + re;
                squ = squ / 10;

            }
            if (sum == a)
            {
                Console.WriteLine("Neon Number");
            }
            else
            {
                Console.WriteLine("Neon Number");
            }
            Console.Read();


        }
    }
}
