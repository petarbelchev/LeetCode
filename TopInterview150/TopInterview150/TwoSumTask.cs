namespace TopInterview150;

public class TwoSumTask
{
    public int[] TwoSum(int[] nums, int target)
    {
        var seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.TryGetValue(target - nums[i], out int j))
                return new int[] { i, j };

            seen[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
