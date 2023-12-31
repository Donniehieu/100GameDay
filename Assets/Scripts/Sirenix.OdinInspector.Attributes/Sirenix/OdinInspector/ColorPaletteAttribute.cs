using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class ColorPaletteAttribute : Attribute
	{
		public string PaletteName;

		public bool ShowAlpha;

		public ColorPaletteAttribute()
		{
		}

		public ColorPaletteAttribute(string paletteName)
		{
		}
	}
}
