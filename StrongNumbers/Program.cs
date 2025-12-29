namespace StrongNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end;

            Console.Write("Enter starting number: ");
            start = int.Parse(Console.ReadLine());

            Console.Write("Enter ending number: ");
            end = int.Parse(Console.ReadLine());

            Console.WriteLine("Strong numbers between " + start + " and " + end + " are:");

            for (int num = start; num <= end; num++)
            {
                int temp = num;
                int sum = 0;

                while (temp > 0)
                {
                    int digit = temp % 10;
                    int fact = 1;

                    for (int i = 1; i <= digit; i++)
                    {
                        fact = fact * i;
                    }

                    sum = sum + fact;
                    temp = temp / 10;
                }

                if (sum == num)
                {
                    Console.WriteLine(num);
                }
            }

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
