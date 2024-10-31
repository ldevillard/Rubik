using System.Text.Json.Serialization;

namespace Rubik.Components.Data
{
	public class Person
	{
        [JsonPropertyName("id")]
        public string PersonId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("numberOfCompetitions")]
        public int CompetitionsCount { get; set; }
    }
}
