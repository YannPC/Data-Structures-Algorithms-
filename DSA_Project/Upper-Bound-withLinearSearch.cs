using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class Upper_Bound_withLinearSearch
    {
        public void UpperBoundWithLinearSearch()
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            int target = 11;

            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            int upperBoundindex = findHigherBound(arr, target);
            if (upperBoundindex != -1)
            {
                Console.WriteLine($"\nUpper bound of {target} is at index: {upperBoundindex}");
            }
            else if (upperBoundindex >= target)
            {
                Console.WriteLine($"\nNo lower bound found for {target} in the array, so displaying length of index {upperBoundindex}.");
            }
        }


        private int findHigherBound(int[] arr, int target)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= target)
                {
                    return i+1;
                }
            }
            return n;
        }
    }
}
