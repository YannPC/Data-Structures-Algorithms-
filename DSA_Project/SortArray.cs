using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class SortArray
    {
        public void SortArrayMethod()
        {
            int[] listOfNumber = new int[5] { 0, 2, 1, 2, 0 };

            foreach (int number in listOfNumber)
            {
                Console.Write(number + " ");
            }

                SortArrayMethodFunction(listOfNumber);

                Console.WriteLine("\nSorted Array: ");

            foreach (int numb in listOfNumber)
                {
                Console.Write(numb + " ");
            }

        }

        public void SortArrayMethodFunction(int[] array )

        {
            int n = array.Length;

            for(int i = 0; i < n-1;i++)
            {
                for (int j =0; j < n-i-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                       // Swap array[j] and array[j + 1]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }

                }
            }
        }
    }
}
