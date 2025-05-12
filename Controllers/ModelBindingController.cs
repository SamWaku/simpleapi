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
    public IActionResult RouteDataFromQuery([FromQuery] int page)
    {
        return Content($"The page number returned is {page}");
    }


    //FromRoute
    [HttpGet("api/route-data-from-route/{page}")] //from route requires you to pass the variable as a parameter
    public IActionResult RouteDataFromRoute([FromRoute] int page)
    {
        return Content($"Value from route is: {page}");
    }

    //Both from Route and Query
    [HttpGet("api/route-data-from-query-route/{id?}")]
    public IActionResult RouteDataFromRouteAndQuery([FromRoute] int id, [FromQuery] string name) //For the Query, I can have it in the URL path or just in the method contructor
    {
        if (id == null)
        {
            return NotFound("User Id not provided");
        }

        return Content($"User Id is {id} and Name is {name}");
    }

    //Query string
    [HttpGet("api/route-data-from-query/id")]
    public IActionResult RouteDataFromQuery([FromQuery] int? id)
    {
        return Content($"The id is {id}");
    }


    public class User
    {
        public ind? id {get; set;}
        public string? name {get; set;}
    }
    //With model class
    [HttpGet("api/route-data-from-class-model")]
    public IActionResult RouteDataFromRequestClass([FromQuery] User user)
    {
        return Content($"The id is {user.id} and name is {user.name}")
    }
}