namespace TopInterview150;

public class RandomizedSet
{
    private readonly Dictionary<int, int> dict;
    private readonly List<int> list;
    private readonly Random random;

    public RandomizedSet()
    {
        dict = new Dictionary<int, int>();
        list = new List<int>();
        random = new Random();
    }

    public bool Insert(int val)
    {
        if (!dict.ContainsKey(val))
        {
            list.Add(val);
            dict.Add(val, list.Count - 1);
            return true;
        }

        return false;
    }

    public bool Remove(int val)
    {
        if (dict.ContainsKey(val))
        {
            int i = dict[val];
            list[i] = list[list.Count - 1];
            dict[list[i]] = i;
            list.RemoveAt(list.Count - 1);
            dict.Remove(val);

            return true;
        }

        return false;
    }

    public int GetRandom()
        => list[random.Next(0, list.Count)];
}
