using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.MockQuestions
{
    class PalindromeStri
    {
        static void Main(string[] args)
        {
            string rev = "";
            string str = Console.ReadLine();
            for (int i = str.Length-1; i >= 0; i--) 
            {
                rev =rev+ str[i];
            }
            if (rev == str)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            Console.ReadLine();
        }
    }
}
