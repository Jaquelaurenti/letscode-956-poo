public class ContaCorrente : Conta
{
    public double TaxaDeSaque { get; set; }

    public ContaCorrente(int agencia, int conta) : base(agencia, conta)
    {
       
    }
    /*
    public override void Sacar(double valor)
    {
        base.Sacar(valor);

        double taxa = (this.SaldoConta / 100) * 0.05;
        this.TaxaDeSaque = taxa;    
        this.SaldoConta = this.SaldoConta - taxa;
    }*/

    // Sobrescrita de método
    public override void Sacar(double valor)
    {
        base.Sacar(valor);
    }


    public void Depositar(double valor, string tipoConta)
    {
        Console.WriteLine("Executou o método de sobrecarga");
    }
}


/*
 
 Construa uma classe abstrata de nome Ave
    Essa classe deverá ter:
    - Nome: String
    - TipoBico: String
    - NumeroRegistroIbama: int

    O registro do ibama é um campo que só deve pertencer a AVE,
    as especializações não poderão ATRIBUIR valor.

    Deverá existir uma composição de Classificacao da Ave.
    A classificação deverá ter (ID e Classificacao)

    Utilizando o polimorfismo, vamos criar dois métodos na classe abstrata:
    bicar: o método bicar deverá sofrer uma sobrescrita nas especilizações.
    voar: o método voar, deverá sofrer uma sobrecarga nas especializações,
    essa sobrecarga será para determinar se a ave voa ou não.

 
 
 
 
 */