using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelApp.Core.Entities
{
    public class Order : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public List<Room> Rooms { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Board Board { get; set; }
        public int BoardId { get; set; }
    }
}
