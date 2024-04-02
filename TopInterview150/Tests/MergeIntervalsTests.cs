using System.Text.Json;

namespace Tests;

internal class MergeIntervalsTests
{
    [Test]
    [TestCase("[[1,3],[2,6],[8,10],[15,18]]", "[[1,6],[8,10],[15,18]]")]
    [TestCase("[[1,4],[4,5]]", "[[1,5]]")]
    [TestCase("[[1,4],[5,6]]", "[[1,4],[5,6]]")]
    [TestCase("[[2,3],[4,5],[6,7],[8,9],[1,10]]", "[[1,10]]")]
    public void Tests(string intervalsJson, string expectedJson)
    {
        // Arrange
        int[][] intervals = JsonSerializer.Deserialize<int[][]>(intervalsJson)!;
        var instance = new MergeIntervals();

        // Act
        int[][] actual = instance.Merge(intervals);
        string actualJson = JsonSerializer.Serialize(actual);

        // Assert
        Assert.That(actualJson, Is.EqualTo(expectedJson));
    }
}
