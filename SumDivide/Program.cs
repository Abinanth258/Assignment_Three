namespace SumDivide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;

            for (int i = 100; i <= 200; i++)//for loop the range of 100 to 200
            {
                if (i % 9 == 0)//check if the number is divisible by 9
                {

                    sum = i + 1;
                    count++;//count increases per each loop
                }
            }

            Console.WriteLine("Numbers divisible by 9 between 100 and 200:");
            Console.WriteLine("Count = " + count);
            Console.WriteLine("Sum = " + sum);


            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}