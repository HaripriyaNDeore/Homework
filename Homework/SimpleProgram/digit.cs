using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.SimpleProgram
{
    class digit
    {
        static void Main(string[] args)
        {
            int Number,Num1,Num2;
            Console.WriteLine("Enter four digit number");
            Number = Convert.ToInt32(Console.ReadLine());
            Num1 = Number / 100;
            Num2 = Number % 100;
            Console.WriteLine("First Number is  "+Num1);
            Console.WriteLine("Second Number is "+Num2);
            Console.Read();

        }
    }
}
