using System.Text.Json;

namespace TankRadar.Infrastructure.Tankerkoenig.Json;

public static class TankerkoenigJson
{
    public static JsonSerializerOptions Options { get; } = Create();

    private static JsonSerializerOptions Create()
    {
        var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
        options.Converters.Add(new TankerkoenigDateTimeOffsetConverter());
        return options;
    }
}
