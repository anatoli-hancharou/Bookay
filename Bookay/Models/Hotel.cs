using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookay.Models
{
    public class Hotel
    {
        public long Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5,
            ErrorMessage = "Hey - you've gotta give a name between 5 and 100 characters long!")]
        public string Name { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 25,
            ErrorMessage = "You've gotta give a short description between 25 and 150 characters long!")]
        public string ShortDescription { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(0, 5)]
        public int NumberOfStars { get; set; }

        [Required]
        [Range(1, 1000)]
        public int NumberOfAvailableRooms { get; set; }

        public List<User> Guests { get; set; } = new List<User>();

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
