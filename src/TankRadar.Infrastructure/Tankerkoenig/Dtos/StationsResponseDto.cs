namespace TankRadar.Infrastructure.Tankerkoenig.Dtos;

public class StationsResponseDto
{
    public required List<StationDto> Stations { get; init; }
    public CoordsDto? SearchCenter { get; init; }
    public string? ApiVersion { get; init; }
    public DateTimeOffset? Timestamp { get; init; }
    public string? License { get; init; }
}
