namespace TopInterview150;

public class ReverseWordsInString
{
    public string ReverseWords(string s)
        => string.Join(' ', s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
}
