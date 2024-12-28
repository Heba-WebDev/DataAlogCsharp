/*
Given an array of integers arr[] and an integer target.
- 1st variant: Return YES if there exist two numbers such
that their sum is equal to the target. Otherwise, return NO.

- 2nd variant: Return indices of the two numbers such that their
sum is equal to the target. Otherwise, we will return {-1, -1}.
*/

// Brute-force approach

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 2, 6, 5, 8, 11 };
        int target = 14;
        Console.WriteLine(SumOfTwo(arr, target));
    }

    public static string SumOfTwo(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i  + 1; j < arr.Length; j++) // i+1 because we already checked for all possible sums of the previous numbers including their sums of the current number
            {
                if (arr[j] == arr[i]) continue;
                if ((arr[i] + arr[j]) == target) return "YES";
            }
        }
        return "NO";
    }
}

// Time complexity of the brute-force appraoch is O(n^2)

// better appraoch with time complexity of O(n), The space complexity is O(n) as well 

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 2, 6, 5, 8, 11 };
        int target = 14;
        Console.WriteLine(SumOfTwo(arr, target));
    }

    public static string SumOfTwo(int[] arr, int target)
    {
        var dictionary = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            var missingNumber = target - arr[i];
            if (dictionary.ContainsKey(missingNumber))
            {
                return "YES";
            }
            else
            {
                if (!dictionary.ContainsKey(arr[i]))
                {
                    dictionary.Add(arr[i], i);
                }
            }
        }
        return "NO";
    }
}

//optimal approach for the YES/NO variant when the array is ordered, we can use two pointers
public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 2, 6, 5, 8, 11 };
        int target = 14;
        Console.WriteLine(SumOfTwo(arr, target));
    }

    public static string SumOfTwo(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left < right)
        {
            var sum = arr[left] + arr[right];
            if (sum == target)
            {
                return "YES";
            }
            else if (sum < target)
            {
                left++; // Move the left pointer to increase the sum
            }
            else
            {
                right--; // Move the right pointer to decrease the sum
            }
        }
        return "NO";
    }
}

