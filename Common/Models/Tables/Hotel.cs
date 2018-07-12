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
        // The ObjectState property is not an attribute in a table; it is used to track changes
        // in an entity. This will likely happen in the endpoints of this project.
        [NotMapped]
        public ObjectState State { get; set; }
        
        
        // The primary key of the Hotel table in the Database is the Hotel Id.
        [Key]
        public long Id { get; set; } 
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        // ASSOCIATIONS AND NAVIGATION PROPERTIES
        //
        // An entity in a database can have one-to-one, one-to-many, or many-to-many relationship
        // to other entities in a database. How are these associations delineated in programs?
        // 
        // In a model class, navigation properties represent associations associations between
        // entities. Most properties in a model class map on to attributes in a table. However,
        // if you use the keyword 'virtual' for a property in a Model class, it tells EF Core
        // that this property is a Navigation property. A Navigation property is a program-side
        // representation of entity associations; it is a pointer that links one entity to another.
        // Navigation properties are used to define the nature of association that exists between
        // two entities in a database. You can use dot-notation from the navigation property of
        // one entity to peek at other entities.
        //
        // Hotel objects have a HotelRooms navigation property to track the list of hotel rooms 
        // at a hotel without needing to query the database. Hotels have a one-to-many relationship
        // to hotelrooms. Note that the 'HotelRooms' navigation property is a collection that can
        // hold multiple hotel room objects. If there was a one-to-one relationship between these
        // two entities, this property would a HotelRoom object instead.
        public virtual IEnumerable<HotelRoom> HotelRooms { get; set; }
    }
}
