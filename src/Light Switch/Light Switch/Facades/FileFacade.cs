using System;
using System.IO;
using System.Linq;

namespace LightSwitch.Facades
{
	class FileFacade
	{
		private readonly string _temp = Path.GetTempPath() + "LightSwitch\\";

		/// <summary>
		/// Gets full path to directory.
		/// </summary>
		private string GetPath(string directory)
		{
			return Path.Combine(_temp, directory);
		}

		/// <summary>
		/// Generates a file name for use in application storage.
		/// </summary>
		private string GetFilename()
		{
			var dt = new DateTime(2020, 01, 01);
			var now = DateTime.UtcNow;
			var span = now - dt;
			return span.TotalMilliseconds.ToString();
		}

		/// <summary>
		/// Copies the file to application storage.
		/// </summary>
		/// <returns>Returns path to file in application storage. Returns source path if the source path does not exist.</returns>
		public string CopyToStorage(string storageDirectory, string sourcePath)
		{
			var sourceFileInfo = new FileInfo(sourcePath);

			if (!sourceFileInfo.Exists)
			{
				return sourcePath;
			}

			var storageDirInfo = new DirectoryInfo(GetPath(storageDirectory));

			if (sourceFileInfo.DirectoryName == storageDirInfo.FullName)
			{
				return sourcePath;
			}

			if (!storageDirInfo.Exists)
			{
				storageDirInfo.Create();
			}

			var destinationPath = Path.Combine(storageDirInfo.FullName, GetFilename() + sourceFileInfo.Extension);

			sourceFileInfo.CopyTo(destinationPath, true);

			return destinationPath;
		}

		/// <summary>
		/// Clears application storage except from specified exceptions.
		/// </summary>
		public void ClearStorage(string storageDirectory, params string[] exceptions)
		{
			var storageDirInfo = new DirectoryInfo(GetPath(storageDirectory));

			if (!storageDirInfo.Exists)
			{
				return;
			}

			foreach (var file in storageDirInfo.GetFiles())
			{
				if (!exceptions.Contains(file.FullName))
				{
					file.Delete();
				}
			}
		}
	}
}
