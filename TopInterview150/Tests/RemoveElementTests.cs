namespace Tests;

internal class RemoveElementTests
{
	[Test]
	[TestCase(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 })]
	[TestCase(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 4, 3, 1, 0, 0 })]
	[TestCase(new int[] { 1 }, 1, new int[] {  })]
	[TestCase(new int[] { 3, 3 }, 3, new int[] {  })]
	[TestCase(new int[] { 4, 5 }, 4, new int[] { 5 })]
	public void Tests(int[] nums, int val, int[] expected)
	{
		//Arrange
		var removeElement = new RemoveElement();

		//Act
		int k = removeElement.Remove(nums, val);

		//Arrange
		nums = nums.Take(k).ToArray();
		Array.Sort(nums);
		Array.Reverse(nums);

		//Assert
		Assert.Multiple(() =>
		{
			Assert.That(k, Is.EqualTo(expected.Length));

			for (int i = 0; i < expected.Length; i++)
				Assert.That(nums[i], Is.EqualTo(expected[i]));
		});
	}
}
