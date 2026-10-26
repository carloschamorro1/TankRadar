namespace TankRadar.Domain.Stations;

public class PriceSnapshot
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public Guid StationId { get; set; }
    public FuelType Fuel { get; set; }
    public decimal Price { get; set; }
    public DateTimeOffset ChangedAt { get; set; }
    public DateTimeOffset CapturedAt { get; set; }
}
