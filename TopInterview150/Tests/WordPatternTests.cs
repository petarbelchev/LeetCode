namespace Tests;

internal class WordPatternTests
{
    [Test]
    [TestCase("abba", "dog cat cat dog", true)]
    [TestCase("abba", "dog cat cat fish", false)]
    [TestCase("aaaa", "dog cat cat dog", false)]
    [TestCase("aba", "dog cat cat", false)]
    public void Tests(string pattern, string s, bool expected)
    {
        // Arrange
        var instance = new WordPatternTask();

        // Act
        bool actual = instance.WordPattern(pattern, s);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
