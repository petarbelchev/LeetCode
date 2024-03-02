namespace TopInterview150;

public class LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0 || s.Length == 1)
            return s.Length;

        int l = 0;
        var sequence = new Dictionary<char, int>() { { s[l], l } };
        int maxSequenceLength = 1;

        for (int r = 1; r < s.Length; r++)
        {
            if (sequence.TryGetValue(s[r], out int repeatedCharIndex))
            {
                while (s[repeatedCharIndex] == s[r] && repeatedCharIndex < r)
                    repeatedCharIndex++;

                for (int i = l; i < repeatedCharIndex; i++)
                    sequence.Remove(s[i]);

                l = repeatedCharIndex;
                sequence.Add(s[r], r);
            }
            else
            {
                sequence.Add(s[r], r);

                if (sequence.Count > maxSequenceLength)
                    maxSequenceLength = sequence.Count;
            }
        }

        return maxSequenceLength;
    }
}
