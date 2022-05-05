using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.whileLoop
{
    class CountDigit
    {
        static void Main(string[] args)
        {
            int n;   
            int count = 0;    
            Console.WriteLine( "Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                n = n / 10;
                count=count+1;
            }

            Console.WriteLine("The number of digits in an integer is :"+count);
            Console.ReadLine();
        }
    }
}
