using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.SwitchCase
{
    class Vowel
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the charachter");
            ch = Convert.ToChar(Console.Read());


            switch (ch)
            {
                case 'A':
                    Console.WriteLine("VOWEL");
                    break;
                case 'E':
                    Console.WriteLine("VOWEL");
                    break;
                case 'I':
                    Console.WriteLine("VOWEL");
                    break;
                case 'O':
                    Console.WriteLine("VOWEL");
                    break;
                case 'U':
                    Console.WriteLine("VOWEL");
                    break;
                case 'a':
                    Console.WriteLine("VOWEL");
                    break;
                case 'e':
                    Console.WriteLine("VOWEL");
                    break;
                case 'i':
                    Console.WriteLine("VOWEL");
                    break;
                case 'o':
                    Console.WriteLine("VOWEL");
                    break;
                case 'u':
                    Console.WriteLine("VOWEL");
                    break;
                default:
                    Console.WriteLine("Consanant");
                    break;

            }
            Console.Read();
        }
    }
}
