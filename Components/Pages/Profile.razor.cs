using Microsoft.AspNetCore.Components;
using Rubik.Components.Data;
using System.Diagnostics.Metrics;

namespace Rubik.Components.Pages
{
    public partial class Profile : ComponentBase
    {
        [Inject]
        private HttpClient client { get; set; }

        private string wcaId = "2015DEVI01";

        private PersonResponse personResponse;
        private List<PersonResponse> personResponseList = new List<PersonResponse>();

        private string GetFlagUrl(string countryCode)
        {
            return $"https://flagcdn.com/w20/{countryCode.ToLower()}.png";
        }

        protected override async Task OnInitializedAsync()
        {
            personResponse = await client.GetFromJsonAsync<PersonResponse>($"https://www.worldcubeassociation.org/api/v0/persons/{wcaId}");
            personResponseList.Add(personResponse);
        }
    }
}
