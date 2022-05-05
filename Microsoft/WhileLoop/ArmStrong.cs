using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.WhileLoop
{
    class ArmStrong
    {
        static void Main(string[] args)
        {
            int rem, result=0;
            Console.WriteLine("Enter the number to check whether it is Armstrong Or Not");
            int num = Convert.ToInt32(Console.ReadLine());
            int originalNum = num;
            while (num != 0)
            {
                rem = num % 10;
                result =result+(rem * rem * rem);
                num=num/10;
            }
            if(num== originalNum)
            {
                Console.WriteLine("NO is Armstrong");
            }
            else
            {
                Console.WriteLine("NO is Not Armstrong");
            }
            Console.Read();
        }
    }
}
