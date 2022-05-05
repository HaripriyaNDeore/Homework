using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.pattern_Program
{
    class RowColumn
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No of Rows");
            int ro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter No of Column");
            int colum = Convert.ToInt32(Console.ReadLine());
            for (int i = 1;i <= ro;i++)
            { 
                for (int j = 1; j <= colum; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();




        }
    }
}
