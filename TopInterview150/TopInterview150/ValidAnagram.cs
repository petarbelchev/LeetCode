namespace TopInterview150;

public class ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var chars = new Dictionary<char, int>();
        foreach (char ch in s)
        {
            if (chars.ContainsKey(ch)) chars[ch]++;
            else chars[ch] = 1;
        }

        foreach (char ch in t)
        {
            if (chars.TryGetValue(ch, out int count) && count > 0)
            {
                chars[ch]--;
            }
            else return false;
        }

        return true;
    }
}
