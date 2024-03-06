namespace Tests;

class SubstringWithConcatenationOfAllWordsTests
{
    [Test]
    [TestCase("barfoothefoobarman", new string[] { "foo", "bar" }, new int[] { 0, 9 })]
    [TestCase("wordgoodgoodgoodbestword", new string[] { "word", "good", "best", "word" }, null)]
    [TestCase("barfoofoobarthefoobarman", new string[] { "bar", "foo", "the" }, new int[] { 6, 9, 12 })]
    [TestCase("ababababab", new string[] { "ababa", "babab" }, new int[] { 0 })]
    [TestCase("lingmindraboofooowingdingbarrwingmonkeypoundcake", new string[] { "fooo", "barr", "wing", "ding", "wing" }, new int[] { 13 })]
    [TestCase("aaaaaaaaaaaaaa", new string[] { "aa", "aa" }, new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
    public void Tests(string s, string[] words, int[] expected)
    {
        // Arrange
        var instance = new SubstringWithConcatenationOfAllWords();
        expected ??= Array.Empty<int>();

        // Act
        IList<int> actual = instance.FindSubstring(s, words);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(actual, Has.Count.EqualTo(expected.Length));

            for (int i = 0; i < expected.Length; i++)
                Assert.That(actual.Contains(expected[i]), Is.True);
        });
    }
}
