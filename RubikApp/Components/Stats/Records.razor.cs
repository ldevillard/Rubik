using Microsoft.AspNetCore.Components;
using RubikApp.Components.Types;
using RubikApp.Components.Data;

namespace RubikApp.Components.Stats
{
    public partial class Records : ComponentBase
    {
        [Parameter]
        public EventType Type { get; set; }
        [Parameter]
        public EventData EventToDisplay { get; set; }
    }
}
