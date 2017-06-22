using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_API.Repositories;
using Web_API.Entities;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        private MoviesRepository repository;

        public MovieController(MoviesRepository moviesRepository)
        {
            repository = moviesRepository;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            try
            {
                List<Movie> movies = repository.MovieList().ToList();
                return Ok(movies);
            }
            catch (Exception e)
            {
                return BadRequest($"Something ({e.Message})went wrong!");
            }
        }
    }
}
