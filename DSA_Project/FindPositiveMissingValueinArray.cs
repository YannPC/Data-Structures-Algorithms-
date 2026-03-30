using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class FindPositiveMissingValueinArray
    {
        public void FindPositiveValueinArray()
        {
            int[] arr = new int[5] { 0, 1, 3, -3, -5 };

            Console.WriteLine("List of Array Positive and negative");

            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }

            FindPositiveValue(arr);
        }

        public void FindPositiveValue(int[] number)
        {
            int n = number.Length;

            HashSet<int> positive = new HashSet<int>();  

            for (int i = 0; i < n; i++)
            {
                if (number[i] > 0)
                {
                    positive.Add(number[i]);
                }
            }

            int missingValue = 1;

            while (positive.Contains(missingValue))
            {
                missingValue++;
            }

            Console.WriteLine("\nThe smallest positive missing value in the array is: " + missingValue);
        }
    }
}
