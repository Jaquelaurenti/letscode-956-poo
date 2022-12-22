public class Papagaio : Ave
{
    public string Cor { get; set; }
    public bool Falar { get; set; }
    public Papagaio(int numeroIbamaPapagaio) : base(numeroIbamaPapagaio)
    {
    }

    public string Voar(bool podeVoar)
    {
        if (!podeVoar)
        {
            return "O papagaio não pode voar!";
        }
        return "O papagaio pode voar !";
    }

    /*public override string Bicar()
    {
        return "O papagaio está bicando";
    }*/

    
}
