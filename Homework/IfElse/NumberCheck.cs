using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.IfElse
{
	class NumberCheck
	{
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Enter the Number");
            Num = Convert.ToInt32(Console.ReadLine());
            if (Num > 0)
            {
                Console.WriteLine("Number is POSITIVE");
            }
            else if (Num < 0)
            {
                Console.WriteLine("Number is NEGATIVE");
            }
            else if (Num == 0)
            {
                Console.WriteLine("Number is ZERO");
            }
            Console.Read();
        }
    }
}
