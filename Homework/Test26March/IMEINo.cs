using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Test26March
{
    class IMEINo
    {
        static void Main(string[] args)
        {
            long sum = 0,c=0;
            Console.WriteLine("Enter 15 digit number");
            long input = long.Parse(Console.ReadLine());
            while(input >0)
            {
                c++;
                input = input / 10;
            }
            Console.WriteLine("Number is digit "+c);
            if(c==15)
            {
                Console.WriteLine("No is 15 digit");
                for(int i=1;i<=15;i++)
                {
                    int d = (int)(input % 10);
                    if(i%2==0)
                    {
                        Console.WriteLine("i"+i+"digit"+d);
                        input = input / 10;
                    }
                    
                    else
                    {

                    }

                }
            }
            else
            {
                Console.WriteLine("No is not 15 digit");
            }

            /*while (input != 0)
            {
                input = input / 10;
                long digit =input % 10;
                 sum = sum +digit;
               
            }
            if(i%2==0)
                    {
                        int dou= 2 * d;
                        if(dou<9)
                        {
                            sum = sum + dou % 10 + dou / 10;
                        }
                    }
            Console.WriteLine("Sum of 15 digit number is "+sum);*/


            /*if(sum/10==0)
            {
                Console.WriteLine("It is IMEI Number");
            }
            else
            {
                Console.WriteLine("It is not IMEI Number");
            }*/
            Console.ReadLine();


        }
    }
}
