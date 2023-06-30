using System;
using System.Runtime.CompilerServices;

namespace Firebase.Platform
{
	internal class FirebaseAppPlatform : IFirebaseAppPlatform
	{
		private WeakReference app
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public object AppObject => null;

		internal FirebaseApp App => null;

		public string Name => null;

		public Uri DatabaseUrl => null;

		internal FirebaseAppPlatform(FirebaseApp wrappedApp)
		{
		}
	}
}
