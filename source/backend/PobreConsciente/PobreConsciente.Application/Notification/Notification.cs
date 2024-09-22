namespace PobreConsciente.Application.Notification;

public enum NotificationKind
{
    NotFound,
    ValidationFailure,
}

public record Notification(NotificationKind Kind, string Message);