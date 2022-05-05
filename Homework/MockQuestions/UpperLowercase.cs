using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class UpperLowercase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.ReadLine();
        }
    }
}
