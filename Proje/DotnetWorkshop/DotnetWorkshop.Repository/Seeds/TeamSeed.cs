using DotnetWorkshop.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetWorkshop.Repository.Seeds
{
    public class TeamSeed : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasData(

                new Team { Id = 1, TeamName = "Takım 1" },
                new Team { Id = 2, TeamName = "Takım 2" },
                new Team { Id = 3, TeamName = "Takım 3" }
                );
        }
    }
}
