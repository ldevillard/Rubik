namespace Rubik.Components.Data
{
    public class CountryInfo
    {
        public CountryName Name { get; set; }
    }

    public class CountryName
    {
        public CountryName() { Common = "Unknown"; Official = "Unknown"; }

        public string Common { get; set; }
        public string Official { get; set; }
    }
}
