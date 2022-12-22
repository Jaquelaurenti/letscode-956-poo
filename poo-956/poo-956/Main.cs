
using static Atributos;

public class Program
{
    public static void Main(string[] args)
    {
        /*Console.WriteLine("Iniciando nossas aulas de POO");

        // Instanciando a classe pessoa
        // Criando uma varia do tipo Pessoa
        // ou seja, a partir deste momento a variavel
        // pessoa passa a ser um objeto da Classe pessoa
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Jaqueline";
        pessoa.Idade = 28;

        // verificar o que tem dentro da variavel pessoa
        Console.WriteLine(pessoa.Nome);

        // Outra forma de instanciar
        Pessoa pessoa1 = new Pessoa
        {
            Nome = "Jose Augusto",
            Idade = 20,
            // atribuindo ao cargo que é uma propriedade
            // da classe algum valor declaro no ENUM
            Cargo = Cargos.DEV

        };

        pessoa1.Sobrenome = "Laurenti";

        Console.WriteLine(pessoa1.DataCriação.ToString());*/

        ////////////////////////////////
        ///// Testando os atributos
        ///

        /*Console.WriteLine("Iniciando os testes do atributo personalizado");
        // instanciei a classe de teste de atributos
        TestarAtributos testarAtributos = new TestarAtributos();
        // invocar o método que testa o atributo
        testarAtributos.ExecutaTeste();*/


        //////////////////
        //////
        //////
        /// modificadores de acesso
        ///

        // instanciar a classe Modificadores de Acesso
        /*ModificadoresDeAcesso pessoa = new ModificadoresDeAcesso();

        Console.WriteLine(pessoa.AdicionaSalario(100));
        Console.WriteLine(pessoa);

        Console.WriteLine(pessoa.ExecutaMetodoEstatico());

        // instanciando a classe Herdade
        ModificadoresDeAcessoHerdado herdado = new ModificadoresDeAcessoHerdado();
      
        // adicioonando o valor da propriedade protegiada através de um método da classe PAI
        herdado.AdicionaSalario(200);
        herdado.Nome = "JAQUE";

        // visualizando as propriedades através de um método da classe FILHA
        herdado.ApresentaPropriedadesProtected();
        */

        /////
        ///+
        ///Construtores
        ///

        /*Construtores construtores = new Construtores("Jaque", "Laurenti");
        var x = construtores.PrimeiroNome;

        Console.WriteLine(x*/

        // Construtor de Uma instrução
        // Neste exemplo o construtor está recebendo apenas UM PARÂMETRO
        /*ConstrutoresDeUmaInstrucao cdum = new ConstrutoresDeUmaInstrucao("JaqueConstrutor");


        Console.WriteLine("------------Resultado do acesso a propriedade---------------");
        Console.WriteLine(cdum.NomePublico);

        Console.WriteLine("------------modificando o valor da propriedade publica---------------");
        cdum.NomePublico = "Joaozinho";
        Console.WriteLine(cdum.NomePublico);*/


        // iniciando construtor conta

        //Conta conta = new Conta(12346);
        //Console.WriteLine(conta.NumeroConta);

        //conta.NumeroConta = 333;

        /*ContaCorrente contaCorrente = new ContaCorrente(4943,01111);
        Console.WriteLine("Conta Corrente:");
        Console.WriteLine(contaCorrente.NumeroConta);
        contaCorrente.Depositar(250.00, "ContaCorrente");
        Console.WriteLine(contaCorrente.SaldoConta);*/

        ClassificacaoAve classificacao = new(1, "Passeriformes");

        Papagaio papagaio = new Papagaio(9999);
        Console.WriteLine(papagaio.NumeroRegistroIbama);

        papagaio.Classificacao = classificacao;
        papagaio.Cor = "Verde";
        papagaio.Falar = true;
        papagaio.TipoBico = "Generalista";

        Console.WriteLine(papagaio.Bicar());
        Console.WriteLine(papagaio.Voar(false));
        Console.WriteLine(papagaio.Classificacao.Id);
        Console.WriteLine( papagaio.Cor);
        Console.WriteLine(papagaio.Classificacao.Classificacao);

    }
}


