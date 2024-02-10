namespace Tests;

internal class CandyTaskTests
{
    [Test]
    [TestCase(new int[] { 1, 0, 2 }, 5)]
    [TestCase(new int[] { 1, 2, 2 }, 4)]
    [TestCase(new int[] { 1, 2, 87, 87, 87, 2, 1 }, 13)]
    [TestCase(new int[] { 1, 2, 3, 1, 0 }, 9)]
    public void Tests(int[] ratings, int expected)
    {
        //Arrange
        var instance = new CandyTask();

        //Act
        int actual = instance.Candy(ratings);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
