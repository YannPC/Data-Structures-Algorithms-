using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class InverseArray
    {
        // this method will inverse the array
        // for example if the array is [1,2,3,4,5] the output will be [5,4,3,2,1]


        public void InverseArrayMethod()
        {
            int[] numbers = new int[5] { 10, 20, 30, 40, 50 };

            Console.WriteLine("Original Array: ");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\nInverse Array: ");

            InverseArrayMeth(numbers);

        }

        public void InverseArrayMeth(int[] array) 
        { 
            int n = array.Length;

            for ( int i = n-1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
