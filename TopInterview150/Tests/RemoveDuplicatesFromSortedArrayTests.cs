namespace Tests;

internal class RemoveDuplicatesFromSortedArrayTests
{
	[Test]
	[TestCase(new int[] { 1, 1, 2 }, new int[] { 1, 2 })]
	[TestCase(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 })]
	public void RemoveDuplicates_Tests(int[] nums, int[] expected)
	{
		//Arrange
		var removeDuplicates = new RemoveDuplicatesFromSortedArray();

		//Act
		int k = removeDuplicates.RemoveDuplicates(nums);

		//Assert
		Assert.Multiple(() =>
		{
			Assert.That(k, Is.EqualTo(expected.Length));

			for (int i = 0; i < k; i++)
				Assert.That(nums[i], Is.EqualTo(expected[i]));
		});
	}

	[Test]
	[TestCase(new int[] { 1, 1, 1, 2, 2, 3 }, new int[] { 1, 1, 2, 2, 3 })]
	[TestCase(new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }, new int[] { 0, 0, 1, 1, 2, 3, 3 })]
	public void RemoveDuplicatesII_Tests(int[] nums, int[] expected)
	{
		//Arrange
		var removeDuplicates = new RemoveDuplicatesFromSortedArray();

		//Act
		int k = removeDuplicates.RemoveDuplicatesII(nums);

		//Assert
		Assert.Multiple(() =>
		{
			Assert.That(k, Is.EqualTo(expected.Length));

			for (int i = 0; i < k; i++)
				Assert.That(nums[i], Is.EqualTo(expected[i]));
		});
	}
}
