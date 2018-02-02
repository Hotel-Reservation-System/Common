using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Models
{
    /// <summary>
    /// This class tracks Hotels.
    /// </summary>
    public class Hotel : IObjectWithState
    {
        // The primary key of the Hotel table in the Database is the Room Number.
        [Key]
        public long Id { get; set; } 
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        // Hotel Objects have a HotelRooms property to track the list of hotelrooms at a hotel
        // without needing to query the database.
        public virtual IEnumerable<HotelRoom> HotelRooms { get; set; }


        // ORMs (Object-Relational Mapper) map properties in an object to a table. The ObjectState
        // property is not a table column; it is used to track changes in an entity. This will 
        // likely happen in the endpoints of this project.
        [NotMapped]
        public ObjectState State { get; set; }
    }
}
