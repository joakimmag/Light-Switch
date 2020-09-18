using LightSwitch.Facades;
using LightSwitch.Forms;
using System;
using System.Windows.Forms;

namespace LightSwitch
{
	class AppContext : ApplicationContext
	{
		private readonly NotifyIcon _notifyIcon;
		private readonly ThemeFacade _themeFacade = new ThemeFacade();
		private readonly PreferencesFacade _preferencesFacade = new PreferencesFacade();

		public AppContext()
		{
			MainForm = new MainForm();
			Application.ApplicationExit += OnApplicationExit;

			var contextMenuStrip = new ContextMenuStrip();
			contextMenuStrip.Items.Add(new ToolStripMenuItem("Preferences", null, OnPreferencesClick));
			contextMenuStrip.Items.Add(new ToolStripSeparator());
			contextMenuStrip.Items.Add(new ToolStripMenuItem("Exit", null, OnExitClick));
			
			_notifyIcon = new NotifyIcon
			{
				ContextMenuStrip = contextMenuStrip,
				Icon = Resources.Icon,
				Text = "Light Switch",
				Visible = true,
			};

			_notifyIcon.MouseClick += OnNotifyIconClick;
		}

		private void OnPreferencesClick(object sender, EventArgs e)
		{
			var preferencesForm = new PreferencesForm();
			var result = preferencesForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				_themeFacade.Update();
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
				_themeFacade.Toggle();
			}
		}
	}
}
