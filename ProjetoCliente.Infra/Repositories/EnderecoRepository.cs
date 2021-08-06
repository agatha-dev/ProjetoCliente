using Microsoft.SqlServer.Server;
using Projeto01.Infra.Data.SqlServer.Repositories;
using ProjetoCliente.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Infra.Repositories
{
     public class EnderecoRepository
        : BaseRepository<EnderecoEntity>, IEnderecoRepository
    {
        //Atributo
        private readonly SqlContext sqlcontext;

        //Contrutor para inicialização do atributo (injeção de dependência)
        public ClienteRepository(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext
        }

    }
}
