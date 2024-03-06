namespace TopInterview150;

public class MinimumWindowSubstring
{
    readonly int[] _required = new int[128];
    readonly int[] _founded = new int[128];
    int _length = int.MaxValue;
    int _counter = 0;
    int _left = 0;
    int _right = 0;
    int _minStart = 0;

    public string MinWindow(string s, string t)
    {
        if (s.Length < t.Length)
            return string.Empty;

        SetRequiredChars(t);

        while (_right < s.Length)
        {
            CheckRight(s);

            while (ShouldCheckWindow(t))
            {
                CheckWindow();
                MoveLeft(s);
            }

            _right++;
        }

        return GetMinWindow(s);
    }

    void SetRequiredChars(string t)
    {
        foreach (char ch in t)
            _required[ch]++;
    }

    void CheckRight(string s)
    {
        char ch = s[_right];

        if (_required[ch] > 0)
        {
            _founded[ch]++;

            if (_required[ch] >= _founded[ch])
                _counter++;
        }
    }

    bool ShouldCheckWindow(string t) => _counter == t.Length;

    void CheckWindow()
    {
        int currLength = _right + 1 - _left;

        if (currLength < _length)
        {
            _length = currLength;
            _minStart = _left;
        }
    }

    void MoveLeft(string s)
    {
        do
        {
            char leftChar = s[_left++];

            if (_required[leftChar] > 0)
            {
                _founded[leftChar]--;

                if (_required[leftChar] > _founded[leftChar])
                    _counter--;
            }

        } while (_left < _right && _required[s[_left]] == 0);
    }

    string GetMinWindow(string s)
        => _length == int.MaxValue ? string.Empty : s.Substring(_minStart, _length);
}
