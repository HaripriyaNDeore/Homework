using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.SimpleProgram
{
    class ConvertRsttodollar
    {
        static void Main(string[] args)
        {
            int rupees, dollar;
            Console.WriteLine("Enter the Rupees");
            rupees = Convert.ToInt32(Console.ReadLine());
            dollar = rupees / 64;
            Console.WriteLine("The amount of  "+rupees+"into dollar is "+dollar);
            Console.Read(); 
            
        }
    }
}
