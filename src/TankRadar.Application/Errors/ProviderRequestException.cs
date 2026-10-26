namespace TankRadar.Application.Errors;

public class ProviderRequestException : Exception
{
    public ProviderRequestException(string message) : base(message) { }

    public ProviderRequestException(string message, Exception innerException)
        : base(message, innerException) { }
}
