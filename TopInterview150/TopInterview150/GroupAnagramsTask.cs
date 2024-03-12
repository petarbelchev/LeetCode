namespace TopInterview150;

public class GroupAnagramsTask
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var anagrams = new Dictionary<string, IList<string>>();

        foreach (string str in strs)
        {
            string strKey = BuildStrKey(str);

            if (!anagrams.ContainsKey(strKey))
                anagrams[strKey] = new List<string>();

            anagrams[strKey].Add(str);
        }

        return new List<IList<string>>(anagrams.Values);
    }

    private static string BuildStrKey(string str)
    {
        char[] characters = str.ToCharArray();
        Array.Sort(characters);
        return new string(characters);
    }
}
