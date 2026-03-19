using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    public class Array_Find_the_higest_value
    {
        public void FindHighestValue()
        {
            int[] accountNumber = new int[5] { 12345, 54321, 67890, 98765, 11111 };

            int highestValue = accountNumber[2];

            foreach (int number in accountNumber)

            {
                if (number <= highestValue)
                {
                    continue;
                }
                else
                {
                    highestValue = number;
                }

                Console.WriteLine("Official Highest Value: " + highestValue);
            }
        }
    }
}
