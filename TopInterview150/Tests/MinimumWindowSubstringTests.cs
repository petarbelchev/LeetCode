namespace Tests;

class MinimumWindowSubstringTests
{
    [Test]
    [TestCase("ADOBECODEBANC", "ABC", "BANC")]
    [TestCase("a", "a", "a")]
    [TestCase("a", "aa", "")]
    [TestCase("aa", "aa", "aa")]
    [TestCase("bbaa", "aba", "baa")]
    [TestCase("bba", "ab", "ba")]
    public void Tests(string s, string t, string expected)
    {
        // Arrange
        var instance = new MinimumWindowSubstring();

        // Act
        string actual = instance.MinWindow(s, t);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
