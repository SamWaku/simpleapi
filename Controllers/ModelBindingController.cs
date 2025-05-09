using Microsoft.AspNetCore.Mvc;

namespace Controllers;

public class ModelBindingController : Controller
{
    //form data

    //Route data
    //not required
    [HttpGet("/api/route-data/{id}/{name}")]
    public IActionResult RouteData(int? id, string? name) 
    {
        return Content($"Your id is {id} and name is {name}");
    }

    //Required id
    [HttpGet("/api/route-data/{id}/{name}")]
    public IActionResult RouteDataRequired() 
    {
        int id = Convert.ToInt32(Request.QueryString[])
        return Content($"Your id is {id}");
    }

    //Query string
}