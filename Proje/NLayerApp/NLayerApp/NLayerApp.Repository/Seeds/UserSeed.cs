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
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
               new User { Id = 1, Email = "yusufislamsahin@gmail.com", UserName = "yusufislamsahin", Password = "1234", TeamId = 1, CreatedAt = DateTime.Now },
               new User { Id = 2, Email = "kardelruveyda@gmail.com", UserName = "kardelruveyda", Password = "kardel123", TeamId = 2, CreatedAt = DateTime.Now },
               new User { Id = 3, Email = "kaanozsavran@gmail.com", UserName = "kaanozsavran", Password = "kaan123", TeamId = 1, CreatedAt = DateTime.Now },
               new User { Id = 4, Email = "serkanozyaman@gmail.com", UserName = "serkanozyaman", Password = "serkan123", TeamId = 1, CreatedAt = DateTime.Now }
                );
        }
    }
}
