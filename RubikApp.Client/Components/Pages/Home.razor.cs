using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace RubikApp.Client.Components.Pages
{
    public partial class Home : ComponentBase
    {
        Counter.Counter counter;
        Components.Stats.TimeStats currentStats;

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                counter.OnTimerEnded += onTimerEnded;
            }
        }

        void onKeyDown(KeyboardEventArgs e)
        {
            if (e.Key == " ")
                counter?.TryLoadTimer();
        }        

        void onKeyUp(KeyboardEventArgs e) 
        {
            if (e.Key == " ")
                counter?.TryStartTimer();
        }

        void onTimerEnded(TimeSpan elapsedTime) 
        {
            currentStats.RecordTime(elapsedTime);
        }

        public void Dispose()
        {
            counter.OnTimerEnded -= onTimerEnded;
        }
    }
}
