namespace TopInterview150;

public class TwoSumII_InputArrayIsSorted
{
    public int[] TwoSum(int[] numbers, int target)
    {
        for (int i1 = 0; i1 < numbers.Length - 1; i1++)
        {
            if (i1 > 0 && numbers[i1] == numbers[i1 - 1])
                continue;

            int i2 = FindNumberIndex(numbers, i1, target - numbers[i1]);

            if (i2 != -1)
                return new int[] { i1 + 1, i2 + 1 };
        }

        return Array.Empty<int>();
    }

    static int FindNumberIndex(int[] numbers, int offset, int number)
    {
        int left = offset + 1;
        int right = numbers.Length - 1;

        while (left <= right)
        {
            int mid = left + ((right - left) / 2);

            if (numbers[mid] < number) left = mid + 1;
            else if (numbers[mid] > number) right = mid - 1;
            else return mid;
        }

        return -1;
    }
}
