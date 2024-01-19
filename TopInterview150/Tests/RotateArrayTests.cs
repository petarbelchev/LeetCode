using Newtonsoft.Json;

namespace Tests;

internal class RotateArrayTests
{
    [Test]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    [TestCase(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
    [TestCase(new int[] { 1 }, 1, new int[] { 1 })]
    [TestCase(new int[] { 1, 2 }, 1, new int[] { 2, 1 })]
    [TestCase(new int[] { 1, 2 }, 2, new int[] { 1, 2 })]
    [TestCase(new int[] { 1, 2 }, 3, new int[] { 2, 1 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 3, new int[] { 4, 5, 6, 1, 2, 3 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54 }, 45, new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
    public void Tests(int[] nums, int k, int[] expected)
    {
        //Arrange
        var rotateArray = new RotateArray();

        //Act
        rotateArray.Rotate(nums, k);

        //Assert
        Assert.That(JsonConvert.SerializeObject(nums),
            Is.EqualTo(JsonConvert.SerializeObject(expected)));
    }
}
