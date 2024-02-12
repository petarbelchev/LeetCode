namespace Tests;

internal class TrappingRainWaterTests
{
    [Test]
    [TestCase(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
    [TestCase(new int[] { 4, 2, 0, 3, 2, 5 }, 9)]
    [TestCase(new int[] { 5, 4, 1, 2 }, 1)]
    public void Tests(int[] height, int expected)
    {
        // Arrange
        var instance = new TrappingRainWater();

        // Act
        int actual = instance.Trap(height);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
