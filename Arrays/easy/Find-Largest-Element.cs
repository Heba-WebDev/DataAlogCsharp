/*
Given an array, we have to find the largest element in the array.
*/

public class Arrays
{
    public static void Main(string[] args)
    {
        int[] arr = { 8, 10, 5, 7, 9 };
        Console.WriteLine(LargestEleement(arr));
    }

    public static int LargestEleement(int[] arr)
    {
        int largest = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                largest = arr[i];
            }
        }
        return largest;
    }
}

// Recursivly
public class Arrays
{
    public static void Main(string[] args)
    {
        int[] arr = { 8, 5, 7, 9, 10 };
        Console.WriteLine(LargestElement(arr, arr.Length - 1));
    }

    public static int LargestElement(int[] arr, int n)
    {
        if (n == 0)
        {
            return arr[0];
        }

        // Find the largest in the rest of the array
        int largestInRest = LargestElement(arr, n - 1);

        // Compare the largest in the rest with the current element
        return Math.Max(largestInRest, arr[n]);
    }
}