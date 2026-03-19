using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class Array_find_the_second_higest_number
    {
        public void FindSeoncHighestValue()
        {
            int[] numbers = new int[5] { 17, 20, 76, 49, 10 };

            int highestValue = numbers[0];

            int secondHighestValue = numbers[1];

            Console.WriteLine("Numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\nInitial Highest Value: " + highestValue);

            Console.WriteLine("Initial Second Highest Value: " + secondHighestValue);

            foreach (int numb in numbers)
            {
                if (numb > highestValue)
                {
                    secondHighestValue = highestValue;
                    highestValue = numb;
                }
                /*
                 * •	Array: int[] numbers = { 5, 17, 3, 17, 9, 12 };
                 * •	See 9:
                    •	9 > secondHighest (5) and 9 != highest (17) → update secondHighest = 9
                    •	See 12:
                       •	12 > secondHighest (9) and 12 != highest (17) → update secondHighest = 12
                 * 
                 */
                else if (numb > secondHighestValue && numb != highestValue)
                {
                    secondHighestValue = numb;
                }

            }
            Console.WriteLine("Official Highest Value: " + highestValue);
            Console.WriteLine("Official Second Highest Value: " + secondHighestValue);
        }
    }
    
}
