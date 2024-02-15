namespace Tests;

internal class ZigzagConversionTests
{
    [Test]
    [TestCase("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [TestCase("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [TestCase("A", 1, "A")]
    [TestCase("ABCDE", 4, "ABCED")]
    public void Tests(string s, int numRows, string expected)
    {
        // Arrange
        var instance = new ZigzagConversion();

        // Act
        string actual = instance.Convert(s, numRows);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
