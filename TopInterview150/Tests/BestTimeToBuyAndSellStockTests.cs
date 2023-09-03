namespace Tests;

internal class BestTimeToBuyAndSellStockTests
{
	[Test]
	[TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
	[TestCase(new int[] { 7, 6, 4, 3, 1 }, 0)]
	public void Tests(int[] prices, int expected)
	{
		//Arrange
		var profit = new BestTimeToBuyAndSellStock();

		//Act
		int actual = profit.MaxProfit(prices);

		//Assert
		Assert.That(actual, Is.EqualTo(expected));
	}
}
