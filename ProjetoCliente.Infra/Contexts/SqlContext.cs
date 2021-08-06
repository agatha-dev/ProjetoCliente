using Microsoft.EntityFrameworkCore;
using ProjetoCliente.Domain.Entities;
using ProjetoCliente.Infra.Mappins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Infra.Contexts
{
     public class SqlContext : DbContext 
    {

        //REGRA 2: Construir que possa receber parametros 
        //de configuração necessários para ativar o Dbcontext
        public SqlContext(DbContextOptions<SqlContext> Options)
            : base(Options) //construtor da superclasse
        {

        }

        //REGRA 3: Declarar uma propriedade Dbset para cada
        //entidade mapeada neste contexto de banco de dados

        public DbSet<ClienteEntity> Endereco { get; set; }
        public DbSet<EnderecoEntity> Cliente { get; set; }

        //REGRA 4: Sobreescrever o método OnModelCreating e adicionar
        //cada classe do mapeamento criada para o banco de dados

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());

            #region Índices

            modelBuilder.Entity<ClienteEntity>(entity => {
                entity.HasIndex(F => F.Cpf).IsUnique();
            });

            modelBuilder.Entity<EnderecoEntity>(entity =>
            {
                entity.HasIndex(c => c.CEp).IsUnique();
            });

            #endregion
        }

    }
}
