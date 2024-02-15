namespace Tests;

internal class IsomorphicStringsTests
{
    [Test]
    [TestCase("egg", "add", true)]
    [TestCase("foo", "bar", false)]
    [TestCase("paper", "title", true)]
    [TestCase("badc", "baba", false)]
    public void Tests(string s, string t, bool expected)
    {
        //Arrange
        var instance = new IsomorphicStrings();

        //Act
        bool actual = instance.IsIsomorphic(s, t);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
