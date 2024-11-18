using Microsoft.AspNetCore.Components;
using RubikApp.Components.Data;
using RubikApp.Components.Stats;

namespace RubikApp.Components.Pages
{
    public partial class Profile : ComponentBase
    {
        [Inject]
        HttpClient client { get; set; }

        string wcaId = "2015DEVI01";

        PersonResponse personResponse;
        List<PersonResponse> personResponseList = new List<PersonResponse>();

        string getFlagUrl(string countryCode)
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
