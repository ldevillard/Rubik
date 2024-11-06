using Rubik.Components.Types;
using System.Text.Json.Serialization;

namespace Rubik.Components.Data
{
    public class RecordsData
    {
        [JsonPropertyName("222")]
        public EventData TwoByTwo { get; set; }

        [JsonPropertyName("333")]
        public EventData ThreeByThree { get; set; }

        [JsonPropertyName("444")]
        public EventData FourByFour { get; set; }

        [JsonPropertyName("555")]
        public EventData FiveByFive { get; set; }

        [JsonPropertyName("666")]
        public EventData SixBySix { get; set; }

        [JsonPropertyName("777")]
        public EventData SevenBySeven { get; set; }

        [JsonPropertyName("333bf")]
        public EventData Blindfolded { get; set; }

        [JsonPropertyName("333mbf")]
        public EventData MultiBlindefolded { get; set; }

        [JsonPropertyName("333fm")]
        public EventData FewestMove { get; set; }

        [JsonPropertyName("333oh")]
        public EventData OneHand { get; set; }

        [JsonPropertyName("444bf")]
        public EventData BlindfoldedFour { get; set; }

        [JsonPropertyName("555bf")]
        public EventData BlindfoldedFive { get; set; }

        [JsonPropertyName("clock")]
        public EventData Clock { get; set; }

        [JsonPropertyName("minx")]
        public EventData Megaminx { get; set; }

        [JsonPropertyName("pyram")]
        public EventData Pyraminx { get; set; }

        [JsonPropertyName("skewb")]
        public EventData Skewb { get; set; }

        [JsonPropertyName("sq1")]
        public EventData SquareOne { get; set; }
    }

    public class EventData
    {
        [JsonPropertyName("single")]
        public SolveStatsData Single { get; set; }

        [JsonPropertyName("average")]
        public SolveStatsData Average { get; set; }
    }

    public class SolveStatsData
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
