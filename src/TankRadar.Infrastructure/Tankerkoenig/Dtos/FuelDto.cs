namespace TankRadar.Infrastructure.Tankerkoenig.Dtos;

public abstract class FuelDto
{
    public required string Category { get; init; }
    public required string Name { get; init; }
    public required decimal Price { get; init; }
    public LastChangeDto? LastChange { get; init; }
}
