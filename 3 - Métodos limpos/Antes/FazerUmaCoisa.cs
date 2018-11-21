class FooService
{
    private Forno _forno = new Forno();
    private Batedeira _batedeira = new Batedeira();
    
    public Bolo FazerBolo()
    {
        _forno.Temperatura = 180;
        _forno.Acender();

        var ingredientes = new [] { "clara" };

        string claraEmNeve = "";
        while (claraEmNeve != "clara em neve")
        {
            for (int i = 0; i < 10; i++)
            {
                claraEmNeve = _batedeira.Bater(ingredientes);
            }
        }

        ingredientes = new [] { "gemas", "margarina", "açúcar", claraEmNeve, "fermento" };

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

        var forma = new Forma(mistura);        
        forma.Untar();
        forma.Adicionar("farinha");

        while(!forma.BoloEstaPronto)        
        {
            continue;
        }

        return forma.Bolo;
    }
}