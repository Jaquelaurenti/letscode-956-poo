using System;

public class Construtores
{
    // Sempre que criamos uma classe o seu construtor é criado automaticamente
    // podemos trabalhar com valores default
    // executar determinados métodos assim que a classe é instanciada

    public string PrimeiroNome;
    public string SegundoNome;
    public Construtores(string primeirNomeParametroConstrutor, string segundoNomeParametroConstrutor)
    {
        Console.WriteLine("Executou o método construtor");
        //Console.WriteLine(ExecutaMetodoDentroDoConstrutor());
        PrimeiroNome = primeirNomeParametroConstrutor;
        SegundoNome = segundoNomeParametroConstrutor;
        Console.WriteLine(PrimeiroNome + SegundoNome);
    }

   public string executaMetodoFora ()
    {
        return "Executou";
    }

   public string ExecutaMetodoDentroDoConstrutor()
    {
        return "Executou Método";
    }


}