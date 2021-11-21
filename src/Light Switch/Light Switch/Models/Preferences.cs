using System.Drawing;

namespace LightSwitch.Models
{
	class Preferences
	{
		public string CurrentThemeName { get; set; }
		public int DarkColor { get; set; }
		public string DarkWallpaperPath { get; set; }
		public int LightColor { get; set; }
		public string LightWallpaperPath { get; set; }
		public bool IsAppThemeEnabled { get; set; }
		public bool IsSystemThemeEnabled { get; set; }
		public bool IsWallpaperEnabled { get; set; }
	}
}
