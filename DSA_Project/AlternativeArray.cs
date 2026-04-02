using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class AlternativeArray
    {
        public void AlternativeArrayMethod()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Original Array: " + string.Join(", ", arr));
            for (int i = 0; i < arr.Length - 1; i += 2)
            {
                // Swap arr[i] and arr[i + 1]
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }
            Console.WriteLine("Alternative Array: " + string.Join(", ", arr));
        }   
    }
}
