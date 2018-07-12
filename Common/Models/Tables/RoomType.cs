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

        // Names for each Room Type. Examples:
        //
        // 1) REGULAR SUITES: Single Suite, Twin Suite, Triple Suite, Quad Suite for 1, 2, 3
        //    and 4 persons respectively.
        // 2) SPECIAL SUITES: Apartment Suite (for long term guests), Accessibility Suite
        //    (for disabled guests), Smoking Suites.
        // 3) PREMIUM SUITES: Executive Suite, Honeymoon Suite, Cabana Rooms
        //    (Rooms with attached private pool), Presidential Suite etc.)
        [Key]
        public string Name { get; set; }
    }
}
