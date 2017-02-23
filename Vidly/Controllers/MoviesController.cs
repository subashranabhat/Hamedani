using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

// is necessary when we are using the Models


namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()  // whatever this axn is we create the same named .cshtml file in Views. That .cshtml is placed inside the movie folder coz we want it to go Movies/Random
        {

            var movie = new Movie() { Name = "Shrek!" }; // note this random() method is giving us both name of Movie and customers.
            var customers = new List<Customer>
            {
                new Customer {Name = "Subash"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel() // a instance of this class is selected and the values are passed initially assigned variables in RandomMovieViewModel.cs
            {
                Movie = movie, // this movie is the instance of the Movie within RandomMovieViewModel
                Customers = customers  // this customers is the instance of the Customers within RandomMovieViewModel
            };

            return View(viewModel);



            //  return View(movie);

            //  return Content("hello world");
            // return HttpNotFound();
            // return new EmptyResult();
            // return RedirectToAction("Index", "Home", new { page = 1, sortby = "name" });

        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + 1);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy) // ? added to make int nullable while string is alredy nullable
        {
            //            if (!pageIndex.HasValue)
            //            {
            //                pageIndex = 1;
            //            }
            //
            //            if (sortBy.IsNullOrWhiteSpace())
            //            {
            //                sortBy = "Name";
            //            }
            //            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

            var film = new Movie();
            film.Name = "chakkapanja";


            return View(film);


        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]  // the colons are used to add contraints
        public ActionResult ByReleaseYear(int year, int month)
        {

            return Content(year + "/" + month);
        }

    }
}