using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Test26March
{
    class EvenOddSquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It Will Print Even Number As It Is & Square Of Odd Number ");
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.Write(i+",");
                }
                else
                {
                    int num = i * i;
                    Console.Write(num + ",");
                }
            }
            Console.Read();
        }
    }
}
