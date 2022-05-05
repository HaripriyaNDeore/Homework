using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Array1
{
    class MaxValRow
    {
        static void Main(string[] args)
        {
                int[,] aa = new int[5, 5];
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
                        Console.Write("{0} ", aa[r, c]);
                    Console.WriteLine(" ");
                }

                //Max of rows
                Console.WriteLine("Maximum value is ");
                for (int r = 0; r < n; r++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        if (aa[r, c] > max)
                        {
                            max = aa[r, c];

                        }
                        

                    }
                    Console.WriteLine("Maximum element in row " + r + " is " + max);
                Console.WriteLine(" ");

                }

                Console.ReadLine();
            
        }
    }
}
