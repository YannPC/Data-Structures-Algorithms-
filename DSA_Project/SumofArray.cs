using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class SumofArray
    {
        public void SumOfArray()
        {
            int [] numbers = new int[5] { 1, 2, 3, -2, 5 };

            int sum = 0;

            Console.WriteLine("The numbers in the array are: ");

            foreach(int numb in numbers )
            {
                Console.Write(numb + " "); 
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("\nThe sum of the array is: " + sum);
        }
    }
}
