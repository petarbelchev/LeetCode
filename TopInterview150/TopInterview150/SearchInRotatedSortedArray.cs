namespace TopInterview150;

public class SearchInRotatedSortedArray
{
    public int Search(int[] nums, int target)
    {
        if (nums[0] > nums[^1])
        {
            int boundary = FindBoundary(nums);

            if (target < nums[0])
                return FindTargetIndex(nums, boundary + 1, nums.Length - 1, target);

            return FindTargetIndex(nums, 0, boundary, target);
        }

        return FindTargetIndex(nums, 0, nums.Length - 1, target);
    }

    private int FindBoundary(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (nums[mid] < nums[left])
                right = mid - 1;
            else if (nums[mid] < nums[mid + 1])
                left = mid + 1;
            else if (mid == 0 || (nums[mid] > nums[mid + 1]))
                return mid;
        }

        return -1;
    }

    private int FindTargetIndex(int[] nums, int left, int right, int target)
    {
        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                left = mid + 1;
            else if (nums[mid] > target)
                right = mid - 1;
        }

        return -1;
    }
}
