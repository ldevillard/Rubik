using System.Text.Json.Serialization;

namespace Rubik.Components.Data
{
    public class Records
    {
        [JsonPropertyName("222")]
        public Event TwoByTwo { get; set; }

        [JsonPropertyName("333")]
        public Event ThreeByThree { get; set; }

        [JsonPropertyName("444")]
        public Event FourByFour { get; set; }

        [JsonPropertyName("555")]
        public Event FiveByFive { get; set; }

        [JsonPropertyName("666")]
        public Event SixBySix { get; set; }

        [JsonPropertyName("777")]
        public Event SevenBySeven { get; set; }
    }

    public class Event
    {
        [JsonPropertyName("single")]
        public SolveStats Single { get; set; }

        [JsonPropertyName("average")]
        public SolveStats Average { get; set; }
    }

    public class SolveStats
    {
        [JsonPropertyName("best")]
        public int Best { get; set; }

        [JsonPropertyName("world_rank")]
        public int WorldRank { get; set; }

        [JsonPropertyName("continent_rank")]
        public int ContinentRank { get; set; }

        [JsonPropertyName("country_rank")]
        public int CountryRank { get; set; }
    }
}
