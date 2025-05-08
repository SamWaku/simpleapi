using Microsoft.AspNetCore.Mvc;

namespace Controllers;

public class ModelBindingController : Controller
{
    //form data

    //Route data
    [HttpGet("/api/route-data")]
    public IActionResult RouteData() 
    {
        return Json(new {"message":"hello how are youu?"});
    }

    //Query string
}