using System.Drawing;

namespace LightSwitch.Models
{
	class Preferences
	{
		public bool AppThemeIsEnabled { get; set; }
		public string CurrentTheme { get; set; }
		public int DarkColor { get; set; }
		public string DarkWallpaper { get; set; }
		public int LightColor { get; set; }
		public string LightWallpaper { get; set; }
		public bool SystemThemeIsEnabled { get; set; }
		public bool WallpaperIsEnabled { get; set; }
	}
}
