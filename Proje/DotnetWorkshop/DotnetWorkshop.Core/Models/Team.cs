using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetWorkshop.Core.Models
{
    public class Team:BaseEntity
    {
        public string TeamName { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
