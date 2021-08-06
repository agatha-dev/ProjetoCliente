using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoCliente.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Infra.Mappins
{
    public class ClienteMap : IEntityTypeConfiguration<ClienteEntity>
    {
        public void Configure(EntityTypeBuilder<ClienteEntity> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(f => f.IdCliente);

            builder.Property(f => f.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(f => f.DataNascimento)
               .HasColumnName("DataNascimento")
               .HasColumnType("date")
               .IsRequired();

            builder.Property(f => f.Cpf)
                .HasColumnName("Cpf")
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(f => f.Email)
               .HasColumnName("Email")
               .HasMaxLength(150)
               .IsRequired();

            builder.Property(f => f.Endereco)
               .HasColumnName("Endereço")
               .HasMaxLength(150)
               .IsRequired();

            #region Relacionamentos

            builder.HasOne(f => f.Endereco); //Cliente tem 1 Endereço

            #endregion

        }

    }

}