namespace TopInterview150;

public class _3Sum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        int start = 0;

        while (start < nums.Length - 2)
        {
            int left = start + 1;
            int right = nums.Length - 1;

            if (nums[start] + nums[left] > 0)
                break;

            while (left != -1 && right != -1 && left < right)
            {
                int sum = nums[start] + nums[left] + nums[right];

                if (sum < 0)
                    left++;
                else if (sum > 0)
                    right--;
                else
                {
                    result.Add(new List<int>() { nums[start], nums[left], nums[right] });
                    int newLeft = TakeNextLeftIndex(left, right, nums);
                    right = TakeNextRightIndex(left, right, nums);
                    left = newLeft;
                }
            }

            start = TakeNextLeftIndex(start, nums.Length - 1, nums);

            if (start == -1)
                break;
        }

        return result;
    }

    static int TakeNextLeftIndex(int left, int right, IList<int> nums)
    {
        for (int i = left + 1; i < right; i++)
        {
            if (nums[i] != nums[left])
                return i;
        }

        return -1;
    }

    static int TakeNextRightIndex(int left, int right, IList<int> nums)
    {
        for (int i = right - 1; i > left; i--)
        {
            if (nums[i] != nums[right])
                return i;
        }

        return -1;
    }
}
