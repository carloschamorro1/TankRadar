namespace TankRadar.Application.Errors;

public class ProviderAccessDeniedException : Exception
{
    public ProviderAccessDeniedException(string message) : base(message) { }

    public ProviderAccessDeniedException(string message, Exception innerException)
        : base(message, innerException) { }
}
