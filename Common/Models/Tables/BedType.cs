using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Models
{
    /// <summary>
    /// This table is intended to be used for reporting. Bed Size Names correspond to ID Numbers.
    /// </summary>
    public class BedType
    {
        // Incremental IDs for Room Sizes.
        [Key]
        public int Id { get; set; }

        // Names for each Bed Size. (King, CalKing, Queen, Twin Extra Long, Full Extra Long, 
        // Twin Size, Full Size etc.)
        [Key]
        public string Name { get; set; }
    }
}
