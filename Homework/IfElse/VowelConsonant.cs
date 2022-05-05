using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.IfElse
{
	class VowelConsonant
	{
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter Any Character to check whether it is vowel or Consanant");
            ch = Convert.ToChar(Console.Read());
            if (ch == 'A' || ch == 'a' || ch == 'I' || ch == 'i' || ch == 'E' || ch == 'e' || ch == 'O' || ch == 'o' || ch == 'U' || ch == 'u')
            {
                Console.WriteLine(ch + " Character is Vowel");
            }
            else
            {
                Console.WriteLine(ch + " Character is Consanant");
            }
            Console.ReadLine();

        }
    }
}
