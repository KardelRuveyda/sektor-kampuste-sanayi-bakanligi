using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Repository.Seeds
{
    public class UserProfileSeed : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasData(
                new UserProfile { Id = 1, FirstName = "Yusuf İslam", LastName = "Şahin", UserId = 1 },
                new UserProfile { Id = 2, FirstName = "Kardel Rüveyda", LastName = "Çetin", UserId = 2 },
                new UserProfile { Id = 3, FirstName = "Kaan", LastName = "Özsavran", UserId = 3 },
                new UserProfile { Id = 4, FirstName = "Serkan", LastName = "Özyaman", UserId = 4 }
                );
        }
    }
}
