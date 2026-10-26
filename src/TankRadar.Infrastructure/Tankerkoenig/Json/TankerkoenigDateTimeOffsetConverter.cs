using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TankRadar.Infrastructure.Tankerkoenig.Json;

/// <summary>
/// Tankerkönig sends offsets as "+01", "+0100" or "+01:00" depending on the endpoint.
/// </summary>
public class TankerkoenigDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
{
    public override DateTimeOffset Read(
        ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var text = reader.GetString();

        if (text is not null && TryParse(text, out var value))
        {
            return value;
        }

        throw new JsonException($"Invalid date value: '{text}'.");
    }

    public override void Write(
        Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        => writer.WriteStringValue(value);

    private static bool TryParse(string text, out DateTimeOffset value)
    {
        var timeIndex = text.IndexOf('T');
        var signIndex = text.LastIndexOfAny(['+', '-']);

        // No numeric offset (for example "Z"): parse as is.
        if (timeIndex < 0 || signIndex <= timeIndex)
        {
            return DateTimeOffset.TryParse(
                text, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out value);
        }

        var offset = text[(signIndex + 1)..];
        var normalized = offset.Length switch
        {
            2 => $"{text[..(signIndex + 1)]}{offset}:00",
            4 => $"{text[..(signIndex + 1)]}{offset[..2]}:{offset[2..]}",
            _ => text
        };

        return DateTimeOffset.TryParse(
            normalized, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out value);
    }
}
