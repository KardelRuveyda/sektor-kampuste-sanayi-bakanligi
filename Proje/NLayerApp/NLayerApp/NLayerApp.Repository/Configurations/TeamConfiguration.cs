using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Repository.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            //Primary Key Ayarlaması
            builder.HasKey(x => x.Id);

            //Primary Key Otomatik olarak 1'er 1'er artsın.
            builder.Property(t => t.Id)
                .UseIdentityColumn();

            // TeamName alanı için maksimum uzunluğu belirleme.
            builder.Property(t => t.TeamName)
                .HasMaxLength(50)
                .IsRequired();

            //Tablo ismini tanımlama
            builder.ToTable("Teams");
        }
    }
}
