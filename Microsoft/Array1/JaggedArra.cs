using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class JaggedArra
    {
        static void Main(string[] args)
        {
           /* int[,] aa = new int[3, 4];*/
            int[][] arr = new int[4][];
            arr[0] = new int[4];
            arr[1] = new int[2];
            arr[2] = new int[6];
            for(int i=0;i<arr.GetLength(0);i++)
            {
                Console.WriteLine($"Enter {arr[i].Length} elements in row {i} ");
                for(int j=0;j<arr[i].Length;j++)
                {
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Array is ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " \n");
                }
            }
            Console.ReadLine();
        }
    }
}
