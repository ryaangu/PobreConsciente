using Microsoft.AspNetCore.Mvc;

namespace PobreConsciente.Api.Controllers;

[Route("test")]
public sealed class TestController : Controller
{
    [HttpGet("/hello/{user}")]
    public IActionResult hello(string user)
    {
        return RespondWith($"Hello, {user}!");
    }
}