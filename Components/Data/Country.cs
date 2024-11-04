using System.Text.Json.Serialization;

namespace Rubik.Components.Data
{
    public class Country
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("iso2")]
        public string Iso2 { get; set; }
    }
}
