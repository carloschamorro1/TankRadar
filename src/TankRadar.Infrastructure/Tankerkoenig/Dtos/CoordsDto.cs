namespace TankRadar.Infrastructure.Tankerkoenig.Dtos;

public abstract class CoordsDto
{
    public required double Lat { get; init; }
    public required double Lng { get; init; }
}
