using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class Binear_Search_find_the_key
    {
        public void BinearSearchFindTheKey()
        {
            int[] binearyTreeArray = new int[10] { 2,4,6,10,14,18,21,24,29,30 };

            int n = binearyTreeArray.Length;

            int key = 18;

            int low = 0;
            int high = n - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (binearyTreeArray[mid] == key)
                {
                    Console.WriteLine($"Key {key} found at index {mid}.");
                    return;
                }
                else if (binearyTreeArray[mid] < key)
                {
                    low = mid + 1; // Search in the right half
                }
                else
                {
                    high = mid - 1; // Search in the left half
                }
            }
        }
    }
}
