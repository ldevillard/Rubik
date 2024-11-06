using Rubik.Components.Types;

namespace Rubik.Components.Utility
{
    public class Utility
    {
        static public string GetEventIconStyle(EventType type)
        {
            switch (type)
            {
                case EventType.CUBE22: return "cubing-icon event-222";
                case EventType.CUBE33: return "cubing-icon event-333";
                case EventType.CUBE44: return "cubing-icon event-444";
                case EventType.CUBE55: return "cubing-icon event-555";
                case EventType.CUBE66: return "cubing-icon event-666";
                case EventType.CUBE77: return "cubing-icon event-777";
                case EventType.BF: return "cubing-icon event-333bf";
                case EventType.BFM: return "cubing-icon event-333mbf";
                case EventType.FM: return "cubing-icon event-333fm";
                case EventType.OH: return "cubing-icon event-333oh";
                case EventType.BF4: return "cubing-icon event-444bf";
                case EventType.BF5: return "cubing-icon event-555bf";
                case EventType.CLOCK: return "cubing-icon event-clock";
                case EventType.PYRA: return "cubing-icon event-pyram";
                case EventType.MEGA: return "cubing-icon event-minx";
                case EventType.SKEWB: return "cubing-icon event-skewb";
                case EventType.SQ1: return "cubing-icon event-sq1";
                default: break;
            }
            return "cubing-icon event-333";
        }

        static public string GetTimeSolveFormat(int time) 
        {
            int centiSeconds = time % 100;

            int totalSeconds = time / 100;
            int seconds = totalSeconds % 60;

            int minutes = totalSeconds / 60;

            if (minutes > 0)
                return $"{minutes}:{seconds:D2}.{centiSeconds:D2}";
            else
                return $"{seconds}.{centiSeconds:D2}";
        }

        public static string GetEventName(EventType type) 
        {
            switch (type)
            {
                case EventType.CUBE77: return "Cube 2x2x2";
                case EventType.CUBE22: return "Cube 3x3x3";
                case EventType.CUBE33: return "Cube 4x4x4";
                case EventType.CUBE44: return "Cube 5x5x5";
                case EventType.CUBE55: return "Cube 6x6x6";
                case EventType.CUBE66: return "Cube 7x7x7";
                case EventType.BF: return "3x3x3 Blindfolded";
                case EventType.BFM: return "3x3x3 Multi blindfolded";
                case EventType.FM: return "3x3x3 Fewest move";
                case EventType.OH: return "3x3x3 One handed";
                case EventType.BF4: return "4x4x4 Blindfolded";
                case EventType.BF5: return "5x5x5 Blindfolded";
                case EventType.CLOCK: return "Clock";
                case EventType.PYRA: return "Pyraminx";
                case EventType.MEGA: return "Megaminx";
                case EventType.SKEWB: return "Skewb";
                case EventType.SQ1: return "Square-1";
                default: break;
            }
            return "cubing-icon event-333";
        }
    }
}
