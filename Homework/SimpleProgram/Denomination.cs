using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.SimpleProgram
{
    class Denomination
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            int n2000 = amount / 2000;
            amount = amount % 2000;

            int n500 = amount / 500;
            amount = amount % 500;

            int n100 = amount / 100;
            amount = amount % 100;

            int n50 = amount / 50;
            amount = amount % 50;

            int n20 = amount / 20;
            amount = amount % 20;

            int n10 = amount / 10;
            amount = amount % 10;

            int n5 = amount / 5;
            amount = amount % 5;

            int n2 = amount / 2;
            amount = amount % 2;

            int n1 = amount / 1;
            amount = amount % 1;

            Console.WriteLine("Notes of 2000="+n2000);
            Console.WriteLine("Notes of 500=" + n500);
            Console.WriteLine("Notes of 100=" + n100);
            Console.WriteLine("Notes of 50=" + n50);
            Console.WriteLine("Notes of 20=" + n20);
            Console.WriteLine("Notes of 10=" + n10);
            Console.WriteLine("Notes of 2=" + n2);
            Console.WriteLine("Notes of 1=" + n1);

            Console.ReadLine();




        }
    }
}
