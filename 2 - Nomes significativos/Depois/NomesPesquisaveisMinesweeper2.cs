class Minesweeper 
{
    List<Cell> gameBoard = new List<Cell>();

    public List<Cell> GetFlaggedCells()
    {
        var flaggedCells = new List<Cell>();

        foreach (var cell in gameBoard)
        {
            if (cell.IsFlagged())
            {
                flaggedCells.Add(cell);
            }
        }

        return flaggedCells;
    }   
}

enum CellStatus
{
    Closed = 1,
    Open = 2,
    Flagged = 4
}

class Cell
{
    public CellStatus Status {get;set;}

    public bool IsFlagged()
    {
        return Status == CellStatus.Flagged;
    }
}