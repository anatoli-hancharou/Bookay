using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookay.Models
{
    public class Reservation
    {
        public long Id { get; set; }

        [Required]
        public User Guest { get; set; }

        [Required]
        public Hotel Hotel { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int NumberOfRooms { get; set; }
    }
}
