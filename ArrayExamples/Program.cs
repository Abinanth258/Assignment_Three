namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] array=new int[100];
            int n;
            Console.Write("Enter the array size: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter the array elements one by one: ");
            for (int i = 0; i <= n; i++) 
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array elements are: ");
            for (int i = 0; i <= n; i++) 
            {
                Console.WriteLine(array[i]);
            }

            //SECOND LARGEST ELEMENT
            int largest=0,secondLargest=0;
            for (int i = 0; i <= n; i++)
            {
                if (array[i] > largest)
                {
                    secondLargest = largest;
                    largest = array[i];
                }
                
            }
                Console.WriteLine("The second largest element is: " + secondLargest);



            //Unique Elements
            int[] unique= new int[array.Length];
            //counter for tracking unique numbers found
            int counter=0;
            //Loop through each element or number in the original array
            foreach(int number in array)
            {
                //Flag to track if number exists
                bool exists=false;
                //Check if the number is already in the unique array
                for (int i=0;i<counter;i++)
                {
                    if(unique[i]==number)
                    {
                        //mark as duplicate found
                        exists = true;
                        break;
                    }
                }
                //if the number is not found in the unique array, add it
                if(!exists)
                {
                    unique[counter]=number;
                    counter++;
                }
            }
            Console.WriteLine("The unique elements in the array are: ");
                for (int i = 0; i < counter; i++)
                {
                    Console.WriteLine(unique[i]);
                }


            //sorting ascending order
            for (int pass = 0; pass < counter - 1; pass++)
            {
                for (int j = 0; j < counter-1; j++)
                {
                    if (unique[j] > unique[j+1])
                    {
                        //swap the elements
                        int temp = unique[j];
                        unique[j] = unique[j + 1];
                        unique[j + 1] = temp;
                    }
                }
            }
            //After sort ---print unique array
            Console.WriteLine("after sorting...");
            for (int i = 0; i < counter; i++) 
            {
                Console.Write(unique[i] + "\n");


            }

            //second largest
            Console.WriteLine("second largest element:");
            Console.WriteLine(unique[counter - 2]);


            Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            
        }
    }
}
