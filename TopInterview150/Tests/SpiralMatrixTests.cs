namespace Tests;

internal class SpiralMatrixTests
{
    [Test]
    [TestCaseSource(nameof(Cases))]
    public void Tests((int[][] Matrix, int[] Expected) testCase)
    {
        // Arrange
        var instance = new SpiralMatrix();

        // Act
        IList<int> actual = instance.SpiralOrder(testCase.Matrix);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(actual, Has.Count.EqualTo(testCase.Expected.Length));

            for (int i = 0; i < testCase.Expected.Length; i++)
                Assert.That(actual[i], Is.EqualTo(testCase.Expected[i]));
        });
    }

    static IEnumerable<(int[][] Matrix, int[] Expected)> Cases()
    {
        yield return (
            new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            },
            new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 });

        yield return (
            new int[][]
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 5, 6, 7, 8 },
                new int[] { 9, 10, 11, 12 },
            },
            new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 });

        yield return (
            new int[][]
            {
                new int[] { 1 }
            },
            new int[] { 1 });

        yield return (
            new int[][]
            {
                new int[] { 7 },
                new int[] { 9 },
                new int[] { 6 },
            },
            new int[] { 7, 9, 6 });

        yield return (
            new int[][]
            {
                new int[] { 2, 5, 8 },
                new int[] { 4, 0, -1 },
            },
            new int[] { 2, 5, 8, -1, 0, 4 });

        yield return (
            new int[][]
            {
                new int[] { 2, 3, 4 },
                new int[] { 5, 6, 7 },
                new int[] { 8, 9, 10 },
                new int[] { 11, 12, 13 },
                new int[] { 14, 15, 16 },
            },
            new int[] { 2, 3, 4, 7, 10, 13, 16, 15, 14, 11, 8, 5, 6, 9, 12 });
    }
}
