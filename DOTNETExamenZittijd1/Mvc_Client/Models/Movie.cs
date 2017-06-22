using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Client.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int GenreId { get; set; }
        public int DirectorId { get; set; }
        public byte Stars { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MovieActor> MovieActor { get; set; }
        public virtual Person Director { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
