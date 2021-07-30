using LightSwitch.Models;
using LightSwitch.Properties;

namespace LightSwitch.Services
{
	class PreferencesService
	{
		public static Preferences GetPreferences() => new()
		{
			CurrentTheme = Settings.Default.CurrentTheme,
			DarkColor = Settings.Default.DarkColor,
			DarkWallpaper = Settings.Default.DarkWallpaper,
			IsAppThemeEnabled = Settings.Default.IsAppThemeEnabled,
			IsSystemThemeEnabled = Settings.Default.IsSystemThemeEnabled,
			IsWallpaperEnabled = Settings.Default.IsWallpaperEnabled,
			LightColor = Settings.Default.LightColor,
			LightWallpaper = Settings.Default.LightWallpaper,
		};

		public static void SavePreferences(Preferences preferences)
		{
			Settings.Default.CurrentTheme = preferences.CurrentTheme;
			Settings.Default.DarkColor = preferences.DarkColor;
			Settings.Default.DarkWallpaper = preferences.DarkWallpaper;
			Settings.Default.IsAppThemeEnabled = preferences.IsAppThemeEnabled;
			Settings.Default.IsSystemThemeEnabled = preferences.IsSystemThemeEnabled;
			Settings.Default.IsWallpaperEnabled = preferences.IsWallpaperEnabled;
			Settings.Default.LightColor = preferences.LightColor;
			Settings.Default.LightWallpaper = preferences.LightWallpaper;
			Settings.Default.Save();
		}

		public static string GetCurrentTheme() => Settings.Default.CurrentTheme;

		public static void SaveCurrentTheme(string theme)
		{
			Settings.Default.CurrentTheme = theme;
			Settings.Default.Save();
		}
	}
}
