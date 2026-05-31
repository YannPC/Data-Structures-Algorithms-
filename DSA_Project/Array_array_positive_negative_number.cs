using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class Array_array_positive_negative_number
    {

        public void SeparatePositiveNegative()
        {
            int[] arr = { -1, 2, -3, 4, -5, 6 };
            int[] result = new int[arr.Length];
            int posIndex = 0;
            int negIndex = arr.Length - 1;
            foreach (int num in arr)
            {
                if (num >= 0)
                {
                    result[posIndex++] = num;
                }
                else
                {
                    result[negIndex--] = num;
                }
            }
            Console.WriteLine("Separated Array: " + string.Join(", ", result));
        }
    }
}
