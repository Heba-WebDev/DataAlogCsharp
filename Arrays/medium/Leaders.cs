/*
Given an array, print all the elements which are leaders.
A Leader is an element that is greater than all of the elements
on its right side in the array.
*/

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 4, 7, 1, 0 };
        int[] result = Leaders(arr);
        Console.WriteLine(string.Join(" ", result));
    }

    public static int[] Leaders(int[] arr)
    {
        List<int> leaders = new List<int>();
        int highest = arr[arr.Length - 1];
        leaders.Add(highest);

        for (int i = arr.Length - 2; i >= 0; i--)
        {
            if (arr[i] > highest)
            {
                highest = arr[i];
                leaders.Add(arr[i]);
            }
        }
        leaders.Reverse(); // optinal 
        return leaders.ToArray();
    }
}


// Time Complexity: O(n)
// Space Complexity: O(n)