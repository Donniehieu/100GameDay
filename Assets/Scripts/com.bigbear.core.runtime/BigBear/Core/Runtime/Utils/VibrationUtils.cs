using UnityEngine;

namespace BigBear.Core.Runtime.Utils
{
	public static class VibrationUtils
	{
		public static AndroidJavaClass unityPlayer;

		public static AndroidJavaObject currentActivity;

		public static AndroidJavaObject vibrator;

		public static void Vibrate()
		{
		}

		public static void Vibrate(long milliseconds)
		{
		}

		public static void Vibrate(long[] pattern, int repeat)
		{
		}

		public static bool HasVibrator()
		{
			return false;
		}

		public static void Cancel()
		{
		}

		private static bool isAndroid()
		{
			return false;
		}
	}
}
