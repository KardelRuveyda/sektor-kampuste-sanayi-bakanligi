using DotnetWorkshop.Core.Models;
using DotnetWorkshop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetWorkshop.Repository.Repositories
{
    public class TeamRepository:GenericRepository<Team>,ITeamRepository
    {
        public TeamRepository(AppDbContext context) : base(context)
        {

        }
    }
}
