using ProjetoCliente.Application.DTOs;
using ProjetoCliente.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Application.Contracts
{
     public interface IClienteApplicationsService : IDisposable
    {
        ClienteDTO Create(ClienteCadastroModel model);
        ClienteDTO Update(ClienteEdicaoModel model);
        ClienteDTO Delele(Guid id);

        List<ClienteDTO> GetAll();
        ClienteDTO GetById(Guid id);

    }
}
