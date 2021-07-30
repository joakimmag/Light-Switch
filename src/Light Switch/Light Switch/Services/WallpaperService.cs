using Microsoft.Win32;
using System.Drawing;
using System.Runtime.InteropServices;

namespace LightSwitch.Services
{
	class WallpaperService
    {
        private readonly uint SPI_SETDESKWALLPAPER = 0x14;
        private readonly uint SPIF_UPDATEINIFILE = 0x01;
        private readonly uint SPIF_SENDWININICHANGE = 0x02;
        private readonly int COLOR_DESKTOP = 1;

        [DllImport("user32.dll")]
        private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);
        [DllImport("user32.dll")]
        public static extern bool SetSysColors(int cElements, int[] lpaElements, int[] lpaRgbValues);

        public void SetImage(string path)
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }

        public void SetColor(Color color)
		{
            // Remove the current wallpaper
            SetImage("");

            // Set the new desktop solid color for the current session
            int[] elements = { COLOR_DESKTOP };
            int[] colors = { ColorTranslator.ToWin32(color) };
            SetSysColors(elements.Length, elements, colors);

			// Save value in registry so that it will persist
			var key = Registry.CurrentUser.OpenSubKey("Control Panel\\Colors", true);
			key.SetValue(@"Background", string.Format("{0} {1} {2}", color.R, color.G, color.B));
		}
    }
}
