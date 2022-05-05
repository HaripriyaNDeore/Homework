using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class CharSort
    {
        static void Main(string[] args)
        {
            char[] ch = { 'r', 'f', 'a', 'h', 'A', 'i' };
            foreach(char c in ch)
            {
                Console.WriteLine(c+" ");
            }
            for(int i=0;i<ch.Length;i++)
            {
                for(int j=i+1;j<ch.Length;j++)
                {
                    if(ch[i]>ch[j])
                    {
                        char temp = ch[i];
                        ch[i]= ch[j];
                        ch[j]= temp;
                    }
                }
            }
            Console.WriteLine();
            foreach (char c in ch)
            {
                Console.WriteLine(c + " ");
            }
        }
    }
}
