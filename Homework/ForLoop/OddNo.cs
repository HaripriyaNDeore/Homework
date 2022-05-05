using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ForLoop
{
    class OddNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number");
            int fno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            int sno = Convert.ToInt32(Console.ReadLine());
            for (int i = fno; i <= sno; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i+",");
            }



            Console.WriteLine("Odd No between 121 to 229 is ");
            for (int i = 121; i <= 229; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
