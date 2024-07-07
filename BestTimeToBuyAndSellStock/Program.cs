// Problem: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
int MaxProfit(int[] prices)
{
    if (prices.Length < 2)
        return 0;

    int minPriceIndex = 0;
    int maxProfit = 0;

    for (int i = 1; i < prices.Length; i++)
    {
        if (prices[i] < prices[minPriceIndex])
            minPriceIndex = i;

        else if (prices[i] - prices[minPriceIndex] > maxProfit)
            maxProfit = prices[i] - prices[minPriceIndex];
    }

    return maxProfit;
}

int[] prices = { 2,4,1 };
Console.WriteLine(MaxProfit(prices));