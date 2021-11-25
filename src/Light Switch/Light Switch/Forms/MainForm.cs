using System;
using System.Drawing;
using System.Windows.Forms;

namespace LightSwitch.Forms
{
	/// <summary>
	/// MainForm's purpose is to handle close message from external sender.
	/// For example, this is required when you install new version and the installer wants to close the running application.
	/// It is handled, we only need to hide the form.
	/// </summary>
	class MainForm : Form
	{
		public MainForm()
		{
			Load += MainForm_Load;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			FormBorderStyle = FormBorderStyle.None;
			Opacity = 0;
			ShowInTaskbar = false;
			Size = new Size(0, 0);
			Hide();
		}
	}
}
