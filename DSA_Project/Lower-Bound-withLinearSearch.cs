using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class Lower_Bound_withLinearSearch
    {
        public void LowerBoundWithLinearSearch()
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            int target = 20;

            foreach (int num in arr)
            {
                Console.Write(num+ " ");
            }   
            int lowerBoundIndex = FindLowerBound(arr, target);
            if (lowerBoundIndex != -1)
            {
                Console.WriteLine($"\nLower bound of {target} is at index: {lowerBoundIndex}");
            }
            else if (lowerBoundIndex >= target)
            {
                Console.WriteLine($"\nNo lower bound found for {target} in the array, so displaying length of index {lowerBoundIndex}.");
            }   
        }

        private int FindLowerBound(int[] arr, int target)


        {
            int n = arr.Length;

            for (int i = 0; i <n ; i++)
            {
                if (arr[i] >= target)
                {
                    return i;
                }

            }
            return n; 
        }
    }
}
