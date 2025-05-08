using Microsoft.AspNetCore.Mvc;

namespace Controllers;

public class ModelBindingController : Controller
{
    //form data

    //Route data
    [HttpGet("/api/route-data")]
    public IActionResult RouteData()
    {
        return Content("Hello");
    }

    //Query string
}