public abstract class Ave
{
    public int IdAve { get; set; }
    public string Nome { get; set; } // ESTADO
    public string TipoBico { get; set; } // ESTADO
    public int NumeroRegistroIbama { get; private set; }
    public ClassificacaoAve Classificacao { get; set; }

    public Ave(int numeroRegistroIbamaConstrutor)
    {
        Console.WriteLine("Executou o método construtor da classe pai");
        this.SetNumeroRegistroIbama(numeroRegistroIbamaConstrutor);
    }

    private void SetNumeroRegistroIbama(int numero)
    {
        this.NumeroRegistroIbama = numero;
    }

    public string Voar() // VOAR
    {
        return "Ave voando na classe abstrata!";
    }

    public virtual string Bicar()
    {
        return "A ave está bicando na classe abstrata".ToString();
    }
}