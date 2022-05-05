using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ForLoop
{
    class tableNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to print the table");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(no + "table is..");
            for (int i=1;i<=10;i++)
            {
                 Console.WriteLine(no*i);
            }
            Console.Read();
            
        }
    }
}
