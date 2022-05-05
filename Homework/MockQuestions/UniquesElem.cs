using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MockQuestions
{
    class UniquesElem
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            Console.Write("Enter size of array :");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of elements in the array :", size);
            for (int i = 0; i < size; i++)
            {
                Console.Write(i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                int ctr = 0;
                for (int j = 0,k=size; j < k + 1; j++)
                {
                    if (i != j)
                    {
                        if (arr1[i] == arr1[j])
                        {
                            ctr++;
                        }
                    }
                }
                if (ctr ==0)
                {
                    Console.WriteLine("Unique Elements is "+arr1[i]);
                }
                Console.ReadLine();
            }
        }
    }
}
