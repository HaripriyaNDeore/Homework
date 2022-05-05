using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.SimpleProgram
{
    class discount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount:");
            int bill = Convert.ToInt32(Console.ReadLine());
            int Discount = (bill * 20 / 100);
            int Netpay = bill - Discount;
            Console.WriteLine("After discount your bill is: " + Discount);
            Console.WriteLine("Netpay is: " + Netpay);
            Console.Read();
        }
    }
}
