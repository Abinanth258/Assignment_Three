namespace SquareNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            int n,sum=0;//initialize

            //getting user input
            Console.Write("Enter the number of terms (n): ");
            n = int.Parse(Console.ReadLine());

            //printing the output   
            Console.WriteLine("\nSquare of natural numbers:");

            //Loop to calculate square and sum
            for (int i = 1; i <= n; i++)
            {
                int square = i * i;//caluculate square
                sum = square+sum;//each square added to sum

                Console.WriteLine("{0}^2:{1}",i,square);//printing square
            }

            Console.WriteLine("\nSum of squares = {0}",sum);//printing sum of squares

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}