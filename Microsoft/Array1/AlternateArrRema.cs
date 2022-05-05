using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Recur
{
    class AlternateArrRema
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4};
            int[] b = {5, 6, 7, 8, 9, 10 };
            int[] c = new int[a.Length+b.Length];
            int k = 0;
            for (int i = 0;i<c.Length; i++)
            {
                if(k<a.Length && k<b.Length)
                {
                    c[i] = a[k];
                    i++;
                    c[i] = b[k];
                    i++;
                }
                else if(k<a.Length)
                {
                    c[i] = a[k];
                    i++;
                }
                else
                {
                    c[i] = b[k];
                    i++;
                }
               for(i=0;i<c.Length;i++)
               Console.WriteLine(c[i]+" ");
                Console.ReadLine();
            }
        }
    }
}
