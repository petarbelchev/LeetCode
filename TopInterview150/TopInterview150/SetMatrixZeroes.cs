namespace TopInterview150;

public class SetMatrixZeroes
{
    public void SetZeroes(int[][] matrix)
    {
        bool shouldSetZerosToFirstRow = CheckFirstRow(matrix);

        if (matrix.Length == 1)
        {
            if (shouldSetZerosToFirstRow) SetFirstRowZeros(matrix);

            return;
        }

        bool shouldSetZerosToFirstCol = CheckFirstCol(matrix);

        if (matrix[0].Length == 1)
        {
            if (shouldSetZerosToFirstCol) SetFirstColZeros(matrix);

            return;
        }

        CheckForZeros(matrix);
        SetZeros(matrix);

        if (shouldSetZerosToFirstRow) SetFirstRowZeros(matrix);
        if (shouldSetZerosToFirstCol) SetFirstColZeros(matrix);
    }

    static bool CheckFirstRow(int[][] matrix)
    {
        for (int col = 0; col < matrix[0].Length; col++)
            if (matrix[0][col] == 0) return true;

        return false;
    }

    static bool CheckFirstCol(int[][] matrix)
    {
        for (int row = 0; row < matrix.Length; row++)
            if (matrix[row][0] == 0) return true;

        return false;
    }

    static void SetFirstRowZeros(int[][] matrix)
    {
        for (int col = 0; col < matrix[0].Length; col++)
            matrix[0][col] = 0;
    }

    static void SetFirstColZeros(int[][] matrix)
    {
        for (int row = 0; row < matrix.Length; row++)
            matrix[row][0] = 0;
    }

    static void CheckForZeros(int[][] matrix)
    {
        for (int row = 1; row < matrix.Length; row++)
        {
            for (int col = 1; col < matrix[row].Length; col++)
            {
                if (matrix[row][col] == 0)
                {
                    matrix[0][col] = 0;
                    matrix[row][0] = 0;
                }
            }
        }
    }

    static void SetZeros(int[][] matrix)
    {
        for (int row = 1; row < matrix.Length; row++)
        {
            for (int col = 1; col < matrix[row].Length; col++)
            {
                if (matrix[row][0] == 0 || matrix[0][col] == 0)
                    matrix[row][col] = 0;
            }
        }
    }
}
