using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using Mvc_Client.Models;
using Newtonsoft.Json;
using Mvc_Client.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Mvc_Client.Controllers
{
    public class MovieController : Controller
    {
        HttpClient client;

        public MovieController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:2018");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        [Route("/")]
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            HttpResponseMessage response = client.GetAsync("/api/movie").Result;
            string stringData = response.Content.ReadAsStringAsync().Result;
            List<Movie> data = JsonConvert.DeserializeObject<List<Movie>>(stringData);

            return View(data.Select(m => new SpecialMovieViewModel()
            {
                Title = m.Title,
                Genre = m.Genre.Description,
                Year = m.Year,
                Director = m.Director.FirstName + " " + m.Director.LastName,
                Rating = m.Stars
            }
            ));
        }
    }
}
