using Microsoft.Win32;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LightSwitch.Services
{
	internal class ThemeService
	{
		private WallpaperService WallpaperService { get; } = new();

		public NotifyIcon NotifyIcon { get; set; }

		/// <summary>
		/// Switches to the other theme.
		/// </summary>
		public void Switch()
		{
			if (PreferencesService.GetCurrentTheme() == Theme.Light)
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
			if (PreferencesService.GetCurrentTheme() == Theme.Light)
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
			var preferences = PreferencesService.GetPreferences();

			if (preferences.IsAppThemeEnabled) SetAppTheme(true);
			if (preferences.IsSystemThemeEnabled)
			{
				SetSystemTheme(true);
                NotifyIcon.Icon = Resources.Icon_LightMode;
            }
			if (preferences.IsWallpaperEnabled)
			{
				if (File.Exists(preferences.LightWallpaperPath))
				{
					WallpaperService.SetImage(preferences.LightWallpaperPath);
				}
				else
				{
					WallpaperService.SetColor(Color.FromArgb(preferences.LightColor));
				}
			}

			PreferencesService.SaveCurrentThemeName("Light");
		}

		private void SetDark()
		{
			var preferences = PreferencesService.GetPreferences();

			if (preferences.IsAppThemeEnabled) SetAppTheme(false);
			if (preferences.IsSystemThemeEnabled)
			{
				SetSystemTheme(false);
                NotifyIcon.Icon = Resources.Icon_DarkMode;
            }
			if (preferences.IsWallpaperEnabled)
			{
				if (File.Exists(preferences.DarkWallpaperPath))
				{
					WallpaperService.SetImage(preferences.DarkWallpaperPath);
				}
				else
				{
					WallpaperService.SetColor(Color.FromArgb(preferences.DarkColor));
				}
			}

			PreferencesService.SaveCurrentThemeName("Dark");
		}

		private static void SetAppTheme(bool light) => PersonalizeKey.SetValue("AppsUseLightTheme", light ? 1 : 0, RegistryValueKind.DWord);

		private static void SetSystemTheme(bool light) => PersonalizeKey.SetValue("SystemUsesLightTheme", light ? 1 : 0, RegistryValueKind.DWord);

		private static RegistryKey PersonalizeKey => Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", true);
	}
}
