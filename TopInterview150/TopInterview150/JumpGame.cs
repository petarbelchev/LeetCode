namespace TopInterview150;

public class JumpGame
{
    public bool CanJump(int[] nums)
    {
        int bounder = 0;

        for (int i = 0; i <= bounder; i++)
        {
            int p = i + nums[i];

            if (p >= nums.Length - 1)
                return true;

            if (p > bounder)
                bounder = p;
        }

        return false;
    }

    public int Jump(int[] nums)
    {
        int lastStepBounder = -1;
        int stepBounder = 0;
        int stepCounter = 0;
        int currPosition = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (currPosition >= nums.Length - 1)
                break;

            currPosition = i + nums[i];

            if (currPosition > stepBounder)
            {
                if (i > lastStepBounder)
                {
                    stepCounter++;
                    lastStepBounder = stepBounder;
                }

                stepBounder = currPosition;
            }
        }

        return stepCounter;
    }
}
