class Minesweeper 
{
    List<int[]> theList = new List<int[]>();

    public List<int[]> GetThem()
    {
        var list1 = new List<int[]>();

        foreach (var x in theList)
        {
            if (x[0] == 4)
            {
                list1.Add(x);
            }
        }

        return list1;
    }
}