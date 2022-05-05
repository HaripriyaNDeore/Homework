using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ifElse
{
	class Calculator
	{
        static void Main(string[] args)
        {
            int Num1, Num2;
            char op;
            float ans;
            Console.WriteLine("Enter 1st Number");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2st Number");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select the operator to perform calculation + - * /");
            op = Convert.ToChar(Console.Read());
            if (op == '+')
            {
                ans = Num1 + Num2;
                Console.WriteLine("Addition is " + ans);
            }
            else if (op == '-')
            {
                ans = Num1 - Num2;
                Console.WriteLine("Subtraction is " + ans);
            }
            else
            if (op == '*')
            {
                ans = Num1 * Num2;
                Console.WriteLine("Multiplication is " + ans);
            }
            else if (op == '/')
            {
                if (Num1 == 0 || Num2 == 0)
                {
                    Console.WriteLine("Please Entered Valid Number");

                }
                else
                {
                    ans = Num1 / Num2;
                    Console.WriteLine("Division is " + ans);
                }
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            Console.ReadLine();




        }
    }
}
