using DotnetWorkshop.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetWorkshop.Repository.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            //Fluent Api Ayarlamaları

            //Primary Key Tanımlası
            builder.HasKey(x => x.Id);

            //Primary Key otomatik olarak 1er 1er artsın.
            builder.Property(x => x.Id)
                .UseIdentityColumn();

            //TeamName alanı için maks uzunluk belirleme

            builder.Property(x => x.TeamName)
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
