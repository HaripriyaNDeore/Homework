using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class maxArr
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int i=0;i<5;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arr[0];
            for(int i=0;i<5;i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
            Console.Read();
        }
    }
}
