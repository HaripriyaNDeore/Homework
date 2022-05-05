using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class PeriSqu
    {
        static void Main(string[] args)
        {
            int side,periSqu;
            Console.WriteLine("Enter the side to calculate Perimeter of square");
            side = Convert.ToInt32(Console.ReadLine());
            periSqu = 4 * side;
            Console.WriteLine("Perimeter of square  "+periSqu);
            Console.Read();

        }
    }
}
