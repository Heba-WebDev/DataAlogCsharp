/*
Given an integer N and an array of size N-1
containing N-1 numbers between 1 to N. Find
the number(between 1 to N), that is not present
in the givenarray.
*/
public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 6, 7, 8 };
        var result = FindMissingNumber(arr);
        Console.WriteLine(result);
    }

    public static int FindMissingNumber(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if ((arr[i] - arr[i - 1]) != 1)
            {
                return arr[i] - 1;
            }
        }
        return 0;
    }
}
