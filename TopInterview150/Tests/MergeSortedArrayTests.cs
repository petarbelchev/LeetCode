using Newtonsoft.Json;

namespace Tests;

public class MergeSortedArrayTests
{
    [Test]
    [TestCase(new int[6] { 1, 2, 3, 0, 0, 0 }, 3, new int[3] { 2, 5, 6 }, 3, new int[6] { 1, 2, 2, 3, 5, 6 })]
    [TestCase(new int[1] { 1 }, 1, new int[0], 0, new int[1] { 1 })]
    [TestCase(new int[1] { 0 }, 0, new int[1] { 1 }, 1, new int[1] { 1 })]
    [TestCase(new int[6] { 4, 5, 6, 0, 0, 0 }, 3, new int[3] { 1, 2, 3 }, 3, new int[6] { 1, 2, 3, 4, 5, 6 })]
    [TestCase(new int[6] { 4, 5, 6, 0, 0, 0 }, 3, new int[3] { 1, 2, 7 }, 3, new int[6] { 1, 2, 4, 5, 6, 7 })]
    public void Tests(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        //Arrange
        var mergeSortedArray = new MergeSortedArray();

        //Act
        mergeSortedArray.Merge(nums1, m, nums2, n);

        //Assert
        Assert.That(JsonConvert.SerializeObject(nums1),
            Is.EqualTo(JsonConvert.SerializeObject(expected)));
    }
}