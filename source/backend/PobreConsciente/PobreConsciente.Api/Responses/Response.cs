using System.Text.Json.Serialization;

namespace PobreConsciente.Api.Responses;

public abstract class Response
{
    [JsonPropertyOrder(order: 0)]
    public int Status { get; init; }

    [JsonPropertyOrder(order: 1)]
    public string Title { get; init; } = null!;
}