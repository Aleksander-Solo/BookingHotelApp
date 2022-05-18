using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelApp.Core.Entities
{
    public class Adress : AuditableEntity
    {
        public string City { get; set; }
        public string Street { get; set; }
        public Hotel Hotel { get; set; }
    }
}
