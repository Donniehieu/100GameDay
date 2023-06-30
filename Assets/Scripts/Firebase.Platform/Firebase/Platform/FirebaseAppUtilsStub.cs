using System;

namespace Firebase.Platform
{
	internal class FirebaseAppUtilsStub : IFirebaseAppUtils
	{
		private static FirebaseAppUtilsStub _instance;

		public static FirebaseAppUtilsStub Instance => null;

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
