namespace Pattern_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Pattern:\n");

            //Console.WriteLine(" ***");
            //Console.WriteLine("*   *");
            //Console.WriteLine("*   *");
            //Console.WriteLine("*****");
            //Console.WriteLine("*   *");
            //Console.WriteLine("*   *");
            //Console.WriteLine("*   *");
            //Console.WriteLine("*   *");

            for (int i = 1; i <= 8; i++)      // rows
            {
                for (int j = 1; j <= 5; j++)  // columns
                {
                    if (i == 1)
                    {
                        if (j == 1 || j == 5) //
                            Console.Write(" ");
                        else
                            Console.Write("*");
                    }
                    else if (i == 4)// 4th row
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (j == 1 || j == 5)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


            Console.WriteLine("Enter any key to exit...");
            Console.ReadKey();
        }
    }
}
