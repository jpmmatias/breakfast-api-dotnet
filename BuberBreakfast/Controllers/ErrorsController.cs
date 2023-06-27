using Microsoft.AspNetCore.Mvc;

namespace BurberBreakfast.Controllers;

public class ErrorsController : ControllerBase
{
    [HttpGet("/error")]
    public IActionResult Error() => Problem();
}