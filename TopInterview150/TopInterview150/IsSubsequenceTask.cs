namespace TopInterview150;

class IsSubsequenceTask
{
    public bool IsSubsequence(string s, string t)
    {
        int sIdx = 0;
        int tIdx = 0;

        while (tIdx < t.Length && sIdx < s.Length)
        {
            if (t[tIdx] == s[sIdx])
            {
                tIdx++;
                sIdx++;
            }
            else
            {
                tIdx++;
            }
        }

        return sIdx >= s.Length;
    }
}
