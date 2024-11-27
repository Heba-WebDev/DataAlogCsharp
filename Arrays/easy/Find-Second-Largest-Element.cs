/*
Given an array, we have to find the second largest element in the array.
*/

public class Arrays
{
    public static void Main(string[] args)
    {
        int[] arr = { 8, 5, 2, 7, 9, 3, 10 };
        Console.WriteLine(SecondLargestElement(arr));
    }

    public static int SecondLargestElement(int[] arr)
    {
        if (arr.Length < 2)
        {
            throw new InvalidOperationException("Array must have at least two elements.");
        }

        int largest = int.MinValue;
        int second_largest = int.MinValue;

        foreach (int num in arr)
        {
            if (num > largest)
            {
                second_largest = largest;
                largest = num;
            }
            else if (num < largest && num > second_largest)
            {
                second_largest = num;
            }
        }
        if (second_largest == int.MinValue)
        {
            throw new InvalidOperationException("No distinct second largest element found.");
        }

        return second_largest;
    }
}
