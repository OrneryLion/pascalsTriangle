using System;

namespace pascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // use jagged arrays to print a pascal triangle
            while (true)
            {
                Console.WriteLine("How tall do you want your triangle to be?");
                int triangleHeight = int.Parse(Console.ReadLine());

                //create an array of arrays. One array for each row of the triangle
                int[][] triangleArrays = new int[triangleHeight + 1][];

                // create a new array for each row in the triangle
                for (int row = 0; row < triangleHeight; row++)
                {
                    triangleArrays[row] = new int[row + 1];

                }

                // calculate the int values that each node of the triangle will hold

                // first row is only 1 integer

                triangleArrays[0][0] = 1;

                for (int row = 0; row<triangleHeight-1; row++)
                {
                    for( int col =0; col < triangleArrays[row].Length; col++)
                    {
                        triangleArrays[row + 1][col] = triangleArrays[row + 1][col] + triangleArrays[row][col];
                        triangleArrays[row + 1][col + 1] = triangleArrays[row + 1][col + 1] + triangleArrays[row][col];

                    }

                }
                // print the triangle
                for (int row = 0; row < triangleHeight; row++)
                {
                    //add half the spaces before each new row.
                    Console.Write(new string(' ', (triangleHeight - row) * 3));
                    for (int col = 0; col < row; col++)
                    {
                        Console.Write("{0,6}", triangleArrays[row][col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
