namespace Tests;

class RotateImageTests
{
    int[][][] matrixCases = new int[][][]
    {
        new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 },
        },
        new int[][]
        {
            new int[] { 5, 1, 9, 11 },
            new int[] { 2, 4, 8, 10 },
            new int[] { 13, 3, 6, 7 },
            new int[] { 15, 14, 12, 16 },
        }
    };

    int[][][] expectedCases = new int[][][]
    {
        new int[][]
        {
            new int[] { 7, 4, 1 },
            new int[] { 8, 5, 2 },
            new int[] { 9, 6, 3 },
        },
        new int[][]
        {
            new int[] { 15, 13, 2, 5 },
            new int[] { 14, 3, 4, 1 },
            new int[] { 12, 6, 8, 9 },
            new int[] { 16, 7, 10, 11 },
        }
    };

    [Test]
    [TestCase(0)]
    [TestCase(1)]
    public void Tests(int caseNumber)
    {
        // Arrange
        int[][] actual = matrixCases[caseNumber];
        int[][] expected = expectedCases[caseNumber];
        var instance = new RotateImage();

        // Act
        instance.Rotate(actual);

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
