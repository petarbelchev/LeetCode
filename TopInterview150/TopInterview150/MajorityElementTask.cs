namespace TopInterview150;

public class MajorityElementTask
{
	public int MajorityElement(int[] nums)
	{
		int elem = nums[0];
		int count = 1;

		for (int i = 1; i < nums.Length; i++)
		{
			if (nums[i] == elem)
			{
				count++;

				if (count > nums.Length / 2)
					return elem;
			}
			else
			{
				count--;

				if (count == 0)
				{
					elem = nums[i];
					count = 1;
				}
			}
		}

		return elem;
	}
}
