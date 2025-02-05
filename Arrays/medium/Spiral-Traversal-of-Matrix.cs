/*
Given a Matrix, print the given matrix in spiral order.
*/

using System;
using System.Collections.Generic;

public class Array
{
    public static void Main(string[] args)
    {
        int[,] matrix = new int[,] {
            {1,  2,  3,  4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };
        List<int> result = SpiralMatrix(matrix);
        Console.WriteLine(string.Join(", ", result));
    }

    public static List<int> SpiralMatrix(int[,] matrix)
    {
        List<int> result = new List<int>();
        int rowStart = 0; // top
        int rowEnd = matrix.GetLength(0) - 1; // bottom
        int colStart = 0; // left
        int colEnd = matrix.GetLength(1) - 1; // right

        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            // Traverse right 
            for (int col = colStart; col <= colEnd; col++)
            {
                result.Add(matrix[rowStart, col]);
            }
            rowStart++;

            // Traverse down
            for (int row = rowStart; row <= rowEnd; row++)
            {
                result.Add(matrix[row, colEnd]);
            }
            colEnd--;

            if (rowStart <= rowEnd)
            {
                // Traverse left
                for (int col = colEnd; col >= colStart; col--)
                {
                    result.Add(matrix[rowEnd, col]);
                }
            }
            rowEnd--;

            if (colStart <= colEnd)
            {
                // Traverse up
                for (int row = rowEnd; row >= rowStart; row--)
                {
                    result.Add(matrix[row, colStart]);
                }
                colStart++;
            }
        }
        return result;
    }
}

// Time Complexity: O(nm)
// Space Complexity: O(nm)