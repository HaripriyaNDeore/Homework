using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ForLoop
{
    class febonacci
    {
        static void Main(string[] args)
        {
            int FTerm = 0, STerm = 1;
            Console.WriteLine("Enter the number to display Fibonacci series till that number");
            int no = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= no; i++)
            {
                Console.Write(FTerm+",");
                int NTerm = FTerm + STerm;
                FTerm = STerm;
                STerm = NTerm;
            }
            Console.Read();

        }
    }
}
