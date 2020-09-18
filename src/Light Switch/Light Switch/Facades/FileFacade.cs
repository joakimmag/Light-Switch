using System;
using System.IO;
using System.Linq;

namespace LightSwitch.Facades
{
	class FileFacade
	{
		private readonly string _tempDir = Path.GetTempPath() + "LightSwitch\\";

		private string GetPathToFolder(string folder)
		{
			return Path.Combine(_tempDir, folder);
		}

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
		public string SaveToTemp(string folder, string sourcePath)
		{
			if (!File.Exists(sourcePath))
			{
				return sourcePath;
			}

			var sourceFile = new FileInfo(sourcePath);
			var destDir = new DirectoryInfo(GetPathToFolder(folder));

			if (sourceFile.DirectoryName == destDir.FullName)
			{
				return sourcePath;
			}

			if (!destDir.Exists)
			{
				destDir.Create();
			}

			var destPath = Path.Combine(destDir.FullName, GetTempFilename() + sourceFile.Extension);

			File.Copy(sourcePath, destPath, true);

			return destPath;
		}

		/// <summary>
		/// Deletes all files in temporary directory except for the exceptions specified.
		/// </summary>
		public void ClearTemp(string folder, params string[] exceptions)
		{
			var dir = new DirectoryInfo(GetPathToFolder(folder));

			if (!dir.Exists)
			{
				return;
			}

			foreach (var file in dir.GetFiles())
			{
				if (!exceptions.Contains(file.FullName))
				{
					file.Delete();
				}
			}
		}
	}
}
