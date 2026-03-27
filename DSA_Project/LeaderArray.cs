using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class LeaderArray
    {
        public void LeaderOfTheArray()

        // to dertmine the leader of the array we need to find the largest number in the array and
        // then we need to find all the numbers that are greater than or equal to that number and then
        // we need to print those numbers as the leader of the array

        {

            int[] numbers = new int[6] {16,17, 4, 3, 5,2};

            Console.WriteLine("The Leader of the Array is: ");

            foreach (int number in numbers)
            {
   
                    Console.Write(number + " ");
            }

            FindLeaderOfTheArray(numbers);
        }

        /*
         * How to solve this problem:
         * First to use MaxLeader it can be the last element of the array
         * after store in the list 
         * then need to read the Loops from Right to left and compare the MaxLeader with the current element if the current element is greater than or equal to the MaxLeader then we need to update the MaxLeader and store it in the list
         */


        public void FindLeaderOfTheArray(int[] array )

        {
            int n = array.Length;
            int FirstLeader = array[n - 1];

            List<int> Leaders = new List<int> { FirstLeader };

            for (int i = n-2 ; i >= 0; i--)
            {
                if (array[i] >= FirstLeader)
                {
                    FirstLeader = array[i];
                    Leaders.Add(FirstLeader);
                }
            }

            // the leaders are stored in the list in reverse order so we need to reverse the list to print the leaders in the correct order

            Leaders.Reverse();

            Console.WriteLine("The Leader of the Array is: ");

            foreach (int leader in Leaders)
                {
                Console.Write(leader + " ");
            }

        }
    }
}
