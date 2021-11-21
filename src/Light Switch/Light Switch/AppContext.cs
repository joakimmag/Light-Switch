using LightSwitch.Services;
using LightSwitch.Forms;
using System;
using System.Windows.Forms;

namespace LightSwitch
{
	internal class AppContext : ApplicationContext
	{
		private NotifyIcon NotifyIcon { get; } = new();
		private ThemeService ThemeService { get; } = new();

		public AppContext()
		{
			MainForm = new MainForm();
			Application.ApplicationExit += OnApplicationExit;

			var contextMenuStrip = new ContextMenuStrip();
			contextMenuStrip.Items.Add(new ToolStripMenuItem("Preferences", null, OnPreferencesClick));
			contextMenuStrip.Items.Add(new ToolStripSeparator());
			contextMenuStrip.Items.Add(new ToolStripMenuItem("Exit", null, OnExitClick));
			
			NotifyIcon.ContextMenuStrip = contextMenuStrip;
			NotifyIcon.Icon = PreferencesService.GetCurrentTheme() == Theme.Dark ? Resources.Icon_DarkMode : Resources.Icon_LightMode;
			NotifyIcon.Text = "Light Switch";
			NotifyIcon.Visible = true;
			NotifyIcon.MouseClick += OnNotifyIconClick;

			ThemeService.NotifyIcon = NotifyIcon;
		}

		private void OnPreferencesClick(object sender, EventArgs e)
		{
			var preferencesForm = new PreferencesForm();
			var result = preferencesForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				ThemeService.Reload();
			}
		}

		private void OnExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void OnApplicationExit(object sender, EventArgs e)
		{
			NotifyIcon.Visible = false;
		}

		private void OnNotifyIconClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ThemeService.Switch();
			}
		}
	}
}
