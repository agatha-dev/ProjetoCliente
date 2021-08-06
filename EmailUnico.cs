using System;


namespace ProjetoCliente.Domain.Exceptions
{


	public class EmailUnico : Exception
	{
		private readonly string email;

		public EmailUnico(string email)

		{
			this.email = email;
		}

		public override string Message => $"O Email informado '{email}' Já se encontra-se cadastrado. Tente outro."

	}
}


