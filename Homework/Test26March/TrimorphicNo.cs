using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Test26March
{
    class TrimorphicNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check whether it is trimorphic or not");
            int number = Convert.ToInt32(Console.ReadLine());
            int cube = number * number * number;
            int flag = 0;
            while (number > 0)
            {
                if (number % 10 != cube % 10)
                {
                    flag = 1;
                    break;
                }
                number = number / 10;
                cube = cube / 10;
            }
            if (flag == 0)
            {
                Console.WriteLine("Trimorphic Number");
            }
            else
            {
                Console.WriteLine("Not Trimorphic Number");
            }
            Console.ReadLine();
        }
    }
}
