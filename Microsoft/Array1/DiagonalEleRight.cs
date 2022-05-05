using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class DiagonalEleRight
    {
        static void Main(string[] args)
        {
            int r, c, ele, n, m = 0;
            int[,] arr1 = new int[50, 50];

            Console.Write("Enter  the size of the matrix : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter elements in the matrix :\n");
            for (r = 0; r < n; r++)
            {
                for (c = 0; c < n; c++)
                {
                    Console.Write("element - [{0}],[{1}] : ", r, c);
                    arr1[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The matrix is :\n");
            for (r = 0; r < n; r++)
            {
                for (c = 0; c < n; c++)
                    Console.Write("{0}  ", arr1[r, c]);
                Console.WriteLine(" ");
            }

            //
            Console.WriteLine("right Diagonal elements is");
            for (r = 0; r < n; r++)
            {

                for (c = 0; c < n; c++)
                {

                    if (r == c)
                    {
                        Console.WriteLine(arr1[r, c]);
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
