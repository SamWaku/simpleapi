using Microsoft.AspNetCore.Mvc;

namespace Controllers;

public class AdditionRequest
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class SumController : Controller
{
    [HttpPost("api/sum")]
    public IActionResult Sum(AdditionRequest additionRequest)
    {
        return Content($"value 1 is : {additionRequest.X}, value 2 is {additionRequest.Y}");
    }


}