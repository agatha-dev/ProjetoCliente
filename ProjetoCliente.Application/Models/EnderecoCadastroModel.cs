using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Application.Models
{
     public class EnderecoCadastroModel
     {
        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do Endereco")]
        public string Endereco { get; set; }

        [RegularExpression("^[MF]{1}$", ErrorMessage = "Por favor informe apenas 'F' ou 'M'.")]
        [Required(ErrorMessage = "Por favor, informe o sexo do Aluno.")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome da rua.")]
        public string Rua { get; set; }

        [RegularExpression("^[0-9]{11}$", ErrorMessage = "Por favor informe um CPF válido.")]
        [Required(ErrorMessage = "Por favor, informe o Estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Por favor, informe o id da Turma.")]
     }
}
