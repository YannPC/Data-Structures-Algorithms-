using System;
using System.Collections;

namespace DSA_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci_Sequence Fibonacci_Sequence = new Fibonacci_Sequence();
            Fibonacci_Sequence.PrintSequence();

            Console.WriteLine("Next Learning is DSA, Find the Lowest Number");

            Array_Find_the_lowest_value array_Find_The_Lowest_Value = new Array_Find_the_lowest_value();

            array_Find_The_Lowest_Value.FindLowestValue();

            Console.WriteLine("Next Learning is DSA, Find the higest number");

            Array_Find_the_higest_value array_Find_The_Higest_Value = new Array_Find_the_higest_value();

            array_Find_The_Higest_Value.FindHighestValue();

            Console.WriteLine("Next Learning is DSA, Find the second higest number");

            Array_find_the_second_higest_number array_Find_The_Second_Higest_Number = new Array_find_the_second_higest_number();

            array_Find_The_Second_Higest_Number.FindSeoncHighestValue();

            SortedbyNumber sortedbyNumber = new SortedbyNumber();
            Console.WriteLine("IntialValue: ");
            sortedbyNumber.sortedbyNumber();

            Console.WriteLine("\nNext Learning is DSA, Remove duplicate from array");

            remove_deplicate_from_array remove_Duplicate = new remove_deplicate_from_array();

            remove_Duplicate.RemoveDuplicate();

            Console.WriteLine("\nNext Learning is DSA, Inverse array");

            InverseArray inverseArray = new InverseArray();

            inverseArray.InverseArrayMethod();

            Console.WriteLine("\nNext Learning is DSA, Find the Leader of the array");

            LeaderArray leaderArray = new LeaderArray();

            leaderArray.LeaderOfTheArray();

            Console.WriteLine("\nNext Learning is DSA, sort the array");
            SortArray sortArray = new SortArray();

            sortArray.SortArrayMethod();

            CountArray count = new CountArray();

            Console.WriteLine("\nNext Learning is DSA, Count Array");
            count.CountArrayMethod();

            Console.WriteLine("\nNext Learning is DSA, sum of Number in the array");

            SumofArray sumofArray = new SumofArray();

            sumofArray.SumOfArray();

            FindPositiveMissingValueinArray findPositiveValue = new FindPositiveMissingValueinArray();

            findPositiveValue.FindPositiveValueinArray();


        }
    }
}