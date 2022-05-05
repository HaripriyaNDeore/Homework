using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.MyException
{
    class NulRefRangEx
    {
        static void Main(string[] args)
        {
            int no = Convert.ToInt32(Console.ReadLine());
            int divider = 0;
            try
            {
                try
                {
                    var result = no / divider;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("In catch");
                }
            }
            catch
            {
                Console.WriteLine("Outer catch");
            }
            Console.ReadLine();
        }
    }
}
