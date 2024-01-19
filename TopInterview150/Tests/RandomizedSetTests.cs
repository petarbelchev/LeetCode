namespace Tests;

public class RandomizedSetTests
{
    [Test]
    [TestCase(
        new string[] { "RandomizedSet", "insert", "remove", "insert", "getRandom", "remove", "insert", "getRandom" },
        new int[] { 1, 2, 2, 1, 2 },
        new object?[] { null, true, false, true, new int[] { 1, 2 }, true, false, new int[] { 2 } })]
    [TestCase(
        new string[] { "RandomizedSet", "remove", "remove", "insert", "getRandom", "remove", "insert" },
        new int[] { 0, 0, 0, 0, 0 },
        new object?[] { null, false, false, true, new int[] { 0 }, true, true })]
    public void Tests(string[] commands, int[] values, object?[] expected)
    {
        //Arrange
        var randomizer = new RandomizedSet();
        var actual = new object?[expected.Length];
        int valIdx = 0;

        //Act
        for (int i = 0; i < commands.Length; i++)
        {
            if (commands[i] == "RandomizedSet")
            {
                actual[i] = null;
            }
            else if (commands[i] == "insert")
            {
                actual[i] = randomizer.Insert(values[valIdx++]);
            }
            else if (commands[i] == "remove")
            {
                actual[i] = randomizer.Remove(values[valIdx++]);
            }
            else if (commands[i] == "getRandom")
            {
                actual[i] = new int[] { randomizer.GetRandom() };
            }
        }

        //Assert
        Assert.Multiple(() =>
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] is IEnumerable<int>)
                {
                    var actualValue = (actual[i] as IEnumerable<int>)!.First();
                    var expCollection = expected[i] as IEnumerable<int>;

                    Assert.That(expCollection!, Does.Contain(actualValue));

                    continue;
                }

                Assert.That(actual[i], Is.EqualTo(expected[i]));
            }
        });
    }
}
