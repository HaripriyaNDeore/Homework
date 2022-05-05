using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class Anagram
    {
        static void Main(string[] args)
        {
            /* String str = "Keep";
             String str1 = "PeeK";*/

            String str = Console.ReadLine();
            String str1 = Console.ReadLine();


            String s1 = str.ToLower();
            String s2 = str.ToLower();


            char[] ch1 = s1.ToCharArray();
            char[] ch2 = s2.ToCharArray();


            Array.Sort(ch1);
            Array.Sort(ch2);


            String newString1 = new string(ch1);
            String newString2 = new string(ch2);


            if (newString1.CompareTo(newString2)==0)
            {
                Console.WriteLine("Both are Anagram");
            }
            else
            {
                Console.WriteLine("Both are Not Anagram");

            }
            Console.ReadLine();

        }
    }
}
