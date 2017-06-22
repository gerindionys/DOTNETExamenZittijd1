using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Client.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Description { get; set; }

        public virtual List<Movie> Movie { get; set; }
    }
}
