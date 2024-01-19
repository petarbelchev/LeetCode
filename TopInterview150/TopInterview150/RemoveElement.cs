namespace TopInterview150;

public class RemoveElement
{
    public int Remove(int[] nums, int val)
    {
        int p = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
                nums[p++] = nums[i];
        }

        return p;
    }
}
