using Microsoft.AspNetCore.Components;
using System.Timers;

namespace RubikApp.Client.Components.Counter
{
    public partial class Counter : ComponentBase
    {
        enum TimerState 
        {
            Stopped,
            Running,
        };

        System.Timers.Timer timer;
        TimerState currentState = TimerState.Stopped;
        TimeSpan elapsedTime;
        DateTime startTime;

        public void TimerTrigger() 
        {
            switch (currentState) 
            {
                case TimerState.Stopped:
                    startTimer();
                    break;
                case TimerState.Running:
                    stopTimer();
                    break;
                default:
                    break;
            }
        }

        protected override void OnInitialized()
        {
            timer = new System.Timers.Timer(10); // 10ms interval
            timer.Elapsed += updateTime;
            timer.AutoReset = true;
        }

        void startTimer() 
        {
            currentState = TimerState.Running;

            startTime = DateTime.Now;
            timer = new System.Timers.Timer(10);
            timer.Elapsed += updateTime;

            timer.Start();
            StateHasChanged();
        }

        void stopTimer() 
        {
            currentState = TimerState.Stopped;

            timer.Stop();
            timer.Dispose();
        }

        void updateTime(object? sender, ElapsedEventArgs e) 
        {
            elapsedTime = DateTime.Now - startTime;
            InvokeAsync(StateHasChanged);
        }
    }
}