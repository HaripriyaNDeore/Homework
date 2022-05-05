using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ForLoop
{
    class BaseIndex
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the base");
            int ba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the index");
            int power = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (; power != 0; power--)
            {
                result = result * ba;
            }
            Console.WriteLine("power of number is "+result);
            Console.Read();

        }

    }
}
