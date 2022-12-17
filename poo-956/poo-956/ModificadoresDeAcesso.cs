/*
 
public: acesso irrestrito
protected: o acesso ele é limitado a classe, ou a quem deriva dela
internal: o acesso é limitado somente ao assembly
protected internal: o acesso limitado apenas ao assembly que ele pertence ou que foi criado
private: acesso apenas a classe que o criou


 
 */

public class ModificadoresDeAcesso
{

    private int Idade { get; set; }
    public string Nome { get; set; }
    protected double Salario { get; set; }
    private int AnoNascimento { get; set; }

    // adicionando salario que irá funcionar somente no contexto da classe criada e de quem a herdar
    public string AdicionaSalario(double valor)
    {
        Console.WriteLine("Executando o método");
        Salario = valor;
        Console.WriteLine(Salario);
        return "Valor adicionado";
    }


    public void ExecutaMetodoProtected(int valor)
    {
        InsereAnoNascimento(2022);
    }

    // adicionando salario que irá funcionar somente no contexto da classe criada
    protected void InsereAnoNascimento(int anoRecebido)
    {
        Console.WriteLine("Ano Nascimento Recebido");
        // atribuir valor a propriedade privada
        this.AnoNascimento = anoRecebido;
        // visualizar a propriedade privada
        Console.WriteLine("Ano NAscimento Alterado:" + AnoNascimento);
    }

    public string ExecutaMetodoEstatico()
    {
        return MetodoEstatico();
    }


    static string MetodoEstatico()
    {
        return "Executando o método estático";
    }

}
