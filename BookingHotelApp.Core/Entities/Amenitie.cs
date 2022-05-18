using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelApp.Core.Entities
{
    public class Amenitie : AuditableEntity
    {
        public string Name { get; set; }
        public List<Hotel> Hotels { get; set; }
    }
}
