using System.Text;

namespace ConsoleAppArrayDuplicateElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Two Dimensional Array Duplicate Element
            //declare and initialize a 2D array
            //row col
            //temperature monitoring sstem

            const int Rows = 5;
            const int cols = 3;

            //Initialize 2s array
            double[,] Temperature = new double[Rows, cols]
            {   //0,0 0,1  0,2
                { 22.5,23.1,21.8 },//day 1 morning noon evenging
                //1,0    1,1  1,2
                {20.9, 24.3 ,19.7 },//day 2
                {18.6, 25.0 ,17.7 },//day 3
                {20.9, 23.0 ,18.7 },//day 4
                {20.9, 25.0 ,19.2 }//day 5
            };






            //interate -- transversal
            //print all value
            for (int row = 0; row < Rows; row++) //outer  --row
            {
                Console.WriteLine($"Day {row + 1}");


                // inner loop
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"\t {Temperature[row, col]}");
                }
                //blank line
                Console.WriteLine();
            }

            #endregion


            #region JADDED ARRAY

            //initialize jagged array
            int[][] studentScore = new int[3][];

            //Eaach student has taken a different number of exams
            studentScore[0] = new int[] { 85, 90, 78 };//student 1 scores
            studentScore[1] = new int[] { 83, 80 };//student 2 scores
            studentScore[2] = new int[] { 75, 80, 85, 90 };//student 3 scores

            //print the score for each student
            for (int i = 0; i < studentScore.Length; i++)
            {
                Console.WriteLine("Student {0} scores:", i + 1);
                for (int j = 0; j < studentScore[i].Length; j++)
                {
                    Console.Write(studentScore[i][j] + "");
                }
                Console.WriteLine();
            }

            #endregion

            #region String
            string sOne = new string("sky");
            string sTwo = "Blue";
            sOne = sOne + sTwo;//skyBlue
            //sky becomes garbage any gc();
            //string Builder();
            StringBuilder sBuilder = new StringBuilder();
            sBuilder.Append("Hello ");
            sBuilder.Append("World!");
            sBuilder.AppendLine("Faith");

            Console.WriteLine(sBuilder);
            #endregion

            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}
