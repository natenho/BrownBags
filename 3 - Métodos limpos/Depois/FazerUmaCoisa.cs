class FooService
{
    private Forno _forno = new Forno();
    private Batedeira _batedeira = new Batedeira();
    
    public Bolo FazerBolo()
    {
        PreaquecerForno();
        var claraEmNeve = BaterClaraEmNeve("clara");
        var mistura = Misturar("gemas", "margarina", "açúcar", claraEmNeve, "fermento");
        var forma = PrepararForma(mistura);
        var bolo = Assar(forma);

        return bolo;
    }

    private void PreaquecerForno()
    {
        _forno.Temperatura = 180;
        _forno.Acender();
    }

    private string BaterClaraEmNeve(params string[] ingredientes)
    {
        string claraEmNeve = "";
        while (claraEmNeve != "clara em neve")
        {
            for (int i = 0; i < 10; i++)
            {
                claraEmNeve = _batedeira.Bater(ingredientes);
            }
        }

        return claraEmNeve;
    }

    private string Misturar(params string[] ingredientes)
    {
        Random rng = new Random();

        int n = ingredientes.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            var value = ingredientes[k];
            ingredientes[k] = ingredientes[n];
            ingredientes[n] = value;
        }
    }

    private Forma PrepararForma(params string[] ingredientes)
    {
        var forma = new Forma(mistura);        
        forma.Untar();
        forma.Adicionar("farinha");
        
        return forma;
    }

    private Bolo Assar(Forma forma)
    {
        while(!forma.BoloEstaPronto)        
        {
            continue;
        }

        return forma.Bolo;
    }
}