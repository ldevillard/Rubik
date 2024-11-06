using System.Text.Json.Serialization;

namespace Rubik.Components.Data
{
    public class CountryData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("iso2")]
        public string Iso2 { get; set; }
    }
}
