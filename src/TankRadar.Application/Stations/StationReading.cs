namespace TankRadar.Application.Stations;

public abstract class StationReading
{
    public required string ExternalId { get; set; }
    public required string Name { get; set; }
    public string? Brand { get; set; }
    public string? Street { get; set; }
    public required string PostalCode { get; set; }
    public string? City { get; set; }
    public required string Country { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double? DistanceKm { get; set; }
    public bool? IsOpen { get; set; }
    public List<FuelPriceReading> Prices { get; set; } = [];
}
