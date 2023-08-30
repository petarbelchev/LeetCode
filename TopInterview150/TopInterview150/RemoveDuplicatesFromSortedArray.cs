namespace TopInterview150;

public class RemoveDuplicatesFromSortedArray
{
	public int RemoveDuplicates(int[] nums)
	{
		int p = 1;

		if (nums.Length == 0)
			return 0;

		for (int i = 1; i < nums.Length; i++)
			if (nums[i - 1] != nums[i])
				nums[p++] = nums[i];

		return p;
	}

	public int RemoveDuplicatesII(int[] nums)
	{
		int p = 2;

		if (nums.Length < 2)
			return nums.Length;

		for (int i = 2; i < nums.Length; i++)
			if (nums[p - 2] != nums[i])
				nums[p++] = nums[i];

		return p;
	}
}
