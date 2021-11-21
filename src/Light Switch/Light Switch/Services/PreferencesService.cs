using LightSwitch.Models;
using LightSwitch.Properties;

namespace LightSwitch.Services
{
	internal class PreferencesService
	{
		public static Preferences GetPreferences() => new()
		{
			CurrentThemeName = Settings.Default.CurrentThemeName,
			DarkColor = Settings.Default.DarkColor,
			DarkWallpaperPath = Settings.Default.DarkWallpaperPath,
			IsAppThemeEnabled = Settings.Default.IsAppThemeEnabled,
			IsSystemThemeEnabled = Settings.Default.IsSystemThemeEnabled,
			IsWallpaperEnabled = Settings.Default.IsWallpaperEnabled,
			LightColor = Settings.Default.LightColor,
			LightWallpaperPath = Settings.Default.LightWallpaperPath,
		};

		public static void SavePreferences(Preferences preferences)
		{
			Settings.Default.CurrentThemeName = preferences.CurrentThemeName;
			Settings.Default.DarkColor = preferences.DarkColor;
			Settings.Default.DarkWallpaperPath = preferences.DarkWallpaperPath;
			Settings.Default.IsAppThemeEnabled = preferences.IsAppThemeEnabled;
			Settings.Default.IsSystemThemeEnabled = preferences.IsSystemThemeEnabled;
			Settings.Default.IsWallpaperEnabled = preferences.IsWallpaperEnabled;
			Settings.Default.LightColor = preferences.LightColor;
			Settings.Default.LightWallpaperPath = preferences.LightWallpaperPath;
			Settings.Default.Save();
		}

		public static Theme GetCurrentTheme() => Settings.Default.CurrentThemeName;

		public static void SaveCurrentThemeName(Theme theme)
		{
			Settings.Default.CurrentThemeName = theme.Name;
			Settings.Default.Save();
		}
	}
}
