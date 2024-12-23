using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.Models
{
    public class User: BaseEntity
    {
        public string UserName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";

       // Foreign Key 
       public int TeamId { get; set; }
       public  Team? Team { get; set; }
    }
}
