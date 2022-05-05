using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Test26March
{
    class Factor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check factor of that number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factor Of " + num + " is" );
            for(int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    Console.Write(i+",");
                }
            }
            Console.Read();
        }
    }
}
