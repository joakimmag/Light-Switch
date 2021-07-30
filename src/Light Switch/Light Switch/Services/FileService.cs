using System;
using System.IO;
using System.Linq;

namespace LightSwitch.Services
{
	class FileService
	{
		/// <summary>
		/// Path to LightSwitch storage in current user's temp folder.
		/// </summary>
		private readonly string _temp = Path.Combine(Path.GetTempPath(), "LightSwitch");

		/// <summary>
		/// Gets the directory info object.
		/// </summary>
		private DirectoryInfo GetDirectory(string directoryName) => new(Path.Combine(_temp, directoryName));

		/// <summary>
		/// Generates a file name for use in application storage.
		/// </summary>
		private static string GetNewFilename()
		{
			var dt = new DateTime(2020, 01, 01);
			var now = DateTime.UtcNow;
			var span = now - dt;
			return span.TotalMilliseconds.ToString();
		}

		/// <summary>
		/// Copies the file to storage.
		/// </summary>
		/// <returns>Returns path to file in storage. Returns source path if the source path does not exist.</returns>
		public string CopyToStorage(string storageDirectory, string sourcePath)
		{
			var sourceFileInfo = new FileInfo(sourcePath);

			if (!sourceFileInfo.Exists)
			{
				return sourcePath;
			}

			var storage = GetDirectory(storageDirectory);

			if (sourceFileInfo.DirectoryName == storage.FullName)
			{
				return sourcePath;
			}

			if (!storage.Exists)
			{
				storage.Create();
			}

			var destinationPath = Path.Combine(storage.FullName, GetNewFilename() + sourceFileInfo.Extension);

			sourceFileInfo.CopyTo(destinationPath, true);

			return destinationPath;
		}

		/// <summary>
		/// Clears application storage except from specified exceptions.
		/// </summary>
		public void ClearStorage(string storageDirectory, params string[] exceptions)
		{
			var storage = GetDirectory(storageDirectory);

			if (!storage.Exists)
			{
				return;
			}

			foreach (var file in storage.GetFiles())
			{
				if (!exceptions.Contains(file.FullName))
				{
					file.Delete();
				}
			}
		}
	}
}
