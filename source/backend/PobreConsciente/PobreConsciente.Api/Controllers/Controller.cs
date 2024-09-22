using Microsoft.AspNetCore.Mvc;

namespace PobreConsciente.Api.Controllers;

[ApiController]
public abstract class Controller : ControllerBase
{
    protected IActionResult RespondWith(object? result = null)
    {
        return Ok(result);
    }
}