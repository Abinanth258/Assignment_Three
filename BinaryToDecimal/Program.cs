namespace BinaryToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            string binary = Console.ReadLine();

            int decimalNumber = 0;
            int power = 1;   // Represents 2^0 initially

            // Loop from right to left
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    decimalNumber = decimalNumber + power;
                }

                power = power * 2; // Move to next power of 2
            }

            Console.WriteLine("Decimal number: " + decimalNumber);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
