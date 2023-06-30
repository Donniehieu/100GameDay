using System;

namespace Firebase.Platform
{
	internal class FirebaseAppUtils : IFirebaseAppUtils
	{
		private static FirebaseAppUtils instance;

		public static FirebaseAppUtils Instance => null;

		public void TranslateDllNotFoundException(Action action)
		{
		}

		public void PollCallbacks()
		{
		}

		public IFirebaseAppPlatform GetDefaultInstance()
		{
			return null;
		}

		public string GetDefaultInstanceName()
		{
			return null;
		}

		public PlatformLogLevel GetLogLevel()
		{
			return default(PlatformLogLevel);
		}
	}
}
