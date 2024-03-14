namespace TopInterview150;

public class SummaryRangesTask
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var result = new List<string>();

        if (nums.Length == 0) return result;

        int l = nums[0];
        int r = l;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == r + 1) r = nums[i];
            else
            {
                result.Add(GetOutput(l, r));

                l = nums[i];
                r = l;
            }
        }

        result.Add(GetOutput(l, r));

        return result;
    }

    static string GetOutput(int l, int r)
    {
        if (l == r) return $"{l}";
        else return l + "->" + r;
    }
}
