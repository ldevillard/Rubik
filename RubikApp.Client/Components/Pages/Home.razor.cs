using Microsoft.AspNetCore.Components;
using RubikApp.Client.Components;

namespace RubikApp.Client.Components.Pages
{
    public partial class Home : ComponentBase
    {
        Counter.Counter Counter;

        void CallIncrement() 
        {
            Counter?.IncrementCount();
        }
    }
}
