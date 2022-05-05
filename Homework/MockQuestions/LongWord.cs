using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class LongWord
    {
        static void Main(string[] args)
        {
            int max = 0;
            Console.Write("Enter a string :");
            string word = Console.ReadLine();
            string[] s1 = word.Split(' ');
            int size= word.Length;

            for (int i = 0; i < size; i++)
            {
                if (size> max)
                {
                    max = word[i];
                }
            }
            Console.WriteLine("Longest string"+ max);
            Console.ReadLine();
        }
    }
}
