using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class MoveArrayZerotoEnd
    {
        public void MoveZeroToEnd()
        {
            int[] numbers = new int[10] { 0, 1, 0, 3, 12, 0, 5, 6, 0, 7 };
            Console.WriteLine("Original Array: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            MoveZeroToEndMethod(numbers);
            Console.WriteLine("\nArray after moving zeros to the end: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

        }

             public void MoveZeroToEndMethod(int[] array)
            {
                int n = array.Length;
                int nonZeroIndex = 0; // This will track the position to place the next non-zero element
                // First pass: Move all non-zero elements to the front
                for (int i = 0; i < n; i++)
                {
                    if (array[i] != 0)
                    {
                        array[nonZeroIndex++] = array[i]; // Place the non-zero element at the nonZeroIndex and then increment it
                    }
                }
                // Second pass: Fill the remaining positions with zeros
                for (int i = nonZeroIndex; i < n; i++)
                {
                    array[i] = 0;
                }
            }
       
    }
}
