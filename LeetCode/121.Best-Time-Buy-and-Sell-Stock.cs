public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int left = 0;
        int right = 1;
        int maxProfit = 0;

        while (right < prices.Length)
        {
            if (prices[left] < prices[right])
            {
                int profit = prices[right] - prices[left];
                maxProfit = Math.Max(maxProfit, profit);
            }
            else
            {
                left = right; // shift left to right, as we found a new low price
            }

            right++; // in all cases we update right, as we have a variable to keep track of max profit
        }

        return maxProfit;
    }
}