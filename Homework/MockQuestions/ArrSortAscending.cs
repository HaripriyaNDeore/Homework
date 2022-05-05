using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class ArrSortAscending
    {
        static void Main(string[] args)
        {
            string[] sarr = { "Ankita", "roshani", "riya", "trisha", "mira", "vaidehi", "nitya", "gauravi", "ichha", "hrudaya" };
            string[] s = { };
            foreach (var item in sarr)
            {
                Console.WriteLine(item);
            }
            //Array.Sort(sarr);
            // int size = sarr.Length;
            for (int i = 0; i < sarr.Length; i++)
            {
                for (int j = i + 1; j < sarr.Length; j++)
                {
                    if (sarr[i].CompareTo(sarr[j]) > 0)
                    {
                        string t = sarr[i];
                        sarr[i] = sarr[j];
                        sarr[j] = t;
                    }
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("String in decending order");
            Console.WriteLine(" ");
            foreach (var item in sarr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
