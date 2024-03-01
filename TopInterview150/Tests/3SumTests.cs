namespace Tests;

internal class _3SumTests
{
    [Test]
    [TestCase(new int[] { 0, 1, 1 })]
    [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
    [TestCase(new int[] { -4, -2, 1, -5, -4, -4, 4, -2, 0, 4, 0, -2, 3, 1, -5, 0 },
        new int[] { -5, 1, 4 },
        new int[] { -4, 0, 4 },
        new int[] { -4, 1, 3 },
        new int[] { -2, -2, 4 },
        new int[] { -2, 1, 1 },
        new int[] { 0, 0, 0 })]
    public void Tests(int[] nums, params int[][] expected)
    {
        // Arrange
        var instance = new _3Sum();

        // Act
        IList<IList<int>> actual = instance.ThreeSum(nums);

        // Assert
        if (expected == null)
        {
            Assert.That(actual, Has.Count.EqualTo(0));
        }
        else
        {
            Assert.Multiple(() =>
            {
                Assert.That(actual, Has.Count.EqualTo(expected.Length));

                for (int i = 0; i < expected.Length; i++)
                {
                    for (int j = 0; j < expected[i].Length; j++)
                    {
                        Assert.That(actual.Any(x => x.Contains(expected[i][j])), Is.True);
                    }
                }
            });
        }
    }
}
