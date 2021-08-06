using ProjetoCliente.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Domain.Contracts.Repositories
{
     public interface IClienteRepository : IBaseRepository<ClienteEntity>
    {
    }
}
