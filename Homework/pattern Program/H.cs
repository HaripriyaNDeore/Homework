using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.pattern_Program
{
    class H
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
               
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 3&&(j==1||j==2||j==3||j==4||j==5))
                    {
                        Console.Write("H");
                    }
                    else if (j == 1 || j == 5)
                    {
                        Console.Write("H");
                    }
                    else
                    {
                        Console.Write(" ");
                    }


                }
                Console.WriteLine("");
            }
            Console.WriteLine();
            Console.WriteLine();

            ///#@#@#
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                   if(j==1||j==3||j==5)
                    {
                        Console.Write("#");
                    }else if (j == 2 || j == 4)
                    {
                        Console.Write("@");
                    }
                   
                    
                }
                Console.WriteLine("");
            }

            Console.WriteLine();
            Console.WriteLine();

            //I

            for (int r = 1; r <= 6; r++)
            {
                for (int c = 1; c <= 6; c++)
                {
                    if (r == 1 ||r==6 && (c == 1 || c == 2 || c == 3 || c == 4 || c == 5 || c == 6))
                    {
                        Console.Write("I");
                    }
                    else if (c == 3 && (r == 1 || r == 2 || r == 3 || r == 4 || r == 5 || r == 6))
                    {
                        Console.Write("I");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }


            Console.WriteLine();
            Console.WriteLine();
            for (int r = 1; r <= 5; r++)
            {

                for (int c = 1; c <= 5; c++)
                {
                     if (c == 1 || c == 5)
                    {
                        Console.Write("N");
                    }
                    else if ((c==1 && r==1)||(c==2 && r==2)||(c==3 && r==3)||(c==4 &&r==4)||(c==5 && r==5))
                    {
                        Console.Write("N");
                    }
                    else
                    {
                        Console.Write(" ");
                    }


                }
                Console.WriteLine("");
            }

            Console.WriteLine();
            Console.WriteLine();
            for (int r = 1; r <= 5; r++)
            {

                for (int c = 1; c <= 6; c++)
                {
                     if ((r == 1 && c == 1) || (r == 2 && c == 2) || (r == 3 && c ==3) || (r ==2 && c == 4) || (r == 1 && c == 5))
                    {
                        Console.Write("Y");
                    }
                    else if((r==4 &&c==3)||(r==5 && c==3)||(r==6 && c==3))
                    {
                        Console.Write("Y");
                    }
                     else
                    {
                        Console.Write(" ");
                    }


                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            for (int r = 1; r <= 6; r++)
            {

                for (int c = 1; c <= 6; c++)
                {
                    if (r == 1 || r == 6 && (c == 1 || c == 2 || c == 3 || c == 4 || c == 5 || c == 6))
                    {
                        Console.Write("Z");
                    }
                    else if ((r == 2 && c == 5) || (r == 3 && c == 4) || (r == 4 && c == 3) || (r == 5 && c == 2))
                    {
                        
                        Console.Write("N");
                    }
                    else
                    {
                        Console.Write(" ");
                    }


                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            for (int r = 1; r <= 7; r++)
            {

                for (int c = 1; c <= 7; c++)
                {
                    if (r == 1 || r == 4 ||c==1||c==7)
                    {
                        Console.Write("A");
                    }
                    else 
                    {
                        Console.Write(" ");
                    }


                }
                Console.WriteLine("");
            }

            Console.Read();
        }
    }
}
