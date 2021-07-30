using LightSwitch.Services;
using LightSwitch.Forms;
using System;
using System.Windows.Forms;

namespace LightSwitch
{
	class AppContext : ApplicationContext
	{
		private readonly NotifyIcon _notifyIcon = new NotifyIcon();
		private readonly ThemeService _themeService = new ThemeService();
		private readonly PreferencesService _preferencesService = new PreferencesService();

		public AppContext()
		{
			MainForm = new MainForm();
			Application.ApplicationExit += OnApplicationExit;

			var contextMenuStrip = new ContextMenuStrip();
			contextMenuStrip.Items.Add(new ToolStripMenuItem("Preferences", null, OnPreferencesClick));
			contextMenuStrip.Items.Add(new ToolStripSeparator());
			contextMenuStrip.Items.Add(new ToolStripMenuItem("Exit", null, OnExitClick));
			
			_notifyIcon.ContextMenuStrip = contextMenuStrip;
			_notifyIcon.Icon = PreferencesService.GetCurrentTheme() == "Dark" ? Resources.Icon : Resources.Icon_Flipped;
			_notifyIcon.Text = "Light Switch";
			_notifyIcon.Visible = true;
			_notifyIcon.MouseClick += OnNotifyIconClick;

			_themeService.NotifyIcon = _notifyIcon;
		}

		private void OnPreferencesClick(object sender, EventArgs e)
		{
			var preferencesForm = new PreferencesForm();
			var result = preferencesForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				_themeService.Reload();
			}
		}

		private void OnExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void OnApplicationExit(object sender, EventArgs e)
		{
			_notifyIcon.Visible = false;
		}

		private void OnNotifyIconClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				_themeService.Switch();
			}
		}
	}
}
