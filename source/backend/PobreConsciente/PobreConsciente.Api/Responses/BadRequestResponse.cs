using System.Net;

namespace PobreConsciente.Api.Responses;

public sealed class BadRequestResponse : Response
{
    public List<string>? Errors { get; private init; }

    public BadRequestResponse()
    {
        Title = "Bad Request";
        Status = (int)HttpStatusCode.BadRequest;
    }

    public BadRequestResponse(List<string> errors) : this()
    {
        Errors = errors ?? new List<string>();
    }
}