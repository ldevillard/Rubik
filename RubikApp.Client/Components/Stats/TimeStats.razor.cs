using Microsoft.AspNetCore.Components;
using System.Linq;

namespace RubikApp.Client.Components.Stats
{
    public partial class TimeStats : ComponentBase
    {
        List<TimeSpan> currentTimes = new List<TimeSpan>();

        TimeSpan lastTime;
        TimeSpan averageOfFive;

        public void RecordTime(TimeSpan timeToRecord) 
        {
            currentTimes.Add(timeToRecord);
            lastTime = timeToRecord;
            computeAverageOfFive();
            StateHasChanged();
        }

        string getFormatedTime(TimeSpan timeSpan) 
        {
            if(timeSpan.Hours > 0)
            {
                return $"{timeSpan.Hours:00}.{timeSpan.Minutes:00}:{timeSpan.Seconds:00}.{(timeSpan.Milliseconds / 10):00}";
            }
            else if (timeSpan.Minutes > 0)
            {
                return $"{timeSpan.Minutes:00}:{timeSpan.Seconds:00}.{(timeSpan.Milliseconds / 10):00}";
            }
            else
            {
                return $"{timeSpan.Seconds:00}.{(timeSpan.Milliseconds / 10):00}";
            }
        }

        void computeAverageOfFive()
        {
            if (currentTimes.Count < 5)
            {
                averageOfFive = TimeSpan.Zero;
                return;
            }

            // Prendre les 5 derniers temps
            List<TimeSpan> lastFiveTimes = currentTimes.Skip(currentTimes.Count - 5).ToList();

            // Trier les temps pour trouver le meilleur et le pire
            lastFiveTimes.Sort();

            // Supprimer le meilleur et le pire
            lastFiveTimes.RemoveAt(0); // Supprimer le plus petit (meilleur)
            lastFiveTimes.RemoveAt(lastFiveTimes.Count - 1); // Supprimer le plus grand (pire)

            // Calculer la moyenne des trois temps restants
            averageOfFive = TimeSpan.FromTicks((long)lastFiveTimes.Average(ts => ts.Ticks));
        }
    }
}
