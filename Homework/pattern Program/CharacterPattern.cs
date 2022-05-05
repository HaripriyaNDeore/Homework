using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.pattern_Program
{
    class CharacterPattern
    {
        static void Main(string[] args)
        {

            int alphabet = 65;

            Console.WriteLine("Enter Number Of Rows");
            int r1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 6; i=i+2)
            {
                for (int space = 1; space < r1 - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write((char)(alphabet + j*2) + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
