using LightSwitch.Services;
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
		private Preferences OldPreferences { get; set; }
		private Preferences NewPreferences { get; set; }

		public PreferencesForm()
		{
			InitializeComponent();
		}

		private void PreferencesForm_Load(object sender, EventArgs e)
		{
			OldPreferences = PreferencesService.GetPreferences();
			NewPreferences = OldPreferences;

			lblVersion.Text = Application.ProductVersion;

			rbnSystemEnabled.Checked = OldPreferences.IsSystemThemeEnabled;
			rbnSystemDisabled.Checked = !OldPreferences.IsSystemThemeEnabled;
			rbnAppEnabled.Checked = OldPreferences.IsAppThemeEnabled;
			rbnAppDisabled.Checked = !OldPreferences.IsAppThemeEnabled;

			if (File.Exists(OldPreferences.LightWallpaperPath))
			{
				pbxLight.Load(OldPreferences.LightWallpaperPath);
			}
			else
			{
				pbxLight.BackColor = Color.FromArgb(OldPreferences.LightColor);
			}

			if (File.Exists(OldPreferences.DarkWallpaperPath))
			{
				pbxDark.Load(OldPreferences.DarkWallpaperPath);
			}
			else
			{
				pbxDark.BackColor = Color.FromArgb(OldPreferences.DarkColor);
			}

			if (OldPreferences.IsWallpaperEnabled)
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
			NewPreferences.IsSystemThemeEnabled = (sender as RadioButton).Checked;
		}

		private void rbnAppEnabled_CheckedChanged(object sender, EventArgs e)
		{
			NewPreferences.IsAppThemeEnabled = (sender as RadioButton).Checked;
		}

		private void rbnWallpaperIsEnabled_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as RadioButton).Checked)
			{
				NewPreferences.IsWallpaperEnabled = true;
				EnableWallpaperControls();
			}
			else
			{
				NewPreferences.IsWallpaperEnabled = false;
				DisableWallpaperControls();
			}
		}

		private void btnBrowseLight_Click(object sender, EventArgs e)
		{
			if (dlgLight.ShowDialog() == DialogResult.OK)
			{
				NewPreferences.LightWallpaperPath = dlgLight.FileName;
				pbxLight.BackColor = default;
				pbxLight.Load(dlgLight.FileName);
			}
		}

		private void btnBrowseDark_Click(object sender, EventArgs e)
		{
			if (dlgDark.ShowDialog() == DialogResult.OK)
			{
				NewPreferences.DarkWallpaperPath = dlgDark.FileName;
				pbxDark.BackColor = default;
				pbxDark.Load(dlgDark.FileName);
			}
		}

		private void btnLightColor_Click(object sender, EventArgs e)
		{
			dlgColor.Color = Color.FromArgb(NewPreferences.LightColor);
			if (dlgColor.ShowDialog() == DialogResult.OK)
			{
				NewPreferences.LightColor = dlgColor.Color.ToArgb();
				NewPreferences.LightWallpaperPath = null;
				pbxLight.BackColor = dlgColor.Color;
				pbxLight.Image = null;
			}
		}

		private void btnDarkColor_Click(object sender, EventArgs e)
		{
			dlgColor.Color = Color.FromArgb(NewPreferences.DarkColor);
			if (dlgColor.ShowDialog() == DialogResult.OK)
			{
				NewPreferences.DarkColor = dlgColor.Color.ToArgb();
				NewPreferences.DarkWallpaperPath = null;
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
			FileInfo newLightWallpaperFile = null;
			FileInfo newDarkWallpaperFile = null;

			if (!string.IsNullOrEmpty(NewPreferences.LightWallpaperPath))
			{
				var lightWallpaperFile = new FileInfo(NewPreferences.LightWallpaperPath);

				if (Storage.Wallpapers.TryImport(lightWallpaperFile, out newLightWallpaperFile))
				{
					NewPreferences.LightWallpaperPath = newLightWallpaperFile.FullName;
				}
			}

			if (!string.IsNullOrEmpty(NewPreferences.DarkWallpaperPath))
			{
				var darkWallpaperFile = new FileInfo(NewPreferences.DarkWallpaperPath);

				if (Storage.Wallpapers.TryImport(darkWallpaperFile, out newDarkWallpaperFile))
				{
					NewPreferences.DarkWallpaperPath = newDarkWallpaperFile.FullName;
				}
			}

			pbxLight.Dispose();
			pbxDark.Dispose();

			Storage.Wallpapers.Clear(newLightWallpaperFile, newDarkWallpaperFile);

			PreferencesService.SavePreferences(NewPreferences);

			DialogResult = DialogResult.OK;
			Close();
		}

		private void llbGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(new ProcessStartInfo("https://github.com/wireless-r/Light-Switch") { UseShellExecute = true });
		}
	}
}
