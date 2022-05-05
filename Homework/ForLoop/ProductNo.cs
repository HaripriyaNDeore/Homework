using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ForLoop
{
    class ProductNo
    {
        static void Main(string[] args)
        {
            int product,rem;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (product = 1; num > 0; num = num / 10)
            {
                rem = num % 10;
                product = product * rem;
            }
            Console.WriteLine("product of given number is"+product);
            Console.Read();
        }
    }
}
