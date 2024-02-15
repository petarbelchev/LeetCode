namespace Tests;

internal class TextJustificationTests
{
    [Test]
    [TestCase(
        new string[] { "This", "is", "an", "example", "of", "text", "justification." },
        16,
        new string[] { "This    is    an", "example  of text", "justification.  " })]
    [TestCase(
        new string[] { "What", "must", "be", "acknowledgment", "shall", "be" },
        16,
        new string[] { "What   must   be", "acknowledgment  ", "shall be        " })]
    [TestCase(
        new string[] { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" },
        20,
        new string[] { "Science  is  what we", "understand      well", "enough to explain to", "a  computer.  Art is", "everything  else  we", "do                  " })]
    [TestCase(
        new string[] { "The", "important", "thing", "is", "not", "to", "stop", "questioning.", "Curiosity", "has", "its", "own", "reason", "for", "existing." },
        17,
        new string[] { "The     important", "thing  is  not to", "stop questioning.", "Curiosity has its", "own   reason  for", "existing.        " })]
    [TestCase(
        new string[] { "Listen", "to", "many,", "speak", "to", "a", "few." },
        6,
        new string[] { "Listen", "to    ", "many, ", "speak ", "to   a", "few.  " })]
    [TestCase(
        new string[] { "Here", "is", "an", "example", "of", "text", "justification." },
        15,
        new string[] { "Here    is   an", "example of text", "justification. " })]
    public void Tests(string[] words, int maxWidth, string[] expected)
    {
        // Arrange
        var instance = new TextJustification();

        // Act
        IList<string> actual = instance.FullJustify(words, maxWidth);

        // Assert
        Assert.Multiple(() =>
        {
            for (int i = 0; i < expected.Length; i++)
                Assert.That(actual[i], Is.EqualTo(expected[i]));
        });
    }
}
