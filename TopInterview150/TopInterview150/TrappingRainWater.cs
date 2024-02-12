namespace TopInterview150;

public class TrappingRainWater
{
    public int Trap(int[] height)
    {
        int water = 0;
        int highIdx = 0;
        int lowIdx = 0;

        for (int barIdx = 1; barIdx < height.Length; barIdx++)
        {
            if (height[lowIdx] < height[barIdx])
            {
                for (int i = barIdx - 1; i > highIdx; i--)
                {
                    int waterToFill = Math.Min(height[barIdx], height[highIdx]) - height[i];
                 
                    if (waterToFill <= 0)
                        break;
                    
                    height[i] += waterToFill;
                    water += waterToFill;
                }

                if (height[highIdx] <= height[barIdx])
                    highIdx = barIdx;
                
                lowIdx = barIdx;
            }
            else if (height[lowIdx] > height[barIdx])
            {
                lowIdx = barIdx;
            }
        }

        return water;
    }
}
