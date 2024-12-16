/*
Given an array and a sum k, we need to print the length of the
longest subarray that sums to k
*/

/*
an array of positive numbers
find the longest contiguous sequence (subarray) that adds up to exactly K
return the length of this subarray
*/

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 2, 2, 4, 1, 2 };
        int k = 4;
        Console.WriteLine(LongestSubArray(arr, k));
    }

    public static int LongestSubArray(int[] arr, int k)
    {
        int n = arr.Length;
        int left = 0;
        int maxLength = 0;
        int currentSum = 0;

        for (int right = 0; right < n; right++)
        {
            currentSum += arr[right];

            while (currentSum > k && left <= right)
            {
                currentSum -= arr[left];
                left++;
            }

            if (currentSum == k)
            {
                maxLength = Math.Max(maxLength, (right - left + 1));
            }
        }
        return maxLength;
    }
}

// Time Complixty O(n) - Space Complexity O(1)
