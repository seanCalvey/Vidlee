using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidlee.Models
{
    public class Rental
    {
        [Key]
        public int RentalKey { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
        [Required]
        public Customer Customer { get; set; }
      
        [Required]
        public Movie Movie { get; set; }
 
    }
}