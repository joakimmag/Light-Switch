using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace LightSwitch
{
	internal class Storage : TypeSafeEnum
	{
		/// <summary>
		/// Instantiates a <see cref="Storage"/> with the provided parameters.
		/// </summary>
		/// <param name="name">The name of the storage.</param>
		private Storage(string name) : base(name)
		{
			Directory = new(Path.Combine(BasePath, Name));

			if (!Directory.Exists)
			{
				Directory.Create();
			}
		}

		/// <summary>
		/// Gets the directory info object.
		/// </summary>
		public DirectoryInfo Directory { get; }

		/// <summary>
		/// Try to copy the file at <paramref name="fromFile"/> to this storage.
		/// If <paramref name="fromFile"/> is this storage it will not make a copy and return true.
		/// </summary>
		/// <param name="fromFile">The file to copy.</param>
		/// <param name="toFile">The new file.</param>
		/// <returns>Returns true if successful.</returns>
		public bool TryImport(FileInfo fromFile, out FileInfo toFile)
		{
			if (!fromFile.Exists)
			{
				toFile = null;
				return false;
			}

			if (fromFile.DirectoryName == Directory.FullName)
			{
				toFile = fromFile;
				return true;
			}

			toFile = new(Path.Combine(Directory.FullName, $"{GenerateUniqueString()}{fromFile.Extension}"));
			fromFile.CopyTo(toFile.FullName, true);
			return true;
		}

		/// <summary>
		/// Delete all files in storage except for specified exceptions.
		/// </summary>
		/// <param name="exceptions">Files to skip deletion.</param>
		public void Clear(params FileInfo[] exceptions)
		{
			foreach (var file in Directory.GetFiles())
			{
				if (!exceptions.Contains(file, new FilePathComparer()))
				{
					file.Delete();
				}
			}
		}

		/// <summary>
		/// Equality comparison for FileInfo objects.
		/// </summary>
		private class FilePathComparer : IEqualityComparer<FileInfo>
		{
			/// <summary>Returns x.FullName == y.FullName.</summary>
			public bool Equals(FileInfo x, FileInfo y)
			{
				if (x is null)
				{
					return false;
				}

				return x.FullName == y.FullName;
			}

			public int GetHashCode([DisallowNull] FileInfo obj) => obj.GetHashCode();
		}

		/// <summary>
		/// Converts a <see cref="string"/> to a <see cref="Storage"/>.
		/// </summary>
		/// <param name="storageName">The string value to convert.</param>
		public static implicit operator Storage(string storageName) => storageName switch
		{
			nameof(Wallpapers) => Wallpapers,
			_ => null,
		};

		/// <summary>
		/// Path to LightSwitch storage in current user's temp folder.
		/// </summary>
		private static string BasePath { get; } = Path.Combine(Path.GetTempPath(), "LightSwitch");

		public static readonly Storage Wallpapers = new(nameof(Wallpapers));

		/// <summary>
		/// Generates a unique string from current date and time.
		/// </summary>
		private static string GenerateUniqueString()
		{
			var now = DateTime.Now;
			return $"{now.Year}{now.Month}{now.Day}{now.Hour}{now.Minute}{now.Second}{now.Millisecond}";
		}
	}
}
