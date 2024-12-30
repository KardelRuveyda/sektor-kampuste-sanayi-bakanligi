using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetWorkshop.Core.Models
{
    public class User:BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //İlişkilendirme
        //Foreign Key
        public int TeamId { get; set; }
        public Team Team { get; set; } //Bire çok ilişkiyi temsil etmek için navigasyon özelliği eklendi.
    }
}
