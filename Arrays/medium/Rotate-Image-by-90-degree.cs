/*
leetcode 48. Rotate Image (Medium)
You are given an n x n 2D matrix representing an image,
rotate the image by 90 degrees (clockwise).
You have to rotate the image in-place, which means you have
to modify the input 2D matrix directly. DO NOT allocate another
2D matrix and do the rotation.
*/


/*
first we transpose the matrix and flip it symmetrically
basically, numbers on sides of the digonal will be switched.
second, we switch the numbers on each column so that 1, 2, 3
would be 3, 2, 1. so we are flipping horizontally
*/

using System;
public class Array
{
    public static void Main(string[] args)
    {
        int[][] arr = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        arr = RotateImage90Deg(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static int[][] RotateImage90Deg(int[][] matrix)
    {
        // First transpose the matrix
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = i; j < matrix.Length; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        // Then reverse each row
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < (matrix.Length / 2); j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][matrix.Length - 1 - j];
                matrix[i][matrix.Length - 1 - j] = temp;
            }
        }
        return matrix;
    }
}

// Time Complexity: O(n²)
// Space Complexity: O(1)
