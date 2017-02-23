using System.Collections.Generic;
using Vidly.Models;


namespace Vidly.ViewModels
{
    public class MoviesCustomers // new file created in View Models
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }  // Customers is variable representing list. 

    }
}