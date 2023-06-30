using UnityEngine;

namespace BigBear.Core.Runtime.Extensions
{
	public static class ColorExtensions
	{
		private const float LightOffset = 0.0625f;

		private const float DarkerFactor = 0.9f;

		public static Color ColorFrom256(this Color color, float r, float g, float b, float a = 256f)
		{
			return default(Color);
		}

		public static Color ColorFrom256(float r, float g, float b, float a = 256f)
		{
			return default(Color);
		}

		public static Color Lighter(this Color color)
		{
			return default(Color);
		}

		public static Color Darker(this Color color)
		{
			return default(Color);
		}

		public static float Brightness(this Color color)
		{
			return 0f;
		}

		public static Color WithBrightness(this Color color, float brightness)
		{
			return default(Color);
		}

		public static bool IsApproximatelyBlack(this Color color)
		{
			return false;
		}

		public static bool IsApproximatelyWhite(this Color color)
		{
			return false;
		}

		public static Color Opaque(this Color color)
		{
			return default(Color);
		}

		public static Color Invert(this Color color)
		{
			return default(Color);
		}

		public static Color WithAlpha(this Color color, float alpha)
		{
			return default(Color);
		}
	}
}
