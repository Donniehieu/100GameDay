using UnityEngine;

namespace Lean.Common
{
	public static class LeanHelper
	{
		public const string HelpUrlPrefix = "https://carloswilkes.github.io/Documentation/LeanCommon#";

		public const string PlusHelpUrlPrefix = "https://carloswilkes.github.io/Documentation/LeanCommonPlus#";

		public const string ComponentPathPrefix = "Lean/";

		public static T CreateElement<T>(Transform parent) where T : Component
		{
			return null;
		}

		public static float GetDampenFactor(float damping, float elapsed)
		{
			return 0f;
		}

		public static T Destroy<T>(T o) where T : Object
		{
			return null;
		}

		public static Camera GetCamera(Camera currentCamera, GameObject gameObject = null)
		{
			return null;
		}

		public static Vector2 Hermite(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t)
		{
			return default(Vector2);
		}

		private static float HermiteInterpolate(float y0, float y1, float y2, float y3, float mu, float mu2, float mu3)
		{
			return 0f;
		}
	}
}
