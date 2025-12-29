namespace PrimeOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());//getting user input

            bool isPrime = true; //flagging variableas true

            for (int i = 2; i * i <= num; i++)// check the square of i is greater or equal to num
            {
                if (num % i == 0)// If num is divisible by i, it's not prime
                {
                    isPrime = false;//flagging variable as false
                    break;
                }
            }

            if (isPrime)//checking the flag variable
                Console.WriteLine("Prime number");
            else
                Console.WriteLine("Not a prime number");


            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
