using Microsoft.AspNetCore.Components;
using Rubik.Components.Types;
using Rubik.Components.Data;

namespace Rubik.Components.Stats
{
    public partial class Records : ComponentBase
    {
        [Parameter]
        public EventType Type { get; set; }
        [Parameter]
        public EventData EventToDisplay { get; set; }
    }
}
