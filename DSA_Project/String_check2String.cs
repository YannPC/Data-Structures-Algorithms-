using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class String_check2String
    {
        public void Scheck2String()
        {

            string str1 = "Hello, World!";
            string str2 = "Hello, World!";
            if (areStringsSame(str1,str2))
            {
                Console.WriteLine("The strings are equal.");
            }
            else
            {
                Console.WriteLine("The strings are not equal.");

            }

        }

        public bool areStringsSame(string s1, string s2)
        {
            return s1.Equals(s2);
        }
    }
}
