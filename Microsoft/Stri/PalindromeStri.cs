using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Stri
{
    class PalindromeStri
    {
        static void Main(string[] args)
        {
            string s, rev = "";
            Console.WriteLine(" Enter string");
            s = Console.ReadLine();
            for (int i = s.Length-1; i >= 0; i--) 
            {
                rev =rev+ s[i];
            }
            if (rev == s)
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
