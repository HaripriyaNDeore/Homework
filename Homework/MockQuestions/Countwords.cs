using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class Countwords
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            input = input.ToLower();
            string s = Console.ReadLine();
            s = s.ToLower();
            String[] str = input.Split();
            int c = 0;
            for (int i=0;i<str.Length;i++)
            {
                
                    if (str[i] == s)
                    
                        c++;
                        
            }
            Console.Write(c);
            Console.ReadLine(); 
        }
    }
}
