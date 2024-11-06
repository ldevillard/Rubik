using MudBlazor;

namespace Rubik.Components.Data
{
    public class Theme
    {
        public MudTheme CustomTheme = new MudTheme()
        {
            PaletteDark = new PaletteDark()
            {
                Background = "#1f1f30",
                Surface = "#151521",
                TableStriped = "#1a1a29",
            }
        };
    }
}