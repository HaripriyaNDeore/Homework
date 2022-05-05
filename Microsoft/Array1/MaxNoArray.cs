using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class MaxNoArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 45;
            arr[1] = 66;
            arr[2] = 87;
            arr[3] = 2;
            arr[4] = 12;
            int max = arr[0];

            for (int i = 0; i < 5; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
