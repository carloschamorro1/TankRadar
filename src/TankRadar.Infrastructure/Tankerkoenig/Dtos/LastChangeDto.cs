namespace TankRadar.Infrastructure.Tankerkoenig.Dtos;

public abstract class LastChangeDto
{
    public decimal? Amount { get; init; }
    public required DateTimeOffset Timestamp { get; init; }
}
