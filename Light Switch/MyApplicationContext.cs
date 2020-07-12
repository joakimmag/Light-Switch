using Light_Switch;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace LightSwitch
{
	class MyApplicationContext : ApplicationContext
	{
		private readonly NotifyIcon _notifyIcon;

		public MyApplicationContext()
		{
			Application.ApplicationExit += OnApplicationExit;

			var exitItem = new ToolStripMenuItem("&Exit", null, OnExitItemClick);

			var contextMenuStrip = new ContextMenuStrip();
			contextMenuStrip.Items.Add(exitItem);

			_notifyIcon = new NotifyIcon
			{
				ContextMenuStrip = contextMenuStrip,
				Icon = Resources.Icon,
				Text = "Light Switch",
				Visible = true,
			};

			_notifyIcon.MouseClick += OnNotifyIconClick;
		}

		private void OnExitItemClick(object sender, EventArgs e)
		{
			_notifyIcon.Visible = false;
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
				SetTheme(!IsLightTheme());
			}
		}

		private bool IsLightTheme() => AppsUseLightTheme() || SystemUsesLightTheme();

		private void SetTheme(bool light)
		{
			GetPersonalizeKey().SetValue("AppsUseLightTheme", light ? 1 : 0, RegistryValueKind.DWord);
			GetPersonalizeKey().SetValue("SystemUsesLightTheme", light ? 1 : 0, RegistryValueKind.DWord);
		}

		private bool AppsUseLightTheme() => (int)GetPersonalizeKey().GetValue("AppsUseLightTheme") == 1;

		private bool SystemUsesLightTheme() => (int)GetPersonalizeKey().GetValue("SystemUsesLightTheme") == 1;

		private RegistryKey GetPersonalizeKey() => Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", true);
	}
}
