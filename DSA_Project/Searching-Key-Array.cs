using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class Searching_Key_Array
    {
        public void SearchKeyArray()
        {
            int [] arrayNumber = new int[5] { 2, 6, 1, 7, 2 };

            int n = arrayNumber.Length;

            int key = 7;

            Console.WriteLine("List of Array Number");

            foreach (int i in arrayNumber)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nKey to search: " + key);
            

            for (int i = 0; i < n; i++)
            {
                if ( arrayNumber[i] == key)
                {
                    Console.WriteLine($"Key {key} found at index: {i}");
                    break; // stop searching after finding the key
                } 
                //else 

                //    {
                //    Console.WriteLine($"Key {key} not found at index: {i}");
                //}
            }

            
        }
    }
}
