namespace TopInterview150;

public class RomanToInteger
{
    public int RomanToInt(string s)
    {
        int right = GetIntValue(s.Last());
        int integer = right;

        for (int i = s.Length - 2; i >= 0; i--)
        {
            int left = GetIntValue(s[i]);

            if (left < right) integer -= left;
            else integer += left;

            right = left;
        }

        return integer;
    }

    int GetIntValue(char ch) => ch switch
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _ => throw new ArgumentException("The Roman numeral contains an invalid symbol.")
    };
}
