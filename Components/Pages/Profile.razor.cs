using Microsoft.AspNetCore.Components;
using Rubik.Components.Data;
using System.Diagnostics.Metrics;

namespace Rubik.Components.Pages
{
    public partial class Profile : ComponentBase
    {
        [Inject]
        private HttpClient Client { get; set; }

        private Person person;
        private CountryName countryName;
        private List<Person> personList = new List<Person>();

        private string GetFlagUrl(string countryCode)
        {
            return $"https://flagcdn.com/w20/{countryCode.ToLower()}.png";
        }

        private async Task GetCountryName(string countryCode)
        {
            var response = await Http.GetFromJsonAsync<CountryInfo[]>($"https://restcountries.com/v3.1/alpha/{countryCode}");
            if (response != null && response.Length > 0)
            {
                countryName = response[0].Name;
            }
            else
            {
                countryName = new CountryName();
            }
        }

        protected override async Task OnInitializedAsync()
        {
            person = await Client.GetFromJsonAsync<Person>("https://raw.githubusercontent.com/robiningelbrecht/wca-rest-api/master/api/persons/2015DEVI01.json");
            personList.Add(person);
            await GetCountryName(person.Country);
        }
    }
}
