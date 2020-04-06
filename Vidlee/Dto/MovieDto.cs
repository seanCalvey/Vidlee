using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidlee.Models;

namespace Vidlee.Dto
{
    public class MovieDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Genre Genre { get; set; }

        public int GenreId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

      //  [Range(1, 20)]
        public int Stock { get; set; }
    }
}