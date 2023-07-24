using Clinica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infra.Data.EntityConfigurations
{
    public class PacienteConfiguration : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {

            builder.ToTable("Paciente");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(80)
                .HasColumnType("varchar(80)")
                .IsRequired();

            builder.Property(x => x.DataNascimento)
                .HasColumnType("datetime2")
                .IsRequired();

            builder.Property(x => x.Telefone)
                .HasMaxLength(12)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasMaxLength(80)
                .HasColumnType("varchar(80)")
                .IsRequired();
        }
    }
}
