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
                if (IsValid(currentRow, j, positions))
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
    }
}
