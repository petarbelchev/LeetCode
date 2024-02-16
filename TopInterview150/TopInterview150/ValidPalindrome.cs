namespace TopInterview150;

class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        int l = 0;
        int r = s.Length - 1;

        while (l <= r)
        {
            if (char.IsLetterOrDigit(s[l]) == false)
            {
                l++;
                continue;
            }

            if (char.IsLetterOrDigit(s[r]) == false)
            {
                r--;
                continue;
            }

            if (char.ToLower(s[l++]) != char.ToLower(s[r--]))
                return false;
        }

        return true;
    }
}
