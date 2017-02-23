using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes(); // this is alternative to what is done below here. and remaining snippets in  Movies ccontroller

            //            routes.MapRoute(
            //                "MoviesByReleaseDate",
            //                "movies/released/{year}/{month}",
            //                new { controller = "Movies", action = "ByReleaseYear" },
            //                new { year = @"\d{4}", month = @"\d{2}" }
            //                );s




            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
