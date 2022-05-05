using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class TotalNumAlphaNuDig
    {
        static void Main(string[] args)
        {
            string s2 = "Find total number of average number 11 and digit 23";
            int avg = 0;int sum = 0;int c = 0;
            for(int i=0;i<s2.Length;i++)
            {
                if(s2[i]>='0' && s2[i]<='9')
                {
                    int x = (int)(char.GetNumericValue(s2[i]));
                    sum = s2[i] + sum;
                    c++;
                }
            }
            Console.WriteLine(" Sum of string is "+sum+"And count is "+c);
            avg = sum / c;
            Console.WriteLine("And average of that number is "+avg);
            Console.ReadLine();
        }
    }
}
