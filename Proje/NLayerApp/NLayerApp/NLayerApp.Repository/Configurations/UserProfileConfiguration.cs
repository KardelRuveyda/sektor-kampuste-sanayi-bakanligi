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
    public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            //Primary Key
            builder.HasKey(x => x.Id);

            //1-1 artması için
            builder.Property(x => x.Id)
                .UseIdentityColumn();

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(250);

            //Tablo ismi 
            builder.ToTable("UserProfiles");
        }
    }
}
