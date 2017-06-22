using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Entities;

namespace Web_API.Repositories
{
    public class MoviesRepository
    {
        private MovieContext db;

        public MoviesRepository(MovieContext context)
        {
            db = context;
        }

        public List<Movie> MovieList()
        {
            return db.Movie.Select(m => m).ToList();
        }
    }
}
