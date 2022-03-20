using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Miraj1.Data
{
   public class Reservation
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime OrderedOn { get; set; }
        public DateTime OrderedAut { get; set; }
    }
}
