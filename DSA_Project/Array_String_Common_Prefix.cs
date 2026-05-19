using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class Array_String_Common_Prefix
    {
        public void CommonPrefix()
        {
            string[] str = { "flower", "car", "tea" };
            string prefix = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                while (str[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix))
                    {
                        Console.WriteLine("No common prefix found.");
                        return;
                    }
                }
            }
            Console.WriteLine("Longest common prefix: " + prefix);
        }
    }
}
