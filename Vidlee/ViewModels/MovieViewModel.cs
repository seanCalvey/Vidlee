using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidlee.Models;

namespace Vidlee.ViewModels
{
    public class MovieViewModel
    {
        public IEnumerable<Genre> Genre { get; set; }

        public Movie Movie { get; set; }

        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit Movie";

                return "New Movie";


            }
        }
    }
}