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

        // Names for each Bed Size. Examples:
        // 
        // SINGLE BEDS:
        // 1) Small Beds: Small Single, Small Single Long.
        // 2) Standard Beds: Standard Single, Standard Single Long.
        // 3) Premium Beds: Full Size. 
        //
        // DOUBLE BEDS:
        // 1) Small beds: Small Double.
        // 2) Standard Beds: Standard Double, 
        // 3) Premium Beds: Queen, King, Emperor 
        [Key]
        public string Name { get; set; }
    }
}
