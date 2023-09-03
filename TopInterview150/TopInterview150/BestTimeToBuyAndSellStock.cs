﻿namespace TopInterview150;

public class BestTimeToBuyAndSellStock
{
	public int MaxProfit(int[] prices)
	{
		if (prices.Length == 1)
			return 0;

		int buyDay = 0;
		int bestProfit = 0;

		for (int sellDay = 1; sellDay < prices.Length; sellDay++)
		{
			int currProfit = prices[sellDay] - prices[buyDay];

			if (currProfit < 0)
				buyDay = sellDay;
			else if (currProfit > bestProfit)
				bestProfit = currProfit;
		}

		return bestProfit;
	}
}
