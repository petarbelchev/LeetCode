namespace Tests;

internal class MinimumSizeSubarraySumTests
{
    [Test]
    [TestCase(7, new int[] { 2, 3, 1, 2, 4, 3 }, 2)]
    [TestCase(4, new int[] { 1, 4, 4 }, 1)]
    [TestCase(11, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, }, 0)]
    public void Tests(int target, int[] nums, int expected)
    {
        //Arrange
        var instance = new MinimumSizeSubarraySum();

        //Act
        int actual = instance.MinSubArrayLen(target, nums);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
