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
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("Medico");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(80)
                .HasColumnType("varchar(80)")
                .IsRequired();

            builder.Property(x => x.CRM)
                .HasMaxLength(6)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Especialidade)
                .HasMaxLength(30)
                .HasColumnType("varchar(20)")
                .IsRequired();
            
        }
    }
}
