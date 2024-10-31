using Microsoft.AspNetCore.Components;
using Rubik.Components.Data;
using System.Diagnostics.Metrics;

namespace Rubik.Components.Pages
{
    public partial class Profile : ComponentBase
    {
        [Inject]
        private HttpClient Client { get; set; }

        private PersonResponse personResponse;
        private List<PersonResponse> personResponseList = new List<PersonResponse>();

        private string GetFlagUrl(string countryCode)
        {
            return $"https://flagcdn.com/w20/{countryCode.ToLower()}.png";
        }

        protected override async Task OnInitializedAsync()
        {
            personResponse = await Client.GetFromJsonAsync<PersonResponse>("https://www.worldcubeassociation.org/api/v0/persons/2015DEVI01");
            personResponseList.Add(personResponse);
        }
    }
}
