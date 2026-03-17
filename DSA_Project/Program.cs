namespace DSA_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci_Sequence Fibonacci_Sequence = new Fibonacci_Sequence();
            Fibonacci_Sequence.PrintSequence();

            Console.WriteLine("Next Learning is DSA");

            Array_Find_the_lowest_value array_Find_The_Lowest_Value = new Array_Find_the_lowest_value();

            array_Find_The_Lowest_Value.FindLowestValue();
        }
    }
}