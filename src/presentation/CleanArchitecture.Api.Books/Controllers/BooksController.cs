using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Books.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
    
        return Ok();
    }
}
