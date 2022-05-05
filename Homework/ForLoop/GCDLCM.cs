using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ForLoop
{
    class GCDLCM
    {
        static void Main(string[] args)
        {
            int gcd = 0,lcm;
            Console.WriteLine("Enter the first number");
            int fno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int sno = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= fno && i <= sno; i++)
            {
                if (fno % i == 0 && sno % i == 0)
                {
                    gcd = i;
                }

            }
            Console.WriteLine("GCD of "+ fno+" & "+sno+ " is "+gcd);
            //for lcm
            int max= fno > sno ? fno : sno;
             for(int i=0;i<max;i++)
             {
                 if(max% fno == 0 && max% sno == 0)
                 {
         	        lcm=max;
                    break;
                 }
                 max++;
             }
            Console.WriteLine("LCM of " + fno + " & " + sno + " is " + max);



            Console.Read();

        }
    }
}
