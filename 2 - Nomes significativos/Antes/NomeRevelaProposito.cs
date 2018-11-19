class NomeRevelaProposito
{
    public int Calcular(DateTime data)
    {
        int d = DateTime.Now.Subtract(data).Days;

        // ...
    }
}