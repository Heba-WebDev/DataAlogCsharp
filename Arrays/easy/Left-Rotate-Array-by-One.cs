/*
Given an array of N integers, left rotate the array by one place.
*/

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        LeftRotateByOne(arr);
        Console.WriteLine(string.Join(", ", arr));
    }

    public static int[] LeftRotateByOne(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            var temp = arr[i];
            arr[i] = arr[i - 1];
            arr[i - 1] = temp;
        }
        return arr;
    }
}
