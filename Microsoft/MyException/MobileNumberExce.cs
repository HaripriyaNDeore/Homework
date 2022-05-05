using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.MyException
{
    class MobileNumberExce
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Enter mobile number");
                long mobileNo = long.Parse(Console.ReadLine());
                int c = 0;
                while(mobileNo>0)
                {
                    c++;
                    mobileNo = mobileNo / 10;
                }
            if (c != 10)
                Console.WriteLine("valid mobile number");
            else
                throw new InvalidMobileException("Mobile no sholud be 10 digit");


        }
    }
    class InvalidMobileException:ApplicationException
    {
        public InvalidMobileException(string m):base(m)
        {

        }
    }
}
