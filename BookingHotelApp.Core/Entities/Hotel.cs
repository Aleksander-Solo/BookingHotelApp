using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelApp.Core.Entities
{
    public class Hotel : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public List<Board> Boards { get; set; }
        public List<Amenitie> Amenities { get; set; }
        public List<Room> Rooms { get; set; }
        public Adress Adress { get; set; }
        public int AdressId { get; set; }
    }
}
