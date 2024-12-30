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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            //Fluent Api Ayarlamaları

            //Primary Key Tanımlası
            builder.HasKey(x => x.Id);

            //Primary Key otomatik olarak 1er 1er artsın.
            builder.Property(x => x.Id)
                .UseIdentityColumn();

            //userName alanının max uzunluğu 50
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(250);

            //tablonun isim değişikliği
            //builder.ToTable("UserrrProfilee");
        }
    }
}
