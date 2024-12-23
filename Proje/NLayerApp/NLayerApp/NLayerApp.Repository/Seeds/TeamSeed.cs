using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using NLayerApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Repository.Seeds
{
    public class TeamSeed : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasData(
                new Team { Id = 1, TeamName = "Development", CreatedAt = DateTime.Now},
                new Team { Id = 2, TeamName = "Sales", CreatedAt = DateTime.Now },
                new Team { Id = 3, TeamName = "Marketing", CreatedAt = DateTime.Now },
                new Team { Id = 4, TeamName = "HR", CreatedAt = DateTime.Now },
                new Team { Id = 5, TeamName = "Data", CreatedAt = DateTime.Now }
                );
        }
    }
}
