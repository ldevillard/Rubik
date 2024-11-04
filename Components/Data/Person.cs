using System.Text.Json.Serialization;

namespace Rubik.Components.Data
{
    public class PersonResponse
    {
        [JsonPropertyName("person")]
        public Person Person { get; set; }

        [JsonPropertyName("competition_count")]
        public int CompetitionCount { get; set; }

        [JsonPropertyName("personal_records")]
        public Records PersonalRecords { get; set; }
    }

    public class Person
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("wca_id")]
        public string PersonId { get; set; }

        [JsonPropertyName("country_iso2")]
        public string CountryIso2 { get; set; }

        [JsonPropertyName("country")]
        public Country CountryInfo { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("avatar")]
        public Avatar AvatarInfo { get; set; }
    }

    public class Avatar
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
