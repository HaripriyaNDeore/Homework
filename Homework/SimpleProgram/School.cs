using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class School
    {
        static void Main(string[] args)
        {
            int m1, m2, m3, m4, m5;
            float avg;
            Console.WriteLine("Enter marks of first Subject=");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of second Subject=");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of third Subject=");
            m3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of fourth Subject=");
            m4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of fifth Subject=");
            m5 = Convert.ToInt32(Console.ReadLine());

            avg = (m1 + m2 + m3 + m4 + m5) / 5f;
/*            avg = Convert.ToInt32(Console.ReadLine());
*/            Console.WriteLine("Average marks is"+avg);
            Console.Read();

        }
    }
}
