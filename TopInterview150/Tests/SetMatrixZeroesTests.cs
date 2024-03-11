namespace Tests;

internal class SetMatrixZeroesTests
{
    int[][][] matrixCases = new int[][][]
    {
        new int[][]
        {
            new int[] { 1, 1, 1 },
            new int[] { 1, 0, 1 },
            new int[] { 1, 1, 1 },
        },
        new int[][]
        {
            new int[] { 0, 1, 2, 0 },
            new int[] { 3, 4, 5, 2 },
            new int[] { 1, 3, 1, 5 }
        },
        new int[][]
        {
            new int[] { 1 },
            new int[] { 0 }
        }
    };

    int[][][] expectedCases = new int[][][]
    {
        new int[][]
        {
            new int[] { 1, 0, 1 },
            new int[] { 0, 0, 0 },
            new int[] { 1, 0, 1 },
        },
        new int[][]
        {
            new int[] { 0, 0, 0, 0 },
            new int[] { 0, 4, 5, 0 },
            new int[] { 0, 3, 1, 0 }
        },
        new int[][]
        {
            new int[] { 0 },
            new int[] { 0 },
        }
    };

    [Test]
    [TestCase(0)]
    [TestCase(1)]
    [TestCase(2)]
    public void Tests(int caseNumber)
    {
        // Arrange
        int[][] actual = matrixCases[caseNumber];
        int[][] expected = expectedCases[caseNumber];
        var instance = new SetMatrixZeroes();

        // Act
        instance.SetZeroes(actual);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(actual, Has.Length.EqualTo(expected.Length));

            for (int row = 0; row < expected.Length; row++)
            {
                for (int col = 0; col < expected[row].Length; col++)
                    Assert.That(actual[row][col], Is.EqualTo(expected[row][col]));
            }
        });
    }
}
