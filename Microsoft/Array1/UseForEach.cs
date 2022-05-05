using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class UseForEach
    {
        static void Main(string[] args)
        {
            string[] s = { "sunday", "monday", "tuesday", "wedsday", "thusday", "friday", "saturday" };
            foreach(string stri in s)
                Console.WriteLine(stri);
            Console.ReadLine();
        }
    }
}
