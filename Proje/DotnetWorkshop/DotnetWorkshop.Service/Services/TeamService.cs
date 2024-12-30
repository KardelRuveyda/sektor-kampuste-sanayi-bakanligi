using DotnetWorkshop.Core.Models;
using DotnetWorkshop.Core.Repositories;
using DotnetWorkshop.Core.Services;
using DotnetWorkshop.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetWorkshop.Service.Services
{
    public class TeamService : Service<Team>, ITeamService
    {
        public TeamService(IGenericRepository<Team> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
