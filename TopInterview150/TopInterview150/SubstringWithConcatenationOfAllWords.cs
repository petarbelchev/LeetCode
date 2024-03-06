namespace TopInterview150;

public class SubstringWithConcatenationOfAllWords
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        int wordsLength = words[0].Length;
        var indices = new List<int>();

        if (s.Length < words.Length * wordsLength)
            return indices;

        var wordsFound = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (wordsFound.ContainsKey(word) == false)
                wordsFound[word] = 0;

            wordsFound[word]++;
        }

        var wordsCount = new Dictionary<string, int>();

        for (int i = 0; i < wordsLength; i++)
        {
            int left = i;
            int right = i;
            int currentWordsCount = 0;

            while (right <= s.Length - wordsLength)
            {
                string word = s.Substring(right, wordsLength);
                right += wordsLength;

                if (wordsFound.ContainsKey(word))
                {
                    if (!wordsCount.ContainsKey(word))
                        wordsCount[word] = 0;

                    wordsCount[word]++;
                    currentWordsCount++;

                    while (wordsFound[word] < wordsCount[word])
                    {
                        string leftWord = s.Substring(left, wordsLength);
                        wordsCount[leftWord]--;
                        currentWordsCount--;
                        left += wordsLength;
                    }

                    if (currentWordsCount == words.Length)
                        indices.Add(left);
                }
                else
                {
                    left = right;
                    wordsCount.Clear();
                    currentWordsCount = 0;
                }
            }

            wordsCount.Clear();
        }

        return indices;
    }
}
