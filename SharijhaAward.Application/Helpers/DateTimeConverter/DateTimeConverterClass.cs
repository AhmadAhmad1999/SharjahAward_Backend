using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SharijhaAward.Application.Helpers.DateTimeConverter
{
    public class DateTimeConverterClass : JsonConverter<DateTime>
    {
        private const string Format = "yyyy-MM-dd h:mm tt";

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.Parse(reader.GetString(), CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(Format));
        }
    }
}
