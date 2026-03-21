using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA_Project
{
    internal class SortedbyNumber
    {
        public void sortedbyNumber()
        {
            int[] numbers = new int[5] {5,3,1,4,2};

           foreach(int number in numbers)
            {
                Console.Write(number + " ");
            }

          sortedNumer(numbers);

            Console.WriteLine("\nSorted Array: ");
            foreach (int numb in numbers )
            {
                Console.Write(numb + " ");
            }

        }

        public void sortedNumer(int[] array )

        {
            int n = array.Length;

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
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
