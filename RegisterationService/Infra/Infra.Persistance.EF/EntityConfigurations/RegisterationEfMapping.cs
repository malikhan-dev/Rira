using Domain.Model.Registerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistance.EF.EntityConfigurations
{
    internal class RegisterationEfMapping : IEntityTypeConfiguration<Registeration>
    {
        public void Configure(EntityTypeBuilder<Registeration> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NationalCode).HasMaxLength(32);
            builder.HasIndex(x => x.NationalCode).IsUnique();
            builder.Property(x => x.FirstName).HasMaxLength(64);
            builder.Property(x => x.LastName).HasMaxLength(64);
            builder.Property(x => x.DateOfBirth).HasMaxLength(32);
        }
    }
}
