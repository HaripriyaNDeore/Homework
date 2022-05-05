using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ObjOri
{
    class ArmStr1
    {

        static void Main(string[] args)
        {
            int no, rev, sum = 0, temp;
            Console.WriteLine("Enter the No to check whether no is armstrong  storng or not");
            no = Convert.ToInt32(Console.ReadLine());
            int no1 = no;
            while (no > 0)
            {
                rev = no % 10;
                sum = sum + (rev * rev * rev);
                no = no / 10;
            }
            if (no1 == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
        }

    }
    
}
