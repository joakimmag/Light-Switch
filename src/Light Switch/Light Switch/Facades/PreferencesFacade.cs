using LightSwitch.Models;
using LightSwitch.Properties;

namespace LightSwitch.Facades
{
	class PreferencesFacade
	{
		public Preferences GetPreferences() => new Preferences
		{
			AppThemeIsEnabled = Settings.Default.AppThemeIsEnabled,
			CurrentTheme = Settings.Default.CurrentTheme,
			DarkColor = Settings.Default.DarkColor,
			DarkWallpaper = Settings.Default.DarkWallpaper,
			LightColor = Settings.Default.LightColor,
			LightWallpaper = Settings.Default.LightWallpaper,
			SystemThemeIsEnabled = Settings.Default.SystemThemeIsEnabled,
			WallpaperIsEnabled = Settings.Default.WallpaperIsEnabled,
		};

		public void SavePreferences(Preferences preferences)
		{
			Settings.Default.AppThemeIsEnabled = preferences.AppThemeIsEnabled;
			Settings.Default.CurrentTheme = preferences.CurrentTheme;
			Settings.Default.DarkColor = preferences.DarkColor;
			Settings.Default.DarkWallpaper = preferences.DarkWallpaper;
			Settings.Default.LightColor = preferences.LightColor;
			Settings.Default.LightWallpaper = preferences.LightWallpaper;
			Settings.Default.SystemThemeIsEnabled = preferences.SystemThemeIsEnabled;
			Settings.Default.WallpaperIsEnabled = preferences.WallpaperIsEnabled;
			Settings.Default.Save();
		}

		public string GetCurrentTheme() => Settings.Default.CurrentTheme;

		public void SaveCurrentTheme(string theme)
		{
			Settings.Default.CurrentTheme = theme;
			Settings.Default.Save();
		}
	}
}
