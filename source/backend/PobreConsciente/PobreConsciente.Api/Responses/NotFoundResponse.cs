using System.Net;
using System.Text.Json.Serialization;

namespace PobreConsciente.Api.Responses;

public sealed class NotFoundResponse : Response
{
    
    [JsonPropertyOrder(order: 2)]
    public string Message { get; init; } = null!;

    public NotFoundResponse(string message)
    {
        Title = "Not Found";
        Status = (int)HttpStatusCode.NotFound;
        Message = message;
    }
}