using System.Text;

namespace TopInterview150;

internal class LongestCommonPrefixTask
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
            return strs[0];

        var sb = new StringBuilder();

        for (int i = 0; i < strs[0].Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[j].Length <= i || strs[j][i] != strs[0][i])
                    return sb.ToString();
            }

            sb.Append(strs[0][i]);
        }

        return sb.ToString();
    }
}
