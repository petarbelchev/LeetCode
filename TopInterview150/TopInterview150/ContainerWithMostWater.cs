namespace TopInterview150;

internal class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        int l = 0;
        int r = height.Length - 1;
        int max = 0;

        while (l < r)
        {
            int v;
            int len = r - l;

            if (height[l] <= height[r])
            {
                v = len * height[l];
                l++;
            }
            else
            {
                v = len * height[r];
                r--;
            }

            if (max < v) max = v;
        }

        return max;
    }
}
