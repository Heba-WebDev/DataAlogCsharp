/*
Given an array of N integers, write a program to return
an element that occurs more than N/2 times in the given array.
You may consider that such an element always exists in the array.
*/

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 2, 2, 1, 1, 1, 2, 2 };
        int x = (int)Math.Ceiling(arr.Length / 2.0);
        Console.WriteLine(MajorityElement(arr, x));
    }

    public static int? MajorityElement(int[] arr, int x)
    {
        var count = new Dictionary<int, int>();
        foreach (var num in arr)
        {
            if (count.ContainsKey(num))
            {
                count[num]++;
            }
            else
            {
                count[num] = 1;
            }

            if (count[num] >= x)
            {
                return num;
            }
        }
        return null;
    }
}

// Time complexity: O(n)
// Since the dictionary operations inside the loop are constant time, the overall time complexity remains O(n)
// Space Complexity: O(n) *array in worst case might have different numbers in each iteration