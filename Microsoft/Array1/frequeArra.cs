using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class frequeArra
    {
         static void Main(string[] args)
         {
                int[] arr = new int[] { 10, 20, 20, 10, 10, 20, 5, 20 };
                int n = arr.Length;
                int count=0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("frequency of "+arr);
                    Console.WriteLine(arr[i] + " " + count);
                }
            
        }
    }
}
