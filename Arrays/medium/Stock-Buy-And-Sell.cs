/*
You are given an array of prices where prices[i] is
the price of a given stock on an ith day.

You want to maximize your profit by choosing a single
day to buy one stock and choosing a different day in
the future to sell that stock. Return the maximum profit
you can achieve from this transaction. If you cannot achieve
any profit, return 0.
*/

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine(StockBuySell(arr));
    }

    public static int StockBuySell(int[] arr)
    {
        int min = arr[0];
        int maxProfit = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int profit = arr[i] - min;  // Current price minus minimum price seen so far
            maxProfit = Math.Max(maxProfit, profit);
            min = Math.Min(min, arr[i]);
        }
        return maxProfit;
    }
}

/*
Iterate through array:

Day 0 (7): profit = 7-7 = 0, min = 7
Day 1 (1): profit = 1-7 = -6, min updated to 1
Day 2 (5): profit = 5-1 = 4, min stays 1, maxProfit becomes 4
Day 3 (3): profit = 3-1 = 2, min stays 1
Day 4 (6): profit = 6-1 = 5, min stays 1, maxProfit becomes 5
Day 5 (4): profit = 4-1 = 3, min stays 1


Return maxProfit = 5 (buy at 1, sell at 6)

Time Complexity: O(n) - single pass through the array
Space Complexity: O(1) - only using a few variables
*/