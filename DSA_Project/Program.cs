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
        }
    }
}