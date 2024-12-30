using DotnetWorkshop.Core.Models;
using DotnetWorkshop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetWorkshop.Repository.Repositories
{
    public class UserProfileRepository : GenericRepository<UserProfile>,IUserProfileRepository
    {
        public UserProfileRepository(AppDbContext context) : base(context)
        {

        }
    }
}
