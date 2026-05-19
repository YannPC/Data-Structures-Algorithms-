using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class Array_Majority_Element
    {
        public void MajorityElement()
        {
            int[] numbs = { 2, 2, 1, 1, 1, 2, 2 };
            int n = numbs.Length;

            int majorityIndex = n / 2;
            int noMajorityIndex = -1;


            Dictionary<int, int> countMap = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (countMap.ContainsKey(numbs[i]))
                {
                    countMap[numbs[i]]++;
                }
                else
                {
                    countMap[numbs[i]] = 1;
                }

                if (countMap[numbs[i]] > majorityIndex)
                {
                    Console.WriteLine("Majority Element: " + numbs[i]);
                    return;

                }

            }

            Console.WriteLine("No majority element found: " + noMajorityIndex);






        }
    }
}
