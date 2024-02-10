namespace Tests;

internal class TwoSumII_InputArrayIsSortedTests
{
    [Test]
    [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
    [TestCase(new int[] { 2, 3, 4 }, 6, new int[] { 1, 3 })]
    [TestCase(new int[] { -1, 0 }, -1, new int[] { 1, 2 })]
    public void Tests(int[] numbers, int target, int[] expected)
    {
        //Arrange
        var instance = new TwoSumII_InputArrayIsSorted();

        //Act
        int[] actual = instance.TwoSum(numbers, target);

        //Assert
        Assert.That(string.Join(", ", actual), 
            Is.EqualTo(string.Join(", ", expected)));
    }
}
