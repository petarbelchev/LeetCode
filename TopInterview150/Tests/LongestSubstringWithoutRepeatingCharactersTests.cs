namespace Tests;

class LongestSubstringWithoutRepeatingCharactersTests
{
    [Test]
    [TestCase("abcabcbb", 3)]
    [TestCase("bbbbb", 1)]
    [TestCase("pwwkew", 3)]
    [TestCase("au", 2)]
    [TestCase("aa", 1)]
    [TestCase("aab", 2)]
    [TestCase("dvdf", 3)]
    [TestCase("bpfbhmipx", 7)]
    public void Tests(string s, int expected)
    {
        // Arrange
        var instance = new LongestSubstringWithoutRepeatingCharacters();

        // Act
        int actual = instance.LengthOfLongestSubstring(s);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
