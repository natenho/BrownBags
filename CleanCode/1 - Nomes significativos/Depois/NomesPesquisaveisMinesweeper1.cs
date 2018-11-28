class Minesweeper 
{
    private const int STATUS_VALUE = 0;
    private const int FLAGGED = 4;

    List<int[]> gameBoard = new List<int[]>();

    public List<int[]> GetFlaggedCells()
    {
        var flaggedCells = new List<int[]>();

        foreach (var cell in gameBoard)
        {
            if (cell[STATUS_VALUE] == FLAGGED)
            {
                flaggedCells.Add(cell);
            }
        }

        return flaggedCells;
    }    
}