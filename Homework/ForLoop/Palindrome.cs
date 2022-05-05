using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ForLoop
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            int num, n, rev, r,sum=0;

            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (r = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum * 10 + r;
            }
            if (r == sum)
                Console.Write("{0} is a palindrome number.\n", r);
            else
                Console.Write("{0} is not a palindrome number.\n", r);
        
            //palindrome number between 100 to 500
             Console.WriteLine("Palindrome  No between 100 to 500 is ");
            for (num = 100; num <= 500; num++)
            {
                rev = 0;
                n = num;
                while (n != 0)
                {
                    r = n % 10;
                    rev = rev * 10 + r;
                    n = n / 10;
                }
                if (num == rev)
                    Console.Write(num+",");
            }
            Console.Read();
        }
    }
}
