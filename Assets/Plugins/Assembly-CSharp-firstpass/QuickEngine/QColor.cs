using System;
using UnityEngine;

namespace QuickEngine
{
	[Serializable]
	public class QColor
	{
		private Color color;

		private Color colorDark;

		private Color colorLight;

		public Color Color => default(Color);

		public Color ColorDark => default(Color);

		public Color ColorLight => default(Color);

		public float ColorBrightness => 0f;

		public float ColorDarkBrightness => 0f;

		public float ColorLightBrightness => 0f;

		public Color ColorOpaque => default(Color);

		public Color ColorDarkOpaque => default(Color);

		public Color ColorLightOpaque => default(Color);

		public Color ColorInvert => default(Color);

		public Color ColorDarkInvert => default(Color);

		public Color ColorLightInvert => default(Color);

		public QColor(Color color)
		{
		}

		public QColor(Color color, float alpha)
		{
		}

		public QColor(float r, float g, float b, bool from256 = true)
		{
		}

		public QColor(float r, float g, float b, float a, bool from256 = true)
		{
		}

		public void SetColor(Color color)
		{
		}

		public Color ColorWithBrightness(float brightness)
		{
			return default(Color);
		}

		public Color ColorDarkWithBrightness(float brightness)
		{
			return default(Color);
		}

		public Color ColorLightWithBrightness(float brightness)
		{
			return default(Color);
		}

		public Color ColorWithAlpha(float alpha)
		{
			return default(Color);
		}

		public Color ColorDarkWithAlpha(float alpha)
		{
			return default(Color);
		}

		public Color ColorLightWithAlpha(float alpha)
		{
			return default(Color);
		}
	}
}
