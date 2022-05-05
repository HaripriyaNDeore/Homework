using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class CopyToMe
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 2, 5, 3, 1, 4 };
            int[] CopyOfNumbers = new int[5];
            Numbers.CopyTo(CopyOfNumbers, 0);
            foreach (int i in CopyOfNumbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
