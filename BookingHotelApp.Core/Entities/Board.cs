using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelApp.Core.Entities
{
    public class Board : AuditableEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Hotel Hotel { get; set; }
        public int HotelId { get; set; }
        public List<Order> Orders { get; set; }
    }
}
