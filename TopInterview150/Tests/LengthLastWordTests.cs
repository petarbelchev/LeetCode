namespace Tests;

internal class LengthLastWordTests
{
    [Test]
    [TestCase("Hello World", 5)]
    [TestCase("   fly me   to   the moon  ", 4)]
    [TestCase("luffy is still joyboy", 6)]
    public void Tests(string s, int expected)
    {
        //Arrange
        var instance = new LengthLastWord();

        //Act
        int actual = instance.LengthOfLastWord(s);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
