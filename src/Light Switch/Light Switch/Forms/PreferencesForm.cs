using LightSwitch.Facades;
using LightSwitch.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LightSwitch.Forms
{
	public partial class PreferencesForm : Form
	{
		private FileFacade _fileFacade = new FileFacade();
		private PreferencesFacade _preferencesFacade = new PreferencesFacade();

		private Preferences Preferences { get; set; }

		public PreferencesForm()
		{
			InitializeComponent();
		}

		private void PreferencesForm_Load(object sender, EventArgs e)
		{
			lblVersion.Text = Application.ProductVersion;

			Preferences = _preferencesFacade.GetPreferences();

			rbnSystemEnabled.Checked = Preferences.SystemThemeIsEnabled;
			rbnSystemDisabled.Checked = !Preferences.SystemThemeIsEnabled;
			rbnAppEnabled.Checked = Preferences.AppThemeIsEnabled;
			rbnAppDisabled.Checked = !Preferences.AppThemeIsEnabled;

			if (File.Exists(Preferences.LightWallpaper))
			{
				pbxLight.Load(Preferences.LightWallpaper);
			}
			else
			{
				pbxLight.BackColor = Color.FromArgb(Preferences.LightColor);
			}

			if (File.Exists(Preferences.DarkWallpaper))
			{
				pbxDark.Load(Preferences.DarkWallpaper);
			}
			else
			{
				pbxDark.BackColor = Color.FromArgb(Preferences.DarkColor);
			}

			if (Preferences.WallpaperIsEnabled)
			{
				rbnWallpaperIsEnabled.Checked = true;
			}
			else
			{
				DisableWallpaperControls();
			}
		}

		private void EnableWallpaperControls()
		{
			foreach (Control control in groupBox1.Controls)
			{
				if (control is RadioButton) continue;
				control.Enabled = true;
			}
		}

		private void DisableWallpaperControls()
		{
			foreach (Control control in groupBox1.Controls)
			{
				if (control is RadioButton) continue;
				control.Enabled = false;
			}
		}

		private void rbnSystemEnabled_CheckedChanged(object sender, EventArgs e)
		{
			Preferences.SystemThemeIsEnabled = (sender as RadioButton).Checked;
		}

		private void rbnAppEnabled_CheckedChanged(object sender, EventArgs e)
		{
			Preferences.AppThemeIsEnabled = (sender as RadioButton).Checked;
		}

		private void rbnWallpaperIsEnabled_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as RadioButton).Checked)
			{
				Preferences.WallpaperIsEnabled = true;
				EnableWallpaperControls();
			}
			else
			{
				Preferences.WallpaperIsEnabled = false;
				DisableWallpaperControls();
			}
		}

		private void btnBrowseLight_Click(object sender, EventArgs e)
		{
			var result = dlgLight.ShowDialog();
			if (result == DialogResult.OK)
			{
				Preferences.LightWallpaper = dlgLight.FileName;
				pbxLight.BackColor = default;
				pbxLight.Load(dlgLight.FileName);
			}
		}

		private void btnBrowseDark_Click(object sender, EventArgs e)
		{
			var result = dlgDark.ShowDialog();
			if (result == DialogResult.OK)
			{
				Preferences.DarkWallpaper = dlgDark.FileName;
				pbxDark.BackColor = default;
				pbxDark.Load(dlgDark.FileName);
			}
		}

		private void btnLightColor_Click(object sender, EventArgs e)
		{
			dlgColor.Color = Color.FromArgb(Preferences.LightColor);
			var result = dlgColor.ShowDialog();
			if (result == DialogResult.OK)
			{
				Preferences.LightWallpaper = null;
				Preferences.LightColor = dlgColor.Color.ToArgb();
				pbxLight.BackColor = dlgColor.Color;
				pbxLight.Image = null;
			}
		}

		private void btnDarkColor_Click(object sender, EventArgs e)
		{
			dlgColor.Color = Color.FromArgb(Preferences.DarkColor);
			var result = dlgColor.ShowDialog();
			if (result == DialogResult.OK)
			{
				Preferences.DarkWallpaper = null;
				Preferences.DarkColor = dlgColor.Color.ToArgb();
				pbxDark.BackColor = dlgColor.Color;
				pbxDark.Image = null;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(Preferences.LightWallpaper))
			{
				Preferences.LightWallpaper = _fileFacade.SaveToTemp("Wallpapers", Preferences.LightWallpaper);
			}

			if (!string.IsNullOrEmpty(Preferences.DarkWallpaper))
			{
				Preferences.DarkWallpaper = _fileFacade.SaveToTemp("Wallpapers", Preferences.DarkWallpaper);
			}

			pbxLight.Dispose();
			pbxDark.Dispose();

			_fileFacade.ClearTemp("Wallpapers", Preferences.LightWallpaper, Preferences.DarkWallpaper);
			_preferencesFacade.SavePreferences(Preferences);
			DialogResult = DialogResult.OK;
			Close();
		}

		private void llbGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(new ProcessStartInfo("https://github.com/wireless-r/Light-Switch") { UseShellExecute = true });
		}
	}
}
