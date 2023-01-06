using System;
namespace faceDev
{
	// criando o molde de usuario
	// nosso app só irá ter o perfil que herdar desta classe dado que ela nao pode ser instanciada
	public abstract class Usuario
	{
		public string Email { get; set; } // login
		public string Senha { get; set; } // login 
		public string Nome { get; set; } // cadastro

		// construtor
		public Usuario(string nome, string senha, string email)
		{
			// atribuir os parametors do construtor nas propriedades da classse
			this.Nome = nome;
			this.Senha = senha;
			this.Email = email;
		}


	}
}

