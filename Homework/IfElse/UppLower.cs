using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.IfElse
{
    class UppLower
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the character");
            char c = Convert.ToChar(Console.Read());
           
            if (c >= 'A' && c <= 'Z')
            {
                c = (char)(c + 32);
                Console.WriteLine("Character=" + c);
            }
            else if (c >= 'a' && c <= 'z')
            {
                c = (char)(c - 32);
                Console.WriteLine("character=" + c);
            }
            else
            {
                Console.WriteLine("invalid");
            }
            Console.Read();
        }

    }
}
