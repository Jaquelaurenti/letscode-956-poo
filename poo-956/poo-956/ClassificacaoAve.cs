public class ClassificacaoAve
{
    public int Id { get; set; }
    public string Classificacao { get; set; }

    public ClassificacaoAve(int id, string classificacao)
    {
        this.Id = id;
        this.Classificacao = classificacao;
    }
}