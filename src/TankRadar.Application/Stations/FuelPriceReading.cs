using TankRadar.Domain.Stations;

namespace TankRadar.Application.Stations;

public abstract class FuelPriceReading
{
    public FuelType Fuel { get; set; }
    public decimal Price { get; set; }
    public DateTimeOffset? ChangedAt { get; set; }
}
