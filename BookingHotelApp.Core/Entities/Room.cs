using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelApp.Core.Entities
{
    public class Room : AuditableEntity
    {
        public string Description { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; }
        public int FreeRooms { get; set; }
        public Hotel Hotel { get; set; }
        public int HotelId { get; set; }
        public List<Order> Orders { get; set; }
    }
}
