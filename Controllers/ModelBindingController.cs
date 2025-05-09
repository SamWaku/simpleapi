using Microsoft.AspNetCore.Mvc;

namespace Controllers;

public class ModelBindingController : Controller
{
    //form data

    //Route data
    [HttpGet("/api/route-data/{id}/{name}")]
    public IActionResult RouteData(int? id, string? name) 
    {
        return Content($"Your id is {id} and name is {name}");
    }

    //Query string
}