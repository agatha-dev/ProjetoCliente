using Microsoft.SqlServer.Server;
using Projeto01.Infra.Data.SqlServer.Repositories;
using ProjetoCliente.Domain.Contracts.Repositories;
using ProjetoCliente.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Infra.Repositories
{
     public  class ClienteRepository : BaseRepository<ClienteEntity>, IClienteRepository
    {
        private readonly SqlContext sqlContext;

        public ClienteRepository(SqlContext sqlcontext)
            : base(sqlcontext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
