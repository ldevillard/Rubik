using Microsoft.AspNetCore.Components;

namespace RubikApp.Client.Components.Counter
{
    public partial class Counter : ComponentBase
    {
        float currentCount = 0;
    
        public void IncrementCount() 
        {
            currentCount++;
        }
    }
}