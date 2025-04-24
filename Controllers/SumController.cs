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
    public int Sum(AdditionRequest additionRequest)
    {
        return additionRequest.Y + additionRequest.X;
    }
}