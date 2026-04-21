using System;

namespace DSA_Project
{
    internal class SortedArray
    {
        public void SortArrayMethod()
        {
            int[] array = new int[5] { 10, 20, 30, 4, 50 };

            if (array == null || array.Length < 2)
            {
                Console.WriteLine("Array is sorted: True");
                return;
            }

            int n = array.Length;

            // Assume sorted until we find a counterexample
            bool sortedArray = true;

            Console.WriteLine("Original Array:");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }

            for (int i = 1; i < n; i++)
            {
                if (array[i - 1] > array[i])
                {
                    sortedArray = false;
                    break; // no need to check further
                }
            }

            Console.WriteLine($"\nIs the Array sorted: {sortedArray}");
        }
    }
}
