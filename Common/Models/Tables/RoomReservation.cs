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
        [NotMapped]
        public ObjectState State { get; set; }
        
        
        [Key]
        public long ReservationId { get; set; }
        public long RoomNumber { get; set; }             // Foreign Key to the HotelRoom Table.
        public long HotelId { get; set; }                // Foreign Key to the Hotel Table.
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // NAVIGATION PROPERTIES
        // For the same reason as Hotel and RoomReservations in the HotelRoom class, this class
        // has an HotelRoom property to track associated hotelrooms without querying the database.
        public virtual HotelRoom HotelRoom { get; set; }
    }
}
