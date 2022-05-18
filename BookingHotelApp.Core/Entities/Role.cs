using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelApp.Core.Entities
{
    public class Role : AuditableEntity
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
