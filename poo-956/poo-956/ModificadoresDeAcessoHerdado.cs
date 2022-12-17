using System.Runtime.Intrinsics.X86;

public class ModificadoresDeAcessoHerdado : ModificadoresDeAcesso
{
    public void ExecutaMetodo()
    {
        ApresentaPropriedadesProtected();
    }

    //
    public void ApresentaPropriedadesProtected()
    {
        Console.WriteLine("APresenntando as propriedades" +
            "protegidas da classe pai: " + this.Nome + this.Salario.ToString()); 
    }

}
