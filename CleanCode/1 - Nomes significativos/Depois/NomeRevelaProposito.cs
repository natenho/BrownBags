class NomeRevelaProposito
{
    public int Calcular(DateTime data)
    {
        int tempoDecorridoEmDias = DateTime.Now.Subtract(data).Days;

        // ...
    }
}