using System.Text;

namespace TopInterview150;

public class ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        if (s.Length == 1 || numRows == 1 || numRows >= s.Length)
            return s;

        var result = new StringBuilder();

        for (int row = 0; row < numRows; row++)
        {
            int downSteps = (2 * (numRows - row)) - 2;
            int upSteps = 2 * row;
            int i = row;
            result.Append(s[i]);

            while (i < s.Length)
            {
                i += downSteps;
                if (i >= s.Length)
                    break;

                if (downSteps > 0)
                    result.Append(s[i]);

                i += upSteps;
                if (i < s.Length && upSteps > 0)
                    result.Append(s[i]);
            }
        }

        return result.ToString();
    }
}
