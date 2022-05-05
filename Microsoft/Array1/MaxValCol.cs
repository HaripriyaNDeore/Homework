using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class MaxValCol
    {
        static void Main(string[] args)
        {
            int[,] aa = new int[5,5];
            int min = aa[0, 0];
            int max = aa[0, 0];

            Console.Write("Enter  the size of the matrix : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int r = 0; r < n; r++)
            {
               
                for (int c = 0; c < n; c++)
                {
                    Console.Write("element - [{0}],[{1}] : ", r, c);
                    aa[r, c] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("Matrix is ");
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                    Console.Write("{0} ",aa[r, c]);
                    Console.WriteLine(" ");
            }

            //Max of Colum
            Console.WriteLine("Maximum value in Colum ");
            for (int c = 0; c < n; c++)
            {
                for (int r = 0; r < n; r++)
                {
                   if (aa[r, c] > max)
                    {
                        max = aa[r, c];
                       
                    }
                   
                }
                Console.WriteLine("Maximum element in Colum  is " + max);
                Console.WriteLine(" ");

            }

            //Min of Colum
           /* Console.WriteLine("Minimum value in Colum ");
            for (int c = 0; c < n; c++)
            {
                for (int r = 0; r < n; r++)
                {
                    if (aa[r, c] < min)
                    {
                        min = aa[r, c];

                    }

                }
                Console.WriteLine("Minimum element in Colum  is " + min);
                Console.WriteLine(" ");

            }*/

            Console.ReadLine();
        }
    }
}
