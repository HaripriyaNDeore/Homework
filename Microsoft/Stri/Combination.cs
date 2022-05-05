using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Stri
{
    class Combination
    {

        static public int freq(string s ,char ch)
        {
            int c = 0;
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] == ch)
                    c++;
            }
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the string");
            string s2 = Convert.ToString(Console.ReadLine());
            bool isfound = true;
           
            foreach(char c in s2)
            {
                int c1 = freq(s1, c);
                int c2 = freq(s2, c);
                if(c1<c2)
                {
                    isfound = false;
                    break;
                }
            }
            if(isfound)
            {
                Console.WriteLine("String can be found");
            }
            else
            {
                Console.WriteLine("Not found");
            }
            Console.ReadLine();
        }
    }
}
