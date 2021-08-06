using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCliente.Domain.Entities
{
    public class ClienteEntity
	{
        [Key]
        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public object Endereco { get; set; }
    }
}

