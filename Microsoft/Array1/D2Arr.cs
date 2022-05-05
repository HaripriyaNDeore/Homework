using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class D2Arr
    {
        static void Main(string[] args)
        {
            int[,] aa = new int[5, 3];
            for (int r = 0; r < aa.GetLength(0); r++)
            {
                Console.WriteLine("Enter Elements for row"+r);
                for (int c = 0; c < aa.GetLength(1); c++)
                {
                    aa[r, c] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("Array is ");
            for (int r = 0; r < aa.GetLength(0); r++)
            {
                for (int c = 0; c < aa.GetLength(1); c++)
                {
                    Console.Write(aa[r, c] + " \n");
                }
            }
            int max = aa[0, 0];
            for (int r = 0; r < aa.GetLength(0); r++)
            {
                for(int c = 0; c < aa.GetLength(1); c++)
                    {
                    if (aa[r, c] > max)
                    {
                        max = aa[r, c];
                    }
                }

            }
            Console.WriteLine("Maximum element:" + max);
            Console.ReadLine();
        }
    }
}
