namespace Tests;

internal class H_IndexTests
{
    [Test]
    [TestCase(new int[] { 3, 0, 6, 1, 5 }, 3)]
    [TestCase(new int[] { 1, 3, 1 }, 1)]
    public void Tests(int[] citations, int expected)
    {
        //Arrange
        var hIndex = new H_Index();

        //Act
        int actual = hIndex.HIndex(citations);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
