using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class Count_Digit
    {
        public void CountDigitMethod()
        {
            Console.Write("Enter a positive Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while (n != 0)
            {
                n /= 10; // Remove the last digit from the number 
                //// what the code does is it divides the number by 10, which effectively removes the last digit.
                //// For example, if n is 123, after n /= 10, n becomes 12. If n is 12
                //// , after n /= 10, n becomes 1. If n is 1, after n /= 10, n becomes 0. This process continues until n becomes 0.

                count++; // Increment the count of digits
            }

            Console.WriteLine($"The number of digits in the given number is: {count}");
        }
    }
}
