namespace Tests;

internal class HappyNumberTests
{
    [Test]
    [TestCase(19, true)]
    [TestCase(2, false)]
    public void Tests(int n, bool expected)
    {
        // Arrange
        var instance = new HappyNumber();

        // Act
        bool actual = instance.IsHappy(n);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
