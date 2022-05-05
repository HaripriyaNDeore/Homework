using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class SearchElement1
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 7, 9, 3, 17, 4, 6 };
            Console.WriteLine("Display the array:");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Enter element to search ");
            int no = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 0)
                {
                    num[i] = no;
                }
            }
            Console.WriteLine($"{no} Element is present ");
            Console.ReadLine();
        }
    }
}
