using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Miraj1.Data
{
   public class Room
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Photo { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public TypeRoom Type { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
