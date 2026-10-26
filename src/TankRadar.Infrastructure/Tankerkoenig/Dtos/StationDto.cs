namespace TankRadar.Infrastructure.Tankerkoenig.Dtos;

public abstract class StationDto
{
    public required string Id { get; init; }
    public required string Country { get; init; }
    public required string Name { get; init; }
    public string? Brand { get; init; }
    public string? Street { get; init; }
    public required string PostalCode { get; init; }
    public string? Place { get; init; }
    public required CoordsDto Coords { get; init; }
    public bool? IsOpen { get; init; }
    public double? Dist { get; init; }
    public required List<FuelDto> Fuels { get; init; }
}
