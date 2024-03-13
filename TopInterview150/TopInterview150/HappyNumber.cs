namespace TopInterview150;

public class HappyNumber
{
    public bool IsHappy(int n)
    {
        if (n == 1) return true;

        var sums = new HashSet<int>();

        while (true)
        {
            int sum = 0;

            while (n > 0)
            {
                int m = n % 10;
                n /= 10;
                sum += m * m;
            }

            if (sum == 1) return true;

            if (!sums.Add(sum)) return false;

            n = sum;
        }
    }
}
