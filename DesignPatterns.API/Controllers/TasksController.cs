using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.API;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    [HttpGet()]
    public IActionResult Get()
    {
        throw new NotImplementedException();
    }
}