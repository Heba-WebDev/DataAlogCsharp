/*
(Leetcode 121)
You are given an array prices where prices[i] is the
price of a given stock on the ith day.

You want to maximize your profit by choosing a single
day to buy one stock and choosing a different day in
the future to sell that stock.

Return the maximum profit you can achieve from this transaction.
If you cannot achieve any profit, return 0.

Solution:

- Keep track of minimum price
- Current price - minPrice (to always get the highest profit)
- Update the maximum profit
*/


public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 0) return 0;

        int maxProfit = 0;
        int minPrice = prices[0];

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else
            {
                int currentProfit = prices[i] - minPrice;
                if (currentProfit > maxProfit)
                {
                    maxProfit = currentProfit;
                }
            }
        }

        return maxProfit;
    }
}
