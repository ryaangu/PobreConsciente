using System.Net;

namespace PobreConsciente.Api.Responses;

public sealed class NotFoundResponse : Response
{
    public string Message { get; init; } = null!;

    public NotFoundResponse(string message)
    {
        Title = "Not Found";
        Status = (int)HttpStatusCode.NotFound;
        Message = message;
    }
}