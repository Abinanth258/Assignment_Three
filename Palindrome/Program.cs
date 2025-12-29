namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, originalNum, reverse = 0;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            originalNum = num;

            while (num > 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num = num / 10;
            }

            if (originalNum == reverse)
                Console.WriteLine("Palindrome number");
            else
                Console.WriteLine("Not a palindrome number");


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
