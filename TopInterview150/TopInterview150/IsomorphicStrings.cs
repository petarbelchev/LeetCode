namespace TopInterview150;

public class IsomorphicStrings
{
    public bool IsIsomorphic(string s, string t)
    {
        var maps = new Dictionary<char, char>();
        var reverseMaps = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (maps.TryGetValue(s[i], out char value))
            {
                if (value != t[i])
                {
                    return false;
                }
            }
            else
            {
                if (reverseMaps.TryGetValue(t[i], out char reverseValue) 
                    && reverseValue != s[i])
                {
                    return false;
                }
                maps.Add(s[i], t[i]);
                reverseMaps.Add(t[i], s[i]);
            }
        }
        return true;
    }
}
