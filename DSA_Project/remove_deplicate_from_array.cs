using System;
using System.Collections.Generic;

namespace DSA_Project
{
    internal class remove_deplicate_from_array
    {
        public void RemoveDuplicate()
        {
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 2, 3, 6, 7, 8 };

            Console.WriteLine("Original Array: ");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            // Call the helper that does the actual duplicate removal and prints the result
            RemoveDuplicateFromArray(numbers);
        }

        public void RemoveDuplicateFromArray(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("\nArray is empty or null.");
                return;
            }

            // HashSet does not implement IDisposable, so do NOT use a 'using' declaration here.
            //•	We use HashSet<int> because it gives fast membership tests and enforces uniqueness. That makes removing duplicates simple and efficient.
            var uniqueNumbers = new HashSet<int>();
            var result = new List<int>();

            foreach (int number in array)
            {
                //
                if (uniqueNumbers.Add(number)) // Add returns true only on first occurrence
                {
                    result.Add(number);
                }
            }

            Console.WriteLine("\nArray after removing duplicates (preserving order):");
            foreach (int number in result)
            {
                Console.Write(number + " ");
            }
        }
    }
}
