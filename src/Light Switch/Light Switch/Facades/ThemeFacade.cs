using Microsoft.Win32;
using System.Drawing;
using System.IO;

namespace LightSwitch.Facades
{
	class ThemeFacade
	{
		private readonly PreferencesFacade _preferencesFacade = new PreferencesFacade();
		private readonly WallpaperFacade _wallpaperFacade = new WallpaperFacade();

		public void Toggle()
		{
			var preferences = _preferencesFacade.GetPreferences();

			if (preferences.CurrentTheme == "Light")
			{
				SetDark();
			}
			else
			{
				SetLight();
			}
		}

		public void Update()
		{
			var preferences = _preferencesFacade.GetPreferences();

			if (preferences.CurrentTheme == "Light")
			{
				SetLight();
			}
			else
			{
				SetDark();
			}
		}

		private void SetLight()
		{
			var preferences = _preferencesFacade.GetPreferences();

			if (preferences.AppThemeIsEnabled) SetAppTheme(true);
			if (preferences.SystemThemeIsEnabled) SetSystemTheme(true);
			if (preferences.WallpaperIsEnabled)
			{
				if (File.Exists(preferences.LightWallpaper))
				{
					_wallpaperFacade.SetImage(preferences.LightWallpaper);
				}
				else
				{
					_wallpaperFacade.SetColor(Color.FromArgb(preferences.LightColor));
				}
			}

			_preferencesFacade.SaveCurrentTheme("Light");
		}

		private void SetDark()
		{
			var preferences = _preferencesFacade.GetPreferences();

			if (preferences.AppThemeIsEnabled) SetAppTheme(false);
			if (preferences.SystemThemeIsEnabled) SetSystemTheme(false);
			if (preferences.WallpaperIsEnabled)
			{
				if (File.Exists(preferences.DarkWallpaper))
				{
					_wallpaperFacade.SetImage(preferences.DarkWallpaper);
				}
				else
				{
					_wallpaperFacade.SetColor(Color.FromArgb(preferences.DarkColor));
				}
			}

			_preferencesFacade.SaveCurrentTheme("Dark");
		}

		private void SetAppTheme(bool light) => PersonalizeKey.SetValue("AppsUseLightTheme", light ? 1 : 0, RegistryValueKind.DWord);

		private void SetSystemTheme(bool light) => PersonalizeKey.SetValue("SystemUsesLightTheme", light ? 1 : 0, RegistryValueKind.DWord);

		private RegistryKey PersonalizeKey => Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", true);
	}
}
