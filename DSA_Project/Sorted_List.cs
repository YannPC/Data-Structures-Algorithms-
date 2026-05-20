using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class Sorted_List
    {
        public void MergeTwoSortedLists()
        {
            int[] list1 = { 1, 3, 5, 7 };
            int[] list2 = { 2, 4, 6, 8 };
            int[] mergedList = new int[list1.Length + list2.Length];
            int i = 0, j = 0, k = 0;
            while (i < list1.Length && j < list2.Length)
            {
                if (list1[i] < list2[j])
                {
                    mergedList[k++] = list1[i++];
                }
                else
                {
                    mergedList[k++] = list2[j++];
                }
            }
            while (i < list1.Length)
            {
                mergedList[k++] = list1[i++];
            }
            while (j < list2.Length)
            {
                mergedList[k++] = list2[j++];
            }
            Console.WriteLine("Merged Sorted List: " + string.Join(", ", mergedList));
        }
    }
}
