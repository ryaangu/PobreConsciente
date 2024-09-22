namespace PobreConsciente.Api.Responses;

public abstract class Response
{
    public string Title { get; init; } = null!;
    public int Status { get; init; }
}