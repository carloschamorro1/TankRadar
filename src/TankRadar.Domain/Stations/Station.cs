namespace TankRadar.Domain.Stations;

public class Station
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public required string ExternalId { get; set; }
    public required string Name { get; set; }
    public string? Brand { get; set; }
    public string? Street { get; set; }
    public required string PostalCode { get; set; }
    public string? City { get; set; }
    public required string Country { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
