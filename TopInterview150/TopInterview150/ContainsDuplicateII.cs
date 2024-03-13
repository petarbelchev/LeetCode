namespace TopInterview150;

public class ContainsDuplicateII
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        if (nums.Length == 1) return false;

        var tracker = new Dictionary<int, int>();

        for (int currIdx = 0; currIdx < nums.Length; currIdx++)
        {
            if (tracker.TryGetValue(nums[currIdx], out int lastIdx))
            {
                if (currIdx - lastIdx <= k) return true; 
            }

            tracker[nums[currIdx]] = currIdx;
        }

        return false;
    }
}
