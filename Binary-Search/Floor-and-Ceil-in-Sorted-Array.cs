/*
Given a sorted array nums and an integer x. Find the floor and ceil of x in nums.

The floor of x is the largest element in the array which is smaller than or equal to x.

The ceiling of x is the smallest element in the array greater than or equal to x.

If no floor or ceil exists, output -1.
*/

public class BinarySearch
{
    public static void Main(string[] args)
    {
        int[] arr = new int[] { 3, 4, 4, 7, 8, 10 };
        int[] result = FloorAndCeil(arr, 5);
        Console.WriteLine($"Floor: {result[0]}, Ceil: {result[1]}");
    }

    public static int[] FloorAndCeil(int[] nums, int x)
    {
        int left = 0;
        int right = nums.Length - 1;
        int ceil = -1;
        int floor = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == x)
            {
                return new int[] { x, x };
            }
            else if (nums[mid] < x)
            {
                floor = nums[mid]; // possible floor
                left = mid + 1;
            }
            else
            {
                ceil = nums[mid]; // possible ceil
                right = mid - 1;
            }
        }

        return new int[] { floor, ceil };
    }
}

// Time Complexity: O(log n)
// Space Complexity: O(1)