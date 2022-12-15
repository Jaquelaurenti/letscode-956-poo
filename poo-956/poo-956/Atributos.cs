public class Atributos : Attribute
{
    string Nome;
    public double Versao;

    // construtor da classe Atributos
    public Atributos(string name)
    {
        this.Nome = name;

        // para o campo versão eu vou setar um valor default
        Versao = 1.0;

    }

    // criando um método que retorna o nome
    public string GetNome()
    {
        return Nome;
    }

    [Atributos("Jaque")]
    public class Classe1
    {
        // 
    }

    [Atributos("Richard")]
    public class Classe2
    {
        // 
    }

    public class  TestarAtributos
    {
        public void ExecutaTeste()
        {
            PrintInformacoesClasse(typeof(Classe1));
            PrintInformacoesClasse(typeof(Classe2));
        }
    }




    private static void PrintInformacoesClasse(Type t)
    {
        // Acessando o atributo da Classe
        Console.WriteLine("O nome do atributo da classe é: {0}", t);

        //atraves do reflection da Classe que foi herdada attributes
        // passando como parâmetro o parametro que vier do método quando ele for invocado
        Attribute[] attributes = Attribute.GetCustomAttributes(t);
        // verificando a instancia
        Console.WriteLine("Verificando a instancia atributes");
        Console.WriteLine(attributes);

        // acessar
        foreach (Attribute at in attributes)
        {
            if (at is Atributos)
            {
                // significa que ele é um atirbuto do tipo atributos que eu acabei de criar, ou seja, personalizado
                Atributos a = (Atributos)at;
                Console.WriteLine("A classe que utilizou o atributo personalizado é: " + a.GetNome() +
                   " e a versao é: " + a.Versao);
            }

        }


    }
    
}