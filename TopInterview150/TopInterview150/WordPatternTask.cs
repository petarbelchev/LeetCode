namespace TopInterview150;

public class WordPatternTask
{
    public bool WordPattern(string pattern, string s)
    {
        var words = s.Split();

        if (words.Length != pattern.Length)
            return false;

        var map = new Dictionary<char, string>();
        var usedWords = new HashSet<string>();

        for (int i = 0; i < words.Length; i++)
        {
            if (map.TryGetValue(pattern[i], out string? word))
            {
                if (word == words[i])
                    continue;

                return false;
            }

            if (usedWords.Contains(words[i]))
            {
                return false;
            }
            else
            {
                map[pattern[i]] = words[i];
                usedWords.Add(words[i]);
            }
        }

        return true;
    }
}
