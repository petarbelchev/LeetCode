namespace Tests;

internal class SearchInRotatedSortedArrayTests
{
    [Test]
    [TestCase(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
    [TestCase(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
    [TestCase(new int[] { 1 }, 0, -1)]
    [TestCase(new int[] { 1, 3 }, 3, 1)]
    [TestCase(new int[] { 5, 1, 3 }, 5, 0)]
    [TestCase(new int[] { 7, 8, 1, 2, 3, 4, 5, 6 }, 2, 3)]
    [TestCase(new int[] { 4, 5, 6, 7, 8, 1, 2, 3 }, 8, 4)]
    public void Tests(int[] nums, int target, int expected)
    {
        // Arrange
        var instance = new SearchInRotatedSortedArray();

        // Act
        int actual = instance.Search(nums, target);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
