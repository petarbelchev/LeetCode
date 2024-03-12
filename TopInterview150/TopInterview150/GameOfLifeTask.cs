namespace TopInterview150;

public class GameOfLifeTask
{
    public void GameOfLife(int[][] board)
    {
        for (int row = 0; row < board.Length; row++)
        {
            for (int col = 0; col < board[row].Length; col++)
            {
                int liveNeighborsCount = GetLiveNeighborsCount(row, col, board);
                DecideLiveOrDead(row, col, board, liveNeighborsCount);
            }
        }

        MakeChanges(board);
    }

    private int GetLiveNeighborsCount(int row, int col, int[][] board)
    {
        int count = 0;

        for (int rowIdx = row - 1;
            rowIdx <= row + 1 && rowIdx < board.Length;
            rowIdx++)
        {
            if (rowIdx < 0)
                continue;

            for (int colIdx = col - 1;
                colIdx <= col + 1 && colIdx < board[row].Length;
                colIdx++)
            {
                if (colIdx < 0 || (rowIdx == row && colIdx == col))
                    continue;

                if (board[rowIdx][colIdx] == 1 || board[rowIdx][colIdx] == 2)
                    count++;
            }
        }

        return count;
    }

    private void DecideLiveOrDead(
        int row,
        int col,
        int[][] board,
        int liveNeighborsCount)
    {
        if (board[row][col] == 1)
        {
            if (liveNeighborsCount < 2 || liveNeighborsCount > 3)
                board[row][col] = 2; // die
        }
        else
        {
            if (liveNeighborsCount == 3)
                board[row][col] = 3; // live
        }
    }

    private void MakeChanges(int[][] board)
    {
        for (int row = 0; row < board.Length; row++)
        {
            for (int col = 0; col < board[row].Length; col++)
            {
                if (board[row][col] == 2)
                {
                    board[row][col] = 0;
                }
                else if (board[row][col] == 3)
                {
                    board[row][col] = 1;
                }
            }
        }
    }
}
