using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Models
{
    /// <summary>
    /// This table is intended to be used for reporting. Bed Type Names correspond to ID Numbers.
    /// </summary>
    public class RoomType
    {
        // Incremental IDs for Room Types.
        [Key]
        public int Id { get; set; }

        // Names for each Room Type. (E.g. Value Suite (Single/Double), Dexluxe Suite (Single/Double), 
        // Honeymoon Suite, Presidential Suite etc.)
        [Key]
        public string Name { get; set; }
    }
}
