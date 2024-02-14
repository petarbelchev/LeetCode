namespace TopInterview150;

public class ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        var validator = new HashSet<string>();

        for (int row = 0; row < board.Length; row++)
        {
            for (int col = 0; col < board.Length; col++)
            {
                if (board[row][col] != '.')
                {
                    string value = '(' + board[row][col] + ")";

                    if (validator.Add(row + value) == false
                        || validator.Add(value + col) == false
                        || validator.Add((row / 3) + value + (col / 3)) == false)
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }
}
