namespace Tests;

internal class BestTimeToBuyAndSellStockTests
{
    [Test]
    [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [TestCase(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfit_Tests(int[] prices, int expected)
    {
        //Arrange
        var profit = new BestTimeToBuyAndSellStock();

        //Act
        int actual = profit.MaxProfit(prices);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [TestCase(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfitII_Tests(int[] prices, int expected)
    {
        //Arrange
        var profit = new BestTimeToBuyAndSellStock();

        //Act
        int actual = profit.MaxProfitII(prices);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
