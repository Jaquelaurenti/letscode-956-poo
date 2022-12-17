// o Construtor terá apenas uma instrução
public class ConstrutoresDeUmaInstrucao
{
    private string NomeInstrucao; // servindo como um apoio para o parametro que vem do construtor

    // o Construtor vai receber apenas o NOME e irá atribuir para a propriedade publica da classe
    public ConstrutoresDeUmaInstrucao(string parametroConstrutor)
    {
        // Neste exemplo a propriedade privada, recebe o valor que vem do parâmetro do construtor

       Console.WriteLine("Executou o Construtor");
        Console.WriteLine("Verificando o valor do NomePublico: " + NomePublico);
        Console.WriteLine("Verificando o valor do NomeInstrucao antes: " + NomeInstrucao);
        NomeInstrucao = parametroConstrutor;
        Console.WriteLine("Verificando o valor do NomeInstrucao após: " + NomeInstrucao);



        /*Console.WriteLine("Executou o Construtor");
        Console.WriteLine("Verificando o valor do NomePublico: " + NomePublico);
        Console.WriteLine("Verificando o valor do NomeInstrucao antes: " + NomeInstrucao);
        NomePublico = parametroConstrutor;
        Console.WriteLine("Verificando o valor do NomePublico após: " + NomePublico);*/

        // Se mudarmos para o "NomePulico" a propriedade funcionará de acordo com o que vier no construtor da classe.
        // ou seja, é como se tivessemos atribuindo um valor default e deixando ele disponível na propriedade publica para uso;,
        // a diferença é que ao atribuirmos ao NomePublico executaremos o SET da propriedade privada, atribuindo a propriedade privada o SET não é executado
        // ou seja o nomePublico quando apresentado no main, só é mostrado devido ao GET que está setando a propriedade Privada.
    }


    public string NomePublico
    {
        get => NomeInstrucao;
        set
        {
            Console.WriteLine("Executou o set da propriedade nomepublico");
            Console.WriteLine("Valor do NomeInstrucao antes:" + NomeInstrucao); // o que veio do construtor
            Console.WriteLine("Valor do nomePublico antes de executar o set:" + NomePublico); // o que veio do construtor pq o get dele é o nomeInstrucao
            NomeInstrucao = value;
            Console.WriteLine("Valor do nomePublico depois:" + NomePublico); // o que foi modificado no main
            Console.WriteLine("Valor do NomeInstrucao depois:" + NomeInstrucao); // o que foi modificado no main

        }
    }
}