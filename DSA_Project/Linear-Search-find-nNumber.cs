using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class Linear_Search_find_nNumber
    {
        public void LinearSearchFindNumber()
        {
            int[] linearSearchArr = new int[5] { 4, 7, 9 ,10, 15 };

            int n = linearSearchArr.Length;

            int key = 10;

            foreach(int number in linearSearchArr)
            {
                
                {
                    Console.Write(" " +number);
                   
                }
            }

            for (int  i = 0;  i <n;  i++)
            {
                if (linearSearchArr[i] == key)
                {
                    Console.WriteLine($"\nKey {key} found at index {i}.");
                    return;
                }

            }
        }
    }
}
