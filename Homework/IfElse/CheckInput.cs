using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.IfElse
{
	class CheckInput
	{
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter Input to check whether it is alphabet, digit or special character");
            ch = Convert.ToChar(Console.Read());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " it is ALPHABET");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + " it is NUMBER");
            }
            else
            {
                Console.WriteLine(ch + " it is SPECIAL CHARACTER");
            }
            Console.Read();


        }
    }
}
