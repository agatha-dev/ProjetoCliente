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
    public class EnderecoMap : IEntityTypeConfiguration<EnderecoEntity>
    {
        public void Configure(EntityTypeBuilder<EnderecoEntity> builder)
        {
            builder.ToTable("Endereço");

            builder.HasKey(f => f.CEp);

            builder.Property(f => f.CEp)
                .HasColumnName("Cep");

            builder.Property(f => f.Estado)
                .HasColumnName("Estadp")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(f => f.Rua)
                .HasColumnName("Rua")
                .IsRequired();

            builder.Property(f => f.Número)
                .HasColumnName("Numero")
                .IsRequired();


           
        }
    }
}
