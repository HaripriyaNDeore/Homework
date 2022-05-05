using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class PrintNoInDescendingO
    {
        static void Main(string[] args)
        {
            int[] NoArr = { 1, 5, 7, 9, 3, 4, 6, 10, 8 };
          
            Console.WriteLine("Oroginal Array is");
            foreach (var item in NoArr)
            {
                Console.Write(item+",");
            }

            for (int i=0;i<NoArr.Length;i++)
            {
                for(int j=i+1;j<NoArr.Length;j++)
                {
                    if(NoArr[i].CompareTo(NoArr[j])<0)
                    {
                        int t = NoArr[i];
                        NoArr[i] = NoArr[j];
                        NoArr[j] = t;
                    }
                }
            }
            Console.WriteLine("Array is in decending oreder is");
            foreach(var item in NoArr)
            {
                Console.Write(item+",");
            }
            Console.ReadLine();

        }
    }
    class Program
    {
        static void Main()
        {
            int[] Numbers = { 2, 5, 3, 1, 4 };
            Console.WriteLine("Printing the numbers in the array without sorting");
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Printing the numbers in the array after sorting");
            Array.Sort(Numbers);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Printing the numbers in the array in desceding order");
            Array.Reverse(Numbers);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
