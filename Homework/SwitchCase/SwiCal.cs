using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	class SwiCal
	{
        static void Main(string[] args)
        {
            int Num1, Num2;
            char op;
            int ans;
            Console.WriteLine("Enter 1st Number");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2st Number");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select the operator to perform calculation + - * /");
            Console.WriteLine("Enter + for Addition");
            Console.WriteLine("Enter - for Subtration");
            Console.WriteLine("Enter * for Multiplication");
            Console.WriteLine("Enter / for Division");
            op = Convert.ToChar(Console.ReadLine());
/*            ans = Convert.ToInt32(Console.ReadLine());
*/            switch (op)
            {
                case '+':
                    ans = Num1 + Num2;
                    Console.WriteLine("Additition of " + Num1 + " & " + Num2 + " is " + ans);
                    break;
                case '-':
                    ans = Num1 - Num2;
                    Console.WriteLine("Subtraction of " + Num1 + " & " + Num2 + " is " + ans);
                    break;
                case '*':
                    ans = Num1 * Num2;
                    Console.WriteLine("Multiplication of " + Num1 + " & " + Num2 + " is " + ans);
                    break;
                case '/':
                    ans = Num1 / Num2;
                    Console.WriteLine("Division of " + Num1 + " & " + Num2 + " is " + ans);
                    break;

                default: Console.WriteLine("Error");
                    break;

            }
            Console.ReadLine();
        }
    }
}
