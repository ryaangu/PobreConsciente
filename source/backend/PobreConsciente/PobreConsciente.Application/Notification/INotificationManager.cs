using FluentValidation.Results;

namespace PobreConsciente.Application.Notification;

public interface INotificationManager 
{
    void Handle(string message);
    void Handle(List<ValidationFailure> failures);
    List<Notification> GetNotifications();
    List<string> GetNotificationMessages();
    bool HasNotification { get; }
}