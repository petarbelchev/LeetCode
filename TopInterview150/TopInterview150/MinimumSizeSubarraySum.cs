namespace TopInterview150;

public class MinimumSizeSubarraySum
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int left = 0;
        int minSize = int.MaxValue;
        int sum = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            sum += nums[right];
            
            while (sum >= target)
            {
                minSize = Math.Min(minSize, right - left + 1);
                sum -= nums[left++];
            }
        }

        return minSize < int.MaxValue ? minSize : 0;
    }
}
