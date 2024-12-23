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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Primary Key olduğunu belirleyelim.
            builder.HasKey(x => x.Id);

            //1-1 artması için işlem yapalım.
            builder.Property(x => x.Id)
                .UseIdentityColumn();

            builder.Property(x => x.UserName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(250);
            builder.Property(x=> x.Password).IsRequired().HasMaxLength(250);

            //Tablo ismi 
            builder.ToTable("Users");
        }
    }
}
