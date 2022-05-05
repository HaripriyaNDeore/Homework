using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Stri
{
    class Str1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s1 = Convert.ToString(Console.ReadLine());
            string upp=s1.ToUpper();
            Console.WriteLine("Upper Case String is "+upp);

            string low = s1.ToLower();
            Console.WriteLine("Lower Case String is " + low);

            Console.WriteLine("After Spliting string is ");
            for(int i=0;i<s1.Length;i++)
            {
                Console.WriteLine(s1[i]);
            }
            Console.WriteLine("After Spliting string in Reverse order");
            for (int i = s1.Length-1; i >=0; i--)
            {
                Console.WriteLine(s1[i]);
            }
            Console.ReadLine();

        }
    }
}
