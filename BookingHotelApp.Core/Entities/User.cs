using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelApp.Core.Entities
{
    public class User : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HashPassword { get; set; }
        public string EmailAdress { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public List<Order> Orders { get; set; }
    }
}
