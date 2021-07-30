using Microsoft.Win32;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LightSwitch.Services
{
	class ThemeService
	{
		private readonly WallpaperService _wallpaperService = new();

		public NotifyIcon NotifyIcon { get; set; }

		/// <summary>
		/// Switches to the other theme.
		/// </summary>
		public void Switch()
		{
			if (PreferencesService.GetCurrentTheme() == "Light")
			{
				SetDark();
			}
			else
			{
				SetLight();
			}
		}

		/// <summary>
		/// Reloads the current theme.
		/// </summary>
		public void Reload()
		{
			if (PreferencesService.GetCurrentTheme() == "Light")
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
			NotifyIcon.Icon = Resources.Icon_Flipped;

			var preferences = PreferencesService.GetPreferences();

			if (preferences.IsAppThemeEnabled) SetAppTheme(true);
			if (preferences.IsSystemThemeEnabled) SetSystemTheme(true);
			if (preferences.IsWallpaperEnabled)
			{
				if (File.Exists(preferences.LightWallpaper))
				{
					_wallpaperService.SetImage(preferences.LightWallpaper);
				}
				else
				{
					_wallpaperService.SetColor(Color.FromArgb(preferences.LightColor));
				}
			}

			PreferencesService.SaveCurrentTheme("Light");
		}

		private void SetDark()
		{
			NotifyIcon.Icon = Resources.Icon;

			var preferences = PreferencesService.GetPreferences();

			if (preferences.IsAppThemeEnabled) SetAppTheme(false);
			if (preferences.IsSystemThemeEnabled) SetSystemTheme(false);
			if (preferences.IsWallpaperEnabled)
			{
				if (File.Exists(preferences.DarkWallpaper))
				{
					_wallpaperService.SetImage(preferences.DarkWallpaper);
				}
				else
				{
					_wallpaperService.SetColor(Color.FromArgb(preferences.DarkColor));
				}
			}

			PreferencesService.SaveCurrentTheme("Dark");
		}

		private static void SetAppTheme(bool light) => PersonalizeKey.SetValue("AppsUseLightTheme", light ? 1 : 0, RegistryValueKind.DWord);

		private static void SetSystemTheme(bool light) => PersonalizeKey.SetValue("SystemUsesLightTheme", light ? 1 : 0, RegistryValueKind.DWord);

		private static RegistryKey PersonalizeKey => Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", true);
	}
}
