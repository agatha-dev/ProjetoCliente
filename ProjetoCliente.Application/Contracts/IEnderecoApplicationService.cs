using ProjetoCliente.Application.DTOs;
using ProjetoCliente.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Application.Contracts
{
     public interface IEnderecoApplicationService : IDisposable
    {
        EnderecoDTO Create(EnderecoCadastroModel model);
        EnderecoDTO Update(EnderecoEdicaoModel model);
        EnderecoDTO Delete(Guid id);

        List<EnderecoDTO> GetAll();
        EnderecoDTO GetById(Guid id);
    }
}
