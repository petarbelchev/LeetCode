namespace TopInterview150;

public class LengthLastWord
{
    public int LengthOfLastWord(string s)
    {
        int end = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                end = i;
                break;
            }
        }

        int len = 1;
        for (int i = end - 1; i >= 0; i--)
        {
            if (s[i] != ' ') len++;
            else break;
        }

        return len;
    }
}
