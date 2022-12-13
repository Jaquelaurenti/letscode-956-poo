
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Iniciando nossas aulas de POO");

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
            // atribuindo ao cargo que é uma propriedade da classe algum valor declaro no ENUM
            Cargo = Cargos.DEV

        };

        Console.WriteLine(pessoa1.Cargo);
    }
}