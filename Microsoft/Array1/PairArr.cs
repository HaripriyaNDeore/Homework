using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class PairArr
    {
        static void Main(string[] args)
        {
            int[] array ={2, 4, 3, 5, 6, -2, 4, 7, 8, 9};
            int sum = 10;

            for(int i=0;i<array.Length;i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[i]+array[j]==sum)
                        Console.WriteLine($"Pair is with sum 10 is { array[i]}+{array[j]}");
                }
            }
            Console.ReadLine();
        }
    }
}
