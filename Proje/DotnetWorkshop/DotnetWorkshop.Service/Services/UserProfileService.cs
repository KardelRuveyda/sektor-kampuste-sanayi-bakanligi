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
    public class UserProfileService : Service<UserProfile>,IUserProfileService
    {
        public UserProfileService(IGenericRepository<UserProfile> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
