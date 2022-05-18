using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelApp.Core.Entities
{
    public class AuditableEntity
    {
        public int Id { get; set; }
        public DateOnly CreatedDate { get; set; }
    }
}
