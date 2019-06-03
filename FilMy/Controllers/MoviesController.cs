using FilMy.Models;
using FilMy.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilMy.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            var customers = new List<Customer> {
            new Customer { Name = "customer1"},
            new Customer { Name = "customer2"} };

            var viewmodel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewmodel);
        }
       
    }
}