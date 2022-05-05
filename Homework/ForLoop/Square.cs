using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ForLoop
{
    class Square
    {
        static void Main(string[] args)
        {
            int num,squ;
            Console.WriteLine("Square number");
            for ( num = 1; num < 20; num++) ;
            {
                squ = num * num;//

                Console.WriteLine("Square of  1 to 20 "+squ);

            }
            Console.Read();
        }
    }
}
