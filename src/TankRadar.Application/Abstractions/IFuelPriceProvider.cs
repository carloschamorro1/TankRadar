using TankRadar.Application.Stations;

namespace TankRadar.Application.Abstractions;

public interface IFuelPriceProvider
{
    Task<IReadOnlyList<StationReading>> SearchByRadiusAsync(
        double latitude,
        double longitude,
        double radiusKm,
        CancellationToken cancellationToken);

    Task<IReadOnlyList<StationReading>> GetByIdsAsync(
        IReadOnlyCollection<string> externalIds,
        CancellationToken cancellationToken);

    Task<IReadOnlyList<StationReading>> SearchByPostalCodeAsync(
        string postalCode,
        CancellationToken cancellationToken);
}
