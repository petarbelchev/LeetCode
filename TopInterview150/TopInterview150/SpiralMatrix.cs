namespace TopInterview150;

public class SpiralMatrix
{
    int _top = 0;
    int _left = 0;
    int _right;
    int _bottom;

    public IList<int> SpiralOrder(int[][] matrix)
    {
        _right = matrix[0].Length - 1;
        _bottom = matrix.Length - 1;

        if (_bottom == 0)
            return GetTop(matrix);

        if (_right == 0)
            return GetRight(matrix);

        var output = new List<int>();

        while (true)
        {
            output.AddRange(GetTop(matrix));

            if (BottomPassTopOrLeftPassRight()) break;

            output.AddRange(GetRight(matrix));
            output.AddRange(GetBottom(matrix));

            if (BottomPassTopOrLeftPassRight()) break;

            output.AddRange(GetLeft(matrix));
        }

        return output;
    }

    IList<int> GetBottom(int[][] matrix)
    {
        var output = new List<int>();

        for (int col = _right; col >= _left; col--)
            output.Add(matrix[_bottom][col]);

        _bottom--;

        return output;
    }

    IList<int> GetRight(int[][] matrix)
    {
        var output = new List<int>();

        for (int row = _top; row <= _bottom; row++)
            output.Add(matrix[row][_right]);

        _right--;

        return output;
    }

    IList<int> GetTop(int[][] matrix)
    {
        var output = new List<int>();

        for (int col = _left; col <= _right; col++)
            output.Add(matrix[_top][col]);

        _top++;

        return output;
    }

    IList<int> GetLeft(int[][] matrix)
    {
        var output = new List<int>();

        for (int row = _bottom; row >= _top; row--)
            output.Add(matrix[row][_left]);

        _left++;

        return output;
    }

    bool BottomPassTopOrLeftPassRight()
        => _bottom < _top || _left > _right;
}
