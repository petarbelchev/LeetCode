namespace Tests;

internal class GasStationTests
{
    [Test]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 }, 3)]
    [TestCase(new int[] { 2, 3, 4 }, new int[] { 3, 4, 3 }, -1)]
    [TestCase(new int[] { 3, 1, 1 }, new int[] { 1, 2, 2 }, 0)]
    public void Tests(int[] gas, int[] cost, int expected)
    {
        //Arrange
        var gasStation = new GasStation();

        //Act
        int actual = gasStation.CanCompleteCircuit(gas, cost);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
