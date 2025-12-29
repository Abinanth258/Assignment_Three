namespace DiamondShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter the number of width of the pattern : ");
            n = int.Parse(Console.ReadLine());

            // Upper half of the diamond
            for (int i = 1; i <= n; i++)
            {
                // Print spaces
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Lower half of the diamond
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
