namespace LightSwitch
{
	internal abstract class TypeSafeEnum
	{
		/// <summary>
		/// Instantiates a <see cref="TypeSafeEnum"/> with the provided parameters.
		/// </summary>
		/// <param name="name">The name of the value.</param>
		protected TypeSafeEnum(string name)
		{
			Name = name;
		}

		/// <summary>
		/// The name of the value.
		/// </summary>
		public string Name { get; }
	}
}
