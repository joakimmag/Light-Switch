using System;
using System.Drawing;
using System.Windows.Forms;

namespace LightSwitch.Forms
{
	/// <summary>
	/// This form's purpose is to handle close message from external sender.
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
