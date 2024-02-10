namespace TopInterview150;

public class CandyTask
{
    public int Candy(int[] ratings)
    {
        int[] candies = Enumerable.Repeat(1, ratings.Length).ToArray();
        var stack = new Stack<int>();

        for (int child = 1; child < ratings.Length; child++)
        {
            if (ratings[child] > ratings[child - 1])
                candies[child] = candies[child - 1] + 1;
            else if (ratings[child] < ratings[child - 1] && candies[child - 1] == 1)
                stack.Push(child - 1);
        }

        while (stack.Any())
        {
            int child = stack.Pop();
            candies[child] = candies[child + 1] + 1;

            if (child > 0
                && ratings[child - 1] > ratings[child]
                && candies[child - 1] <= candies[child])
            {
                stack.Push(child - 1);
            }
        }

        return candies.Sum();
    }
}
