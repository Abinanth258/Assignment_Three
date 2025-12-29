namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the number: ");
            n = int.Parse(Console.ReadLine());

            int first = 0, second = 1;//initialize first and second numbers

            Console.WriteLine("The Fibonacci Series:");

            for (int i = 1; i <= n; i++)//for loop the range of n
            {
                Console.Write("\t"+first);

                int next = first + second;//calculate next number
                first = second;//update first and second
                second = next;//update first and second
            }


            Console.WriteLine("\n\nPress any key to exit..."); 
            Console.ReadKey();
        }
    }
}
