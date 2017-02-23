using System.Collections.Generic;
using Vidly.Models;


namespace Vidly.ViewModels
{
    public class RandomMovieViewModel // just to get the name of movie and list of cutomers , this RandomMovieViewModel is created
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }  // Customers is variable representing list. 

    }
}