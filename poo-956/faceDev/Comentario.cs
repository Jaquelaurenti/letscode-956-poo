using System;
namespace faceDev
{
	public class Comentario
	{
		public string Conteudo { get; set; }
		public Usuario AutorComentario { get; set; }
		public Publicacao Publicacao { get; set; }
		public bool Destaque { get; set; } // se destaque for true (cometnario resolveu a dor da publicacao)

		public Comentario(string conteudo, Usuario autorDoComentario, Publicacao publicacao)
		{
			this.Conteudo = conteudo;
			this.AutorComentario = autorDoComentario;
			this.Publicacao = publicacao;
		}

		public void DestacaComentario(bool validador)
		{
			this.Destaque = validador;
		}

	}
}

