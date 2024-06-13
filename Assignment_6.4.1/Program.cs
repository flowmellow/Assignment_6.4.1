using System.Security.Cryptography.X509Certificates;

/*
You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).
You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation.
Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [[7,4,1],[8,5,2],[9,6,3]]

Example 2:
Input: matrix = [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
Output: [[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]
*/

namespace Assignment_6._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int[,] matrix = { { 5, 1, 9, 11 }, { 2, 4, 8, 10 }, { 13, 3, 6, 7 }, { 15, 14, 12, 16 } };

            foreach ( int index in matrix)
            {
                Console.Write(index + " ");

            }
            Console.WriteLine();
            Console.WriteLine("************** Break ***************");

            int rowLength = matrix.GetLength(0);
            int columnLength = matrix.GetLength(1);

            int temp; // establish a variable to temporarily hold element.

            for (int i = 0; i < rowLength/2; i++) // outer loop iterating over outer layers starting at matrix[0. ""]. rowlenght 3. /2 to ensure only go up to middle of matrix reducing redundency.
                                                  // If not  i iterates to 2 when not needed.
            {
                for (int j = i; j < columnLength - i -1; j++) // inner loop layers starting at matrix[0,0]. columnLength is 3. continues while j < 2 (3-0-1).
                                                              // set to 2 because only want to iterate j for 2 iterations because we do not want to replace position matrix[0, 2] in a 3rd iteration
                {
                    temp = matrix[i,j]; // temp holds m[0,0] (value 1) 1st , temp set to m[0,1] (value 2) in second iteration
                    matrix[i,j] = matrix[columnLength - j - 1, i]; // m[0,0] = m[2,0] moves 7 to 1 pos, iteration 2 is m[0,1] = m[1,0] moves 4 to 2 pos
                    matrix[columnLength - j - 1, i] = matrix[columnLength - i - 1, columnLength - j - 1]; //m[2, 0] = m[2, 2] moves 9 to 7 pos, iteration 2 is m[1,0] = m[2,1] moves 8 to 4 pos
                    matrix[columnLength - i - 1, columnLength - j - 1] = matrix[j, columnLength - i - 1]; //m[2, 2] = m[0, 2] moves 3 to 9 pos, iteration 2 is m[2,1] = m[1,2] moves 6 to 8 pos
                    matrix[j, columnLength - i - 1] = temp; //m[0, 2] = m[0, 0] moves 1 to 3 pos, iteration 2 is m[1,2] = m[0, 1] moves 2 to 6 pos

                } // exit 1st iteration to start over with j++ j=1

            }

            //int count = 0; // set up counter to build condition to seperate rows
            //for (int i = 0; i < rowLength; i++) 
            //{
            //    for(int j = 0;  j < columnLength; j++)
            //    {
            //        Console.Write(matrix[i , j] + " ");
            //        count++; // count will reach 12
            //        if (count % rowLength == 0) // every time the count is divisible by 3 without a remainder then in console writes.
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            
            //}
           
            // alternate way to print the array based on inner loop completion of j < 3
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    Console.Write(matrix[i, j] + " ");                
                }
                Console.Write("\n");
            }
            



        }

    }
    
}
