using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class Toggle
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            char ch;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]>='A' && str[i]<='Z')
                {
                    Console.Write(char.ToLower(str[i]));
                }
                else if (str[i] >= 'a' && str[i] <= 'z')
                {
                    Console.Write(char.ToUpper(str[i]));
                }
                else
                {
                    Console.Write(str[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
