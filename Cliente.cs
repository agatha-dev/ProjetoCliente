using System;

namespace ProjetoCliente.Domain.Entites
{
	public class Cliente()
	{
        [Key]
        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public SexoEnum Sexo { get; set; }
     }
}
