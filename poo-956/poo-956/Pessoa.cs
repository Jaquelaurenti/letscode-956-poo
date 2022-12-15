using System.ComponentModel.DataAnnotations;

public class Pessoa
{
    // para determinar o ACESSO a propriedade: MODIFICADOR DE ACESSO (public, private)
    // para determinar a VISUALIZAÇÃO do valor a propriedade: GET

    // Criar as propriedades que compoem a classe Pessoa
    [Required(ErrorMessage ="campo obrigatório")]
    public string Nome { get; set; }

    [Required]
    public int Idade { get; set; }

    // UTILIZAMOS O GET, para conseguirmos visualizar o estado da prorpiedade da classe
    // utilizamos o set, para conseguir atribuir um valor(estado) a propriedade da classe

    public DateTime DataCriação { get; }
    

    // outras formas de trabalhar com o set
    private string sobrenomePRIVADO; // aqui estamos falando apenas de um campo, não chegar ser porpriedade pois nao conseguimos instanciar
    public string Sobrenome
    {

        get {
            Console.WriteLine("variavel privada" + sobrenomePRIVADO);
            return "O retorno agora é modificado" + 
                sobrenomePRIVADO; }
        set {
            Console.WriteLine("Printando o valor do value: " + value);
            Console.WriteLine("Executando o set antes de " +
            "atribuir o valor a variavel privada:" + sobrenomePRIVADO);

            sobrenomePRIVADO = value;

            Console.WriteLine("depois do set campo privado" + sobrenomePRIVADO);
            Console.WriteLine("depois do set campo public" + sobrenomePRIVADO);

        }
        
    }

    // Declarando um tipo enum para tratar o cargo como propriedade
    public Cargos Cargo { get; set; }
    // Declarando uma propriedade do Tipo Endereço
    public Endereco endereco { get; set; }

}

public class Endereco
{
   public string CEP { get; set; }
}