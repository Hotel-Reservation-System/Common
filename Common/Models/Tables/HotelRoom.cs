using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Models
{
    /// <summary>
    /// This class tracks Hotelrooms and their many properties.
    /// </summary>
    public class HotelRoom : IObjectWithState
    {
        [NotMapped]
        public ObjectState State { get; set; }
        
        
        // COMPOSITE KEY
        // 
        // This table uses HotelId + RoomNumber to uniquely identify a room. Therefore, this 
        // table uses a composite key. A composite key is a primary key that is comprised of
        // two or more attributes. It enforces uniqueness through the use of several columns.
        // 
        // As two hotels could have the same hotel room numbers, using both HotelId and
        // RoomNumber attributes should create a unique ID, i.e. a unique way to identify a given
        // room at a hotel from all other hotel rooms in the database. 
        [Key]
        public long RoomNumber { get; set; }            // This + HotelId = Composite Key
        [Key]
        public long HotelId { get; set; }               // Foreign Key to the Hotel Table.

        public int NumberOfBeds { get; set; }
        [Key]
        public int BedTypeId { get; set; }              // Foreign Key to the BedType Table.

        [Key]
        public int RoomTypeId { get; set; }             // Foreign Key to the RoomType Table.
        public decimal NightlyRate { get; set; }

        // NAVIGATION PROPERTIES
        
        // Every HotelRoom has a Hotel property that lists information about the the Hotel that
        // owns this hotelroom. Why does this property exist when a query to the database can 
        // return the owner of a given hotelroom? Precisely to skip a queries to the database, 
        // which can become expensive if done for many HotelRoom objects.
        public virtual Hotel Hotel { get; set; }

        
        // For the same reason as the Hotel property, HotelRoom has a RoomReservations property
        // that lists all the reservations for this room.
        public virtual IEnumerable<RoomReservation> RoomReservations { get; set; }
        
        
        public virtual RoomType RoomType { get; set; }
        public virtual BedType BedType { get; set; }
    }
}
