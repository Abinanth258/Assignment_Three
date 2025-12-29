namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range;
            Console.Write("Enter the range up to which you want to find prime numbers: ");
            range = int.Parse(Console.ReadLine());

            for (int num = 2; num <= range; num++)
            {
               
                bool isPrime = true;
                for (int i = 2; i * i <= num; i++)  // check the square root of i is greater or equal to num
                {
                    if (num % i == 0)  // If num is divisible by i, it's not prime
                    {
                        isPrime = false;
                        break;//if it fail's it stop the execution here
                    }
                }

                // If the number is prime, print it
                if (isPrime)
                {
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

