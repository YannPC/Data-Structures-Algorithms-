namespace DSA_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb1 = 0;
            int numb2 = 1;

            Console.WriteLine("Fibonacci Sequence:" +numb1);
            Console.WriteLine("Fibonacci Sequence:" +numb2);

           for (int i = 2; i < 10; i++)
            {
                int nextNumb = numb1 + numb2;
                Console.WriteLine("Fibonacci Sequence:" + nextNumb);
                numb1 = numb2;
                numb2 = nextNumb;
            }
        }
    }
}