using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class Array_String_remove_occurence
    {
        public void RemoveOccurence()
        {
            string str = "geeksforgeeks";
            string c = "e";

            string result = str.Replace(c, "");
            Console.WriteLine("Original String: " + str);
        }
    }
}
