namespace AlphabetPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 4;//intializing number of rows

            for (int i = 0; i < rows; i++)
            {
                // Print increasing alphabets
                for (int j = 0; j <= i; j++)
                {
                    Console.Write((char)('A' + j) + " ");
                }

                // Print decreasing alphabets
                for (int j = i - 1; j >= 0; j--)
                {
                    Console.Write((char)('A' + j) + " ");
                }

                Console.WriteLine();

            }





            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();

        }

    }
}
