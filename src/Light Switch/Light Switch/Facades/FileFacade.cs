using System;
using System.IO;
using System.Linq;

namespace LightSwitch.Facades
{
	class FileFacade
	{
		private string _tempDir = Path.GetTempPath() + "LightSwitch\\";

		private string GetTempFilename()
		{
			var dt = new DateTime(2020, 01, 01);
			var now = DateTime.UtcNow;
			var span = now - dt;
			return span.TotalMilliseconds.ToString();
		}

		/// <summary>
		/// Makes a copy to system temporary directory with a generated filename.
		/// </summary>
		/// <returns>Returns full file path.</returns>
		public string SaveToTemp(string subfolder, string filename)
		{
			if (!File.Exists(filename))
			{
				return filename;
			}

			var sourceFile = new FileInfo(filename);
			var destDir = new DirectoryInfo(Path.Combine(_tempDir, subfolder));

			if (sourceFile.DirectoryName == destDir.FullName)
			{
				return filename;
			}

			if (!destDir.Exists)
			{
				destDir.Create();
			}

			var dest = Path.Combine(destDir.FullName, GetTempFilename() + sourceFile.Extension);

			File.Copy(filename, dest, true);

			return dest;
		}

		/// <summary>
		/// Deletes all files in temporary directory except for the exceptions specified.
		/// </summary>
		public void ClearTemp(string subfolder, params string[] exceptions)
		{
			foreach (var file in new DirectoryInfo(_tempDir + subfolder).GetFiles())
			{
				if (!exceptions.Contains(file.FullName))
				{
					file.Delete();
				}
			}
		}
	}
}
