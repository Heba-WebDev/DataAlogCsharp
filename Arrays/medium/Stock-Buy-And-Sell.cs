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