using System;
namespace faceDev
{
	public class Publicacao
	{
		public int ContadorDeLike { get; set; }
		public int ContadorDeCompartilhamento { get; set; }
		public int ContadorDeComentario { get; set; }
		public bool SinalizaAjuda { get; set; }
		public string TextoPublicacao { get; set; }
		public Usuario Autor { get; set; }
		public DateTime DataPublicacao { get; set; }
		public bool comentarioDestacado {get;set;}

		public List<Comentario> Comentarios { get; set; }

		public Publicacao(Usuario autor, string textoPublicacao)
		{
			this.Autor = autor;
			this.TextoPublicacao = textoPublicacao;
			this.DataPublicacao = DateTime.Now;
		}

		// método para sinalizar que a publicação precisa de ajuda
		public void SetSinalizaAjuda(bool validador)
		{
			this.SinalizaAjuda = validador;
		}

		// método que atualiza os contadores
		public void atualizaContadores(string tipoContador)
		{
			if (tipoContador.Equals("Like"))
			{
				this.ContadorDeLike++;
			}
            if (tipoContador.Equals("Comentario"))
            {
                this.ContadorDeComentario++;
            }
            if (tipoContador.Equals("Compartilhamento"))
            {
                this.ContadorDeCompartilhamento++;
            }
        }

		public void AtribuiComentarioDestaque(Comentario comentario)
		{
			// SE O MÉTODO NUNCA FOI INVOCADO
			if(!comentarioDestacado)
			{
                // garantindo que a publicação que foi resolvida nao fique mais marcada como uma publicação de ajuda
                SetSinalizaAjuda(false);

                // preciso sinalizar que o comentario teve destaque
                comentario.DestacaComentario(true);

                comentarioDestacado = true;
            }
        }

        public void TiraComentarioDestaque(Comentario comentarioRemoveDestaque, Comentario comentario)
        {
            // SE O MÉTODO JÁ FOI INVOCADO
            if (comentarioDestacado)
            {
                // preciso remover o comentario em destaque
                comentarioRemoveDestaque.DestacaComentario(false);

				// preciso promover o novo comentario para o destaque
				comentario.DestacaComentario(true);

            }
        }

    }
}

