using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ForLoop
{
    class atoz
    {
        static void Main(string[] args)
        {
            char ch;
            for(ch='a';ch<='z';ch++)
            {
                Console.WriteLine(ch);
            }
            Console.Read();
        }
    }
}
