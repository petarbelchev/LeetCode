using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace Tests;

internal class GameOfLifeTests
{
    int[][][] matrixCases = new int[][][]
    {
        new int[][]
        {
            new int[] { 0,1,0 },
            new int[] { 0,0,1 },
            new int[] { 1,1,1 },
            new int[] { 0,0,0 }
        },
        new int[][]
        {
            new int[] { 1,1 },
            new int[] { 1,0 }
        }
    };

    int[][][] expectedCases = new int[][][]
    {
        new int[][]
        {
            new int[] { 0,0,0 },
            new int[] { 1,0,1 },
            new int[] { 0,1,1 },
            new int[] { 0,1,0 }
        },
        new int[][]
        {
            new int[] { 1, 1 },
            new int[] { 1, 1 }
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
        var instance = new GameOfLifeTask();

        // Act
        instance.GameOfLife(actual);

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
