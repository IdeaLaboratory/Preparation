namespace Backtrack
{
    public class NQueen
    {
        public bool GetQueenPositions(int[,] positions, int currentRow)
        {
            if (currentRow >= positions.GetLength(0))
            {
                return true;
            }

            for (int j = 0; j < positions.GetLength(0); j++)
            {
                if (Safe(currentRow, j, positions))
                {
                    positions[currentRow, j] = 1;
                    if (GetQueenPositions(positions, currentRow + 1) == true)
                    {
                        return true;
                    }
                    positions[currentRow, j] = 0;
                }
            }
            return false;
        }

        bool IsValid(int i, int j, int[,] positions)
        {
            //for same row
            for (int row = 0; row < i; row++)
            {
                if (positions[row, j] == 1)
                {
                    return false;
                }
            }

            //for same col
            for (int col = 0; col < j; col++)
            {
                if (positions[i, col] == 1)
                {
                    return false;
                }
            }

            int tempi = i - 1;
            int tempj = j - 1;

            // left-up
            while (tempi > -1 && tempj > -1)
            {
                if (positions[tempi, tempj] == 1)
                {
                    return false;
                }
                tempi -= 1;
                tempj -= 1;
            }

            // right-up
            tempi = i - 1;
            tempj = j + 1;
            while (tempi > -1 && tempj < positions.GetLength(1))
            {
                if (positions[tempi, tempj] == 1)
                {
                    return false;
                }
                tempi -= 1;
                tempj += 1;
            }

            // left-down
            tempi = i + 1;
            tempj = j - 1;
            while (tempi < positions.GetLength(0) && tempj > -1)
            {
                if (positions[tempi, tempj] == 1)
                {
                    return false;
                }
                tempi += 1;
                tempj -= 1;
            }

            // right-down
            tempi = i + 1;
            tempj = j + 1;
            while (tempi > positions.GetLength(0) && tempj > positions.GetLength(0))
            {
                if (positions[tempi, tempj] == 1)
                {
                    return false;
                }
                tempi += 1;
                tempj += 1;
            }
            return true;
        }

        private static bool Safe(int i, int j, int[,] queens)
        {
            int length = queens.GetLength(0);
            //check same column, in all row
            for (int row = 0; row < length; row++)
            {
                if (queens[row, j] == 1)
                {
                    return false;
                }
            }

            //check same row, in each column
            for (int col = 0; col < length; col++)
            {
                if (queens[i, col] == 1)
                {
                    return false;
                }
            }

            //check slash diagonal
            // towards northWest 
            for (int northWest = 1; northWest < length; northWest++)
            {
                if (i - northWest >= 0 && j - northWest >= 0)
                {
                    if (queens[i - northWest, j - northWest] == 1)
                    {
                        return false;
                    }
                }
            }
            // towards southEast
            for (int southEast = 0; southEast < length; southEast++)
            {
                if (i + southEast < length && j + southEast < length)
                {
                    if (queens[i + southEast, j + southEast] == 1)
                    {
                        return false;
                    }
                }
            }

            //check back slash diagonal
            // towards northEast
            for (int northEast = 1; northEast < length; northEast++)
            {
                if (i - northEast >= 0 && j + northEast < length)
                {
                    if (queens[i - northEast, j + northEast] == 1)
                    {
                        return false;
                    }
                }
            }
            // towards southWest
            for (int southWest = 1; southWest < length; southWest++)
            {
                if (i + southWest < length && j - southWest >= 0)
                {
                    if (queens[i + southWest, j - southWest] == 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
