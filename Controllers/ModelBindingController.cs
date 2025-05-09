using Microsoft.AspNetCore.Mvc;

namespace Controllers;

public class ModelBindingController : Controller
{
    //form data

    //Route data
    //not required
    [HttpGet("api/route-data/{id}/{name}")]
    public IActionResult RouteData(int? id, string? name) 
    {
        return Content($"Your id is {id} and name is {name}");
    }

    //Required id
    [HttpGet("api/route-data-required/{id}")]
    public IActionResult RouteDataRequired() 
    {
        int id = Convert.ToInt32(Request.RouteValues["id"]);
        return Content($"Your id is {id}");
    }

    //FromQuery
    [HttpGet("api/route-data-from-query")] //when using query no need to pass params in URL
    public IActionResult RoutDataFromQuery([FromQuery] int page)
    {
        return Content($"The page number returned is {page}");
    }


    //FromRoute

    //Query string
}