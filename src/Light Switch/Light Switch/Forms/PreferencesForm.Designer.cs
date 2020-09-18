namespace LightSwitch.Forms
{
	partial class PreferencesForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
			this.rbnWallpaperIsEnabled = new System.Windows.Forms.RadioButton();
			this.rdbWallpaperIsDisabled = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnDarkColor = new System.Windows.Forms.Button();
			this.btnLightColor = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBrowseDark = new System.Windows.Forms.Button();
			this.pbxDark = new System.Windows.Forms.PictureBox();
			this.pbxLight = new System.Windows.Forms.PictureBox();
			this.btnBrowseLight = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dlgLight = new System.Windows.Forms.OpenFileDialog();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.dlgDark = new System.Windows.Forms.OpenFileDialog();
			this.dlgColor = new System.Windows.Forms.ColorDialog();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbnSystemDisabled = new System.Windows.Forms.RadioButton();
			this.rbnSystemEnabled = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbnAppDisabled = new System.Windows.Forms.RadioButton();
			this.rbnAppEnabled = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.llbGitHub = new System.Windows.Forms.LinkLabel();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxDark)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLight)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// rbnWallpaperIsEnabled
			// 
			this.rbnWallpaperIsEnabled.AutoSize = true;
			this.rbnWallpaperIsEnabled.Location = new System.Drawing.Point(6, 25);
			this.rbnWallpaperIsEnabled.Name = "rbnWallpaperIsEnabled";
			this.rbnWallpaperIsEnabled.Size = new System.Drawing.Size(73, 21);
			this.rbnWallpaperIsEnabled.TabIndex = 0;
			this.rbnWallpaperIsEnabled.Text = "Enabled";
			this.rbnWallpaperIsEnabled.UseVisualStyleBackColor = true;
			this.rbnWallpaperIsEnabled.CheckedChanged += new System.EventHandler(this.rbnWallpaperIsEnabled_CheckedChanged);
			// 
			// rdbWallpaperIsDisabled
			// 
			this.rdbWallpaperIsDisabled.AutoSize = true;
			this.rdbWallpaperIsDisabled.Checked = true;
			this.rdbWallpaperIsDisabled.Location = new System.Drawing.Point(79, 25);
			this.rdbWallpaperIsDisabled.Name = "rdbWallpaperIsDisabled";
			this.rdbWallpaperIsDisabled.Size = new System.Drawing.Size(77, 21);
			this.rdbWallpaperIsDisabled.TabIndex = 1;
			this.rdbWallpaperIsDisabled.TabStop = true;
			this.rdbWallpaperIsDisabled.Text = "Disabled";
			this.rdbWallpaperIsDisabled.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnDarkColor);
			this.groupBox1.Controls.Add(this.btnLightColor);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnBrowseDark);
			this.groupBox1.Controls.Add(this.pbxDark);
			this.groupBox1.Controls.Add(this.pbxLight);
			this.groupBox1.Controls.Add(this.btnBrowseLight);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.rdbWallpaperIsDisabled);
			this.groupBox1.Controls.Add(this.rbnWallpaperIsEnabled);
			this.groupBox1.Location = new System.Drawing.Point(12, 138);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(497, 160);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Change wallpaper";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(217, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "- or -";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(217, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "- or -";
			// 
			// btnDarkColor
			// 
			this.btnDarkColor.Location = new System.Drawing.Point(262, 108);
			this.btnDarkColor.Name = "btnDarkColor";
			this.btnDarkColor.Size = new System.Drawing.Size(116, 30);
			this.btnDarkColor.TabIndex = 8;
			this.btnDarkColor.Text = "Pick a color...";
			this.btnDarkColor.UseVisualStyleBackColor = true;
			this.btnDarkColor.Click += new System.EventHandler(this.btnDarkColor_Click);
			// 
			// btnLightColor
			// 
			this.btnLightColor.Location = new System.Drawing.Point(262, 52);
			this.btnLightColor.Name = "btnLightColor";
			this.btnLightColor.Size = new System.Drawing.Size(116, 30);
			this.btnLightColor.TabIndex = 7;
			this.btnLightColor.Text = "Pick a color...";
			this.btnLightColor.UseVisualStyleBackColor = true;
			this.btnLightColor.Click += new System.EventHandler(this.btnLightColor_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Dark";
			// 
			// btnBrowseDark
			// 
			this.btnBrowseDark.Location = new System.Drawing.Point(48, 108);
			this.btnBrowseDark.Name = "btnBrowseDark";
			this.btnBrowseDark.Size = new System.Drawing.Size(163, 30);
			this.btnBrowseDark.TabIndex = 5;
			this.btnBrowseDark.Text = "Browse for an image...";
			this.btnBrowseDark.UseVisualStyleBackColor = true;
			this.btnBrowseDark.Click += new System.EventHandler(this.btnBrowseDark_Click);
			// 
			// pbxDark
			// 
			this.pbxDark.Location = new System.Drawing.Point(384, 97);
			this.pbxDark.Name = "pbxDark";
			this.pbxDark.Size = new System.Drawing.Size(100, 50);
			this.pbxDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxDark.TabIndex = 6;
			this.pbxDark.TabStop = false;
			// 
			// pbxLight
			// 
			this.pbxLight.Location = new System.Drawing.Point(384, 41);
			this.pbxLight.Name = "pbxLight";
			this.pbxLight.Size = new System.Drawing.Size(100, 50);
			this.pbxLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxLight.TabIndex = 6;
			this.pbxLight.TabStop = false;
			// 
			// btnBrowseLight
			// 
			this.btnBrowseLight.Location = new System.Drawing.Point(48, 52);
			this.btnBrowseLight.Name = "btnBrowseLight";
			this.btnBrowseLight.Size = new System.Drawing.Size(163, 30);
			this.btnBrowseLight.TabIndex = 5;
			this.btnBrowseLight.Text = "Browse for an image...";
			this.btnBrowseLight.UseVisualStyleBackColor = true;
			this.btnBrowseLight.Click += new System.EventHandler(this.btnBrowseLight_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Light";
			// 
			// dlgLight
			// 
			this.dlgLight.Filter = "Image files|*.png;*.jpg;*.jpeg;*.gif";
			this.dlgLight.Title = "Browse for light mode wallpaper...";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(359, 304);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(150, 30);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "✔ Save changes";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(12, 304);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(150, 30);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "❌ Discard changes";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// dlgDark
			// 
			this.dlgDark.Filter = "Image files|*.png;*.jpg;*.jpeg;*.gif";
			this.dlgDark.Title = "Browse for dark mode wallpaper...";
			// 
			// dlgColor
			// 
			this.dlgColor.FullOpen = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbnSystemDisabled);
			this.groupBox2.Controls.Add(this.rbnSystemEnabled);
			this.groupBox2.Location = new System.Drawing.Point(12, 14);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(171, 54);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Change system theme";
			// 
			// rbnSystemDisabled
			// 
			this.rbnSystemDisabled.AutoSize = true;
			this.rbnSystemDisabled.Location = new System.Drawing.Point(79, 24);
			this.rbnSystemDisabled.Name = "rbnSystemDisabled";
			this.rbnSystemDisabled.Size = new System.Drawing.Size(77, 21);
			this.rbnSystemDisabled.TabIndex = 1;
			this.rbnSystemDisabled.TabStop = true;
			this.rbnSystemDisabled.Text = "Disabled";
			this.rbnSystemDisabled.UseVisualStyleBackColor = true;
			// 
			// rbnSystemEnabled
			// 
			this.rbnSystemEnabled.AutoSize = true;
			this.rbnSystemEnabled.Checked = true;
			this.rbnSystemEnabled.Location = new System.Drawing.Point(6, 24);
			this.rbnSystemEnabled.Name = "rbnSystemEnabled";
			this.rbnSystemEnabled.Size = new System.Drawing.Size(73, 21);
			this.rbnSystemEnabled.TabIndex = 0;
			this.rbnSystemEnabled.TabStop = true;
			this.rbnSystemEnabled.Text = "Enabled";
			this.rbnSystemEnabled.UseVisualStyleBackColor = true;
			this.rbnSystemEnabled.CheckedChanged += new System.EventHandler(this.rbnSystemEnabled_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rbnAppDisabled);
			this.groupBox3.Controls.Add(this.rbnAppEnabled);
			this.groupBox3.Location = new System.Drawing.Point(12, 75);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(171, 57);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Change app theme";
			// 
			// rbnAppDisabled
			// 
			this.rbnAppDisabled.AutoSize = true;
			this.rbnAppDisabled.Location = new System.Drawing.Point(79, 25);
			this.rbnAppDisabled.Name = "rbnAppDisabled";
			this.rbnAppDisabled.Size = new System.Drawing.Size(77, 21);
			this.rbnAppDisabled.TabIndex = 1;
			this.rbnAppDisabled.TabStop = true;
			this.rbnAppDisabled.Text = "Disabled";
			this.rbnAppDisabled.UseVisualStyleBackColor = true;
			// 
			// rbnAppEnabled
			// 
			this.rbnAppEnabled.AutoSize = true;
			this.rbnAppEnabled.Checked = true;
			this.rbnAppEnabled.Location = new System.Drawing.Point(6, 25);
			this.rbnAppEnabled.Name = "rbnAppEnabled";
			this.rbnAppEnabled.Size = new System.Drawing.Size(73, 21);
			this.rbnAppEnabled.TabIndex = 0;
			this.rbnAppEnabled.TabStop = true;
			this.rbnAppEnabled.Text = "Enabled";
			this.rbnAppEnabled.UseVisualStyleBackColor = true;
			this.rbnAppEnabled.CheckedChanged += new System.EventHandler(this.rbnAppEnabled_CheckedChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(378, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 54);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(434, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 17);
			this.label5.TabIndex = 9;
			this.label5.Text = "Light Switch";
			// 
			// lblVersion
			// 
			this.lblVersion.AutoSize = true;
			this.lblVersion.Location = new System.Drawing.Point(434, 30);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(35, 17);
			this.lblVersion.TabIndex = 10;
			this.lblVersion.Text = "2.0.0";
			// 
			// llbGitHub
			// 
			this.llbGitHub.AutoSize = true;
			this.llbGitHub.Location = new System.Drawing.Point(434, 47);
			this.llbGitHub.Name = "llbGitHub";
			this.llbGitHub.Size = new System.Drawing.Size(48, 17);
			this.llbGitHub.TabIndex = 11;
			this.llbGitHub.TabStop = true;
			this.llbGitHub.Text = "GitHub";
			this.llbGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGitHub_LinkClicked);
			// 
			// PreferencesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 344);
			this.Controls.Add(this.llbGitHub);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PreferencesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Preferences";
			this.Load += new System.EventHandler(this.PreferencesForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxDark)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLight)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton rbnWallpaperIsEnabled;
		private System.Windows.Forms.RadioButton rdbWallpaperIsDisabled;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnBrowseLight;
		private System.Windows.Forms.OpenFileDialog dlgLight;
		private System.Windows.Forms.PictureBox pbxLight;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBrowseDark;
		private System.Windows.Forms.PictureBox pbxDark;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.OpenFileDialog dlgDark;
		private System.Windows.Forms.Button btnDarkColor;
		private System.Windows.Forms.Button btnLightColor;
		private System.Windows.Forms.ColorDialog dlgColor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbnSystemDisabled;
		private System.Windows.Forms.RadioButton rbnSystemEnabled;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rbnAppEnabled;
		private System.Windows.Forms.RadioButton rbnAppDisabled;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.LinkLabel llbGitHub;
	}
}