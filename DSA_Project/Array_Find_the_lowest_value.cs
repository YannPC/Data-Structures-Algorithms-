using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class Array_Find_the_lowest_value
    {
        public void FindLowestValue()
        
        {
            int[] accountNumber = new int[5] { 12345, 54321, 67890, 98765, 11111 };


            int lowestValue = accountNumber[0];

            // display the array 
            Console.WriteLine("Account Numbers:");
                for (int i = 0; i < accountNumber.Length; i++)
                {
                    Console.Write(accountNumber[i] + " ");
            }
           
            Console.WriteLine("\nInitial Lowest Value: " + lowestValue);

            foreach(int number in accountNumber)
            {
                if(number >= lowestValue)
                {
                    continue;
                }
                else
                {                    
                    lowestValue = number;
                }
                Console.WriteLine("Official Lowest Value: " + lowestValue);
            }
        }
    }
}
