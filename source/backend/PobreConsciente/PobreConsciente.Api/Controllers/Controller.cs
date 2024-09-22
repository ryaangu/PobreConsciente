using Microsoft.AspNetCore.Mvc;
using PobreConsciente.Api.Responses;
using PobreConsciente.Application.Notification;

namespace PobreConsciente.Api.Controllers;

[ApiController]
public abstract class Controller(INotificationManager notificationManager) : ControllerBase
{
    protected IActionResult RespondWith(object? result = null)
    {
        if (!notificationManager.HasNotification)
            return Ok(result);
            

        // Check for 'not found' notification.
        var notifications = notificationManager.GetNotifications();
        var notFoundNotification = notifications.FirstOrDefault(notification => 
            notification.Kind == NotificationKind.NotFound);

        if (notFoundNotification != null)
            return NotFound(new NotFoundResponse(notFoundNotification.Message));

        // We didn't find any 'not found' notification,
        // it's probably validation(s) error(s).
        var response = new BadRequestResponse(notificationManager.GetNotificationMessages());
        return BadRequest(response);
    }
}