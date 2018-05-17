using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Models
{
    /// <summary>
    /// This class tracks Reservations of Rooms.
    /// </summary>
    public class RoomReservation : IObjectWithState
    {
        [Key]
        public long ReservationId { get; set; }
        public long RoomNumber { get; set; } // Foreign Key to the HotelRoom Table.
        public long HotelId { get; set; } // Foreign Key to the Hotel Table.
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Note: If you use the term 'virtual' for a property in a Model class, it tells EF Core 
        // that this property is a Navigation property. A Navigation property is a pointer 
        // that leads from one entity to another. You can use dot-notation from the
        // navigation property of one entity to peek at other entities.
        //
        // For the same reason as Hotel and RoomReservations in the HotelRoom class, this class
        // has an HotelRoom property to track associated hotelrooms without querying the database.
        public virtual HotelRoom HotelRoom { get; set; }

        [NotMapped]
        public ObjectState State { get; set; }
    }
}
