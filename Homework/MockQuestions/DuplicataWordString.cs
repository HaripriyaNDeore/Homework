using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class DuplicataWordString
    {
        static void Main(string[] args)
        {
            int count = 0;
            String str = "red ball red apple red ball ";
            Console.WriteLine("Original string is "+str);
            String[] s = str.Split();
            str = str.ToLower();
            String word = "";
            Console.WriteLine("Duplicate word is ");
            for (int i = 0; i < s.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i].Equals(s[j]))
                    {
                        count++;

                        s[j] = "0";
                    }
                }
                
                if (count > 1 && s[i] != "0")
                {
                    Console.WriteLine(s[i]);
                }
            }
            Console.ReadLine(); 
        }
    }
}
