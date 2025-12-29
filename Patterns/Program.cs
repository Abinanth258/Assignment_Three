namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //#region FOR
            ////print 1 to 10
            //for (int i = 0; i <= 10; i++)
            //{
            //    //Console.WriteLine(i +"\t");
            //    Console.Write(i + "\t");
            //}
            //#endregion
            //#region FOREACH

            ////declare varaibles

            ////
            ////{}                        0   1        2        3        4           5
            ////string[] cities =  "kanyakumari", "kottayam", "kollam", "kannur", "kochi"

            //string[] cities = new string[] { "kanyakumari", "kottayam", "kollam", "kannur", "kochi","Neyyartrankarai" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}
            //int count= 0;

            ////TASK1: count how many cities start with 'k' --sartWith()

            //foreach (string city in cities)
            //{

            //    if (city.StartsWith("k"))
            //    {
            //        count++;
            //    }
            //}

            ////task2: find cities with name longer than than 12 characters --city.Length

            //foreach (string city in cities)
            //{

            //    if (city.Length >= 12)
            //    {
            //        Console.WriteLine("Number of cities name longer than 12: " + city);
            //    }
            //}

            ////task3: find cities with metro                              --EndWidth()
            //////get input from the user 
            //Console.WriteLine("Enter the city name that you want to search ");
            //string inputserach = Console.ReadLine();

            //Console.WriteLine($"Cities ending with {inputserach}:");

            ////// foreach loop to iterate through the cities array and find the city 
            //foreach (string city in cities)
            //{
            //    if (city.EndsWith(inputserach))
            //    {
            //        //display the city name
            //        Console.WriteLine(city);
            //    }
            //}

            ////seach if it is exists in the array --Equals()
            //Console.Write("Enter a city name to check f it exists:");
            //string userInput = Console.ReadLine();

            //foreach (string city in cities)
            //{
            //    if (city.Equals(userInput, StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine(city);
            //        break;
            //    }
            //}
            //


            //#endregion



            //int num, width;

            //Console.Write("Enter the number of rows: ");
            //width = int.Parse(Console.ReadLine());
            //Console.Write("Enter the number to print: ");
            //num = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= width; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(num);
            //    }
            //    Console.WriteLine();
            //}

            //1
            //12
            //123
            //1234
            //12345


            //int num;

            //Console.Write("Enter the number of rows: ");
            //num = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= num; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //1
            //23
            //456

            //int num = 1,rows;

            //Console.Write("Enter the number of rows: ");
            //rows = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(num);
            //        num++;
            //    }
            //    Console.WriteLine();
            //}



            //1
            //21
            //
            //
            int rows;

            Console.Write("Enter the number of rows: ");
            rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                    
                }
                Console.WriteLine();
            }




            //Console.WriteLine("Hello, World!");
            Console.WriteLine("press any key ro exit...");
            Console.ReadKey();
        }
    }
}
