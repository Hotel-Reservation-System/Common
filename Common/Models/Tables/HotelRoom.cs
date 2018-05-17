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
        // Note that a composite key is a primary key on two or more columns. It enforces 
        // uniqueness on several columns.
        [Key]
        public long RoomNumber { get; set; } // This + HotelId = Composite Key
        [Key]
        public long HotelId { get; set; }               // Foreign Key to the Hotel Table.

        public int NumberOfBeds { get; set; }
        [Key]
        public int BedTypeId { get; set; }              // Foreign Key to the BedType Table.

        [Key]
        public int RoomTypeId { get; set; }             // Foreign Key to the RoomType Table.
        public decimal NightlyRate { get; set; }

        // Note: If you use the term 'virtual' for a property in a Model class, it tells EF Core 
        // that this property is a Navigation property. A Navigation property is a pointer 
        // that leads from one entity to another. You can use dot-notation from the
        // navigation property of one entity to peek at other entities.
        public virtual RoomType RoomType { get; set; }
        public virtual BedType BedType { get; set; }

        // Every HotelRoom has a Hotel property that lists information about the the Hotel that
        // owns this hotelroom. Why does this property exist when a query to the database can 
        // return the owner of a given hotelroom? Precisely to skip a queries to the database, 
        // which can become expensive if done for many HotelRoom objects.
        public virtual Hotel Hotel { get; set; }

        // For the same reason as the Hotel property, HotelRoom has a RoomReservations property
        // that lists all the reservations for this room.
        public virtual IEnumerable<RoomReservation> RoomReservations { get; set; }


        [NotMapped]
        public ObjectState State { get; set; }
    }
}
