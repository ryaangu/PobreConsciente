using FluentValidation.Results;

namespace PobreConsciente.Application.Notification;

public sealed class NotificationManager : INotificationManager
{
    private readonly List<Notification> _notifications = new();

    public bool HasNotification => _notifications.Any();

    public List<Notification> GetNotifications() => _notifications;

    public List<string> GetNotificationMessages()
    {
        return _notifications
            .Select(notification => notification.Message)
            .ToList();
    }

    public void Handle(string message)
    {
        _notifications.Add(new Notification(NotificationKind.NotFound, message));
    }

    public void Handle(List<ValidationFailure> failures)
    {
        failures.ForEach(failure => 
            _notifications.Add(new Notification(NotificationKind.ValidationFailure, failure.ErrorMessage)));
    }
}