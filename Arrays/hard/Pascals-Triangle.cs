/*
Given the number of rows n. Print the first n rows of Pascal’s triangle.
*/

using System;
using System.Linq;
using System.Collections.Generic;

public class PasacalTriangle
{
    public static void Main(string[] args)
    {
        int n = 4;
        PrintPascalTriangle(n);
    }

    public static void PrintPascalTriangle(int rows)
    {

        List<int> prevRow = new List<int> { 1 }; // First row
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine(string.Join(" ", prevRow));
            List<int> currRow = new List<int> { 1 }; // Start row with 1
            for (int j = 0; j < prevRow.Count - 1; j++)
            {
                currRow.Add(prevRow[j] + prevRow[j + 1]);
            }
            currRow.Add(1); // End row with 1
            prevRow = currRow; // Update previous row
        }
    }
}

/*
Given the row number n. Print the n-th row of Pascal’s triangle.
*/

public class Arrays
{
    public static void Main(string[] args)
    {
        var result = PascalTriangleII(4);
        Console.WriteLine(string.Join(" ", result));
    }

    public static int[] PascalTriangleII(int rowIndex)
    {
        int[] res = { 1 };

        for (int i = 0; i < rowIndex; i++)
        {
            int[] next_row = new int[res.Length + 1];
            for (int j = 0; j < res.Length; j++)
            {
                next_row[j] += res[j];
                next_row[j + 1] += res[j];
            }
            res = next_row;
        }
        return res;
    }
}

/*
Given row number r and column number c. Print the element at
position (r, c) in Pascal’s triangle.
*/

public class Arrays
{
    public static void Main(string[] args)
    {
        var result = PascalTriangleII(4, 2);
        Console.WriteLine(string.Join(" ", result));
    }

    public static (int, int) PascalTriangleII(int rowIndex, int columnIndex)
    {
        int[] res = { 1 };

        for (int i = 0; i < rowIndex; i++)
        {
            int[] next_row = new int[res.Length + 1];
            for (int j = 0; j < res.Length; j++)
            {
                next_row[j] += res[j];
                next_row[j + 1] += res[j];
            }
            res = next_row;
        }
        return (rowIndex, res[columnIndex]);
    }
}
