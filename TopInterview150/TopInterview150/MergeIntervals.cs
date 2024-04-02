namespace TopInterview150;

public class MergeIntervals
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length == 1) return intervals;

        Array.Sort(intervals, (x, y) => x[0] - y[0]);
        var merged = new List<int[]>();

        for (int i = 1; i < intervals.Length; i++)
        {
            int[] left = intervals[i - 1];
            int[] right = intervals[i];

            if (left[1] >= right[0])
            {
                intervals[i] = new int[] { left[0], Math.Max(left[1], right[1]) };
            }
            else merged.Add(left);

            if (i == intervals.Length - 1) merged.Add(intervals[i]);
        }

        return merged.ToArray();
    }
}
