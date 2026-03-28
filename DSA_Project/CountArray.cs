using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class CountArray
    {
        public void CountArrayMethod()
        {
            int[] numbers = new int[8] { 3, 1, 2, 2, 1, 2, 3, 3 };

            foreach(int value in numbers)
            {
                Console.Write(value + " ");
            }
            
            Console.Write("\nCount appear");

             CountArrayMethodFunction(numbers);


        }

        public void CountArrayMethodFunction(int[] array)
        {
            int n = array.Length;

            int k = n-4; // the range of the numbers in the array is from 1 to n-4

            int count;

            for (int i = 1; i <= n; i++)
                {
                    count = 0;
    
                    for (int j = 0; j < n; j++)
                    {
                        if ((array[j] == i))
                    {
                            count++;
                        }
                     
                    }
                    if (count > n/k)

                    Console.WriteLine("\nNumber " + i + " appears " + count + " times in the array.");
                    
            }
        }
    }
}
