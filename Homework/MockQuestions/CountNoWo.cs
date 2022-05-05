using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class CountNoWo
    {
        static void Main(string[] args)
        {
            int l = 0;
            int wrd = 1;
            Console.Write("Input the string : ");
            string str = Console.ReadLine();
            while (l <= str.Length - 1)
            {
               
                if(str[l] == ' ' || str[l] == '\n' || str[l]=='\t')
                {
                    wrd++;
                }

                l++;
            }
            Console.Write("Total number of words in the string is : {0}\n", wrd);
            Console.ReadLine();
        }
    }
}
