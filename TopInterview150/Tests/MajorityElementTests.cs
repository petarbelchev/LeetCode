namespace Tests;

internal class MajorityElementTests
{
	[Test]
	[TestCase(new int[] { 3, 2, 3 }, 3)]
	[TestCase(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
	public void Tests(int[] nums, int expect)
	{
		//Arrange
		var majorityElement = new MajorityElementTask();

		//Act
		int result = majorityElement.MajorityElement(nums);

		//Assert
		Assert.That(result, Is.EqualTo(expect));
	}
}
