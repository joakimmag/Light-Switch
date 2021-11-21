namespace LightSwitch
{
	internal sealed class Theme : TypeSafeEnum
	{
		/// <summary>
		/// Instantiates a <see cref="Theme"/> with the provided parameters.
		/// </summary>
		/// <param name="name">The name of the theme.</param>
		private Theme(string name) : base(name)
		{
		}

		/// <summary>
		/// Converts a <see cref="string"/> to a <see cref="Theme"/>.
		/// </summary>
		/// <param name="themeName">The string value to convert.</param>
		public static implicit operator Theme(string themeName) => themeName switch
		{
			nameof(Light) => Light,
			nameof(Dark) => Dark,
			_ => null,
		};

		public static readonly Theme Light = new(nameof(Light));
		public static readonly Theme Dark = new(nameof(Dark));
	}
}
