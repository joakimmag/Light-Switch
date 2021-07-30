using System;
using System.Drawing;
using System.Windows.Forms;

namespace LightSwitch.Forms
{
	/// <summary>
	/// When you install a new version and the installer asks to close the running application, MainForm will handle close message from external sender. We only need to hide it.
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
