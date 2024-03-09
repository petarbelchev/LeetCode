namespace TopInterview150;

public class RotateImage
{
    int _top, _right, _left, _bottom, _rightBottomBoundary, _leftTopBoundary;

    public void Rotate(int[][] matrix)
    {
        if (matrix.Length == 1) return;

        int cycles = (matrix.Length - 1) / 2;
        for (int cycle = 0; cycle <= cycles; cycle++)
        {
            SetPointersAndBoundaries(matrix, cycle);

            while (_top < _rightBottomBoundary)
            {
                int right = MoveTopToRight(matrix);
                int bottom = MoveRightToBottom(right, matrix);
                int left = MoveBottomToLeft(bottom, matrix);
                MoveLeftToTop(left, matrix);
            }
        }
    }

    void SetPointersAndBoundaries(int[][] matrix, int cycle)
    {
        _top = cycle;
        _right = cycle;
        _left = matrix.Length - 1 - cycle;
        _bottom = matrix.Length - 1 - cycle;

        _leftTopBoundary = cycle;
        _rightBottomBoundary = matrix.Length - 1 - cycle;
    }

    int MoveTopToRight(int[][] matrix)
    {
        int rightElem = matrix[_right][_rightBottomBoundary];
        matrix[_right++][_rightBottomBoundary] = matrix[_leftTopBoundary][_top];

        return rightElem;
    }

    int MoveRightToBottom(int right, int[][] matrix)
    {
        int bottomElem = matrix[_rightBottomBoundary][_bottom];
        matrix[_rightBottomBoundary][_bottom--] = right;

        return bottomElem;
    }

    int MoveBottomToLeft(int bottom, int[][] matrix)
    {
        int leftElem = matrix[_left][_leftTopBoundary];
        matrix[_left--][_leftTopBoundary] = bottom;

        return leftElem;
    }

    void MoveLeftToTop(int left, int[][] matrix)
        => matrix[_leftTopBoundary][_top++] = left;
}
