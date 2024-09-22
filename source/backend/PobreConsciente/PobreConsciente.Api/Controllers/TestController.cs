using Microsoft.AspNetCore.Mvc;
using PobreConsciente.Application.Notification;

namespace PobreConsciente.Api.Controllers;

[Route("test")]
public sealed class TestController(INotificationManager notificationManager) : Controller(notificationManager)
{
    [HttpGet("/hello/{user}")]
    public IActionResult hello(string user)
    {
        return RespondWith($"Hello, {user}!");
    }
}