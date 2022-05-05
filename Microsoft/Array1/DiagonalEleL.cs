using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class DiagonalEleL
    {
        static void Main(string[] args)
        {
            int r, c, ele, n, m = 0;
            int[,] arr1 = new int[50, 50];

            Console.Write("Enter  the size of the matrix : ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;
            Console.WriteLine("Enter elements in the matrix : ");
            for (r = 0; r < n; r++)
            {
                for (c = 0; c < n; c++)
                {
                    Console.Write("element - [{0}],[{1}] : ", r, c);
                    arr1[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is :");
            for (r = 0; r < n; r++)
            {
                for (c = 0; c < n; c++)
                    Console.Write("{0}  ", arr1[r, c]);
                Console.WriteLine(" ");
            }

            //
            Console.WriteLine("Left Diagonal elements is");
            for (r = 0; r < n; r++)
            {
                m = m - 1;
                for (c = 0; c < n; c++)
                {
                    if (c == m)
                    {
                        Console.WriteLine(arr1[r, c]);
                    }

                }
            }


            Console.ReadLine();

        }
    }
}
