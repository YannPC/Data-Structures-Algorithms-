using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class RemoveDuplicatesFromSortedArray
    {
        public void RemoveDuplicatesfromSortedArray()
        {
                int[] numbers = new int[10] { 1, 2, 2, 3, 4, 5, 5, 6, 7, 8 };

               Console.WriteLine("Original Array: ");
    
                foreach (int number in numbers)
                {
                Console.Write(number + " ");
                }

            int newSize = removeDuplicateFromArray(numbers);

            Console.WriteLine("\nCorrect Array without Duplicate");

            for (int i = 0; i < newSize; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // Call the helper that does the actual duplicate removal and prints the result
            //RemoveDuplicatesFromSortedArrayMethod(numbers);
           
            //removeDuplicateFromArray(numbers);
        }

       public  int  removeDuplicateFromArray(int[] array)
        {
            int n = array.Length;
            int newSizeofArray = 0;
            HashSet<int> duplicateNumber = new HashSet<int>();
        
            for (int  i = 0; i < n; i++)
            {
                if(!duplicateNumber.Contains(array[i]) )
                {
                    duplicateNumber.Add(array[i]);
                    array[newSizeofArray++] = array[i];
                }

            }

            return newSizeofArray;
        }
    }
}
