[Obsolete] // atributo do c#
public class Conta
{
    // propriedades

    public int NumeroConta { get; protected set; }
    public double SaldoConta { get; protected set; }
    public int Agencia { get; protected set; }
    public Pessoa pessoa { get; set; }
    static int Contador { get;set;}
    readonly int Id;



    // construtor principal
    public Conta(int numeroContaParametroConstrutor)
    {
        // o que veio do construtor eu atribuo na propriedade NUmeroConta
        Console.WriteLine("Passando pelo Construtor da classe Conta");
        this.NumeroConta = numeroContaParametroConstrutor;
        

    }

    // sobrecarga (overload) do método construtor
    public Conta(int agencia, int numeroConta)
    {
        Console.WriteLine("Executou o construtor sobrecarga");
        Id = Contador;
        this.Agencia = agencia;
        this.NumeroConta = numeroConta;

    }

    //
    public void Depositar(double valor)
    {
        SaldoConta += valor;
    }


    // deixando virtual para que seja possível fazer a sobrescrita(override) deste método
    // nas classes especializadas
    public virtual void Sacar(double valor)
    {
        SaldoConta -= valor;
    }

    public void aplicaTarifa()
    {
        tarifaManutencao();
    }

    public void tarifaManutencao()
    {
        Contador++;
        Console.WriteLine(Contador);
    }

}