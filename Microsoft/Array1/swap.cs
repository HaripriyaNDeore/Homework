using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class swap
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 4, 3, 5, 6, 2, 4, 7, 8, 9 };
            int n = arr1.Length;
            for (int i = 0; i < n-1; i++)
            {
                for(int j=0;j< arr1.Length;j++)
                {
                    if(arr1[j]>arr1[j+1])
                    {
                        int t = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = t;
                    }
                }
                
            }
            foreach (int d in arr1)
            Console.WriteLine(d + " ");
            Console.ReadLine();


        }
      
    }
}  
