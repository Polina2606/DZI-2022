using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Miraj1.Data
{
    
   public class User:IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public  RoleType Role { get; set; }
    
    public virtual ICollection<Reservation> Reservation { get; set; }

}
}
