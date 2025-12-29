namespace Armstrong
{
    internal class Program
    {
        static void Main()
        {
            int n, temp, sum = 0, r;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            temp = n;

            while (n > 0)
            {
                //getting user input
                r = n % 10;
                sum = r * r * r + sum;
                n = n / 10;

            }
            if (temp == sum)
            {
                Console.WriteLine("{0} is an Armstrong number.", temp);
            }
            else
            {
                Console.WriteLine("{0} is not an Armstrong number.", temp);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}