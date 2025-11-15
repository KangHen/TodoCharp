using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Todo.App.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(new { test = "ok" });
    }
}
