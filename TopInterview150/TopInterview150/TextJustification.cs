namespace TopInterview150;

public class TextJustification
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        var result = new List<string>();
        var row = new Row(maxWidth);

        for (int i = 0; i < words.Length; i++)
        {
            if (row.AddWord(words[i]) == false)
            {
                i--;
                result.Add(row.GetRowData());
                row = new(maxWidth);
            }
        }

        result.Add(row.GetRowData(true));

        return result;
    }

    class Row
    {
        readonly int _maxWidth;
        int _length;
        readonly List<string> _data = new();

        public Row(int maxWidth) => _maxWidth = maxWidth;

        int RequiredSpaces => _data.Count - 1;

        public bool AddWord(string word)
        {
            if (_length + word.Length + _data.Count > _maxWidth)
                return false;

            _data.Add(word);
            _length += word.Length;

            return true;
        }

        public string GetRowData(bool isLastRow = false)
        {
            int spaces = _maxWidth - (_length + RequiredSpaces);

            if (isLastRow || _data.Count == 1)
                return string.Join(' ', _data) + new string(' ', spaces);

            int i = 0;
            while (spaces % RequiredSpaces != 0)
            {
                _data[i++] += ' ';
                spaces--;
            }

            return string.Join(new string(' ', spaces / RequiredSpaces + 1), _data);
        }
    }
}
