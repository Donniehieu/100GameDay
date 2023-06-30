using System.Runtime.CompilerServices;
using System.Threading;

namespace Firebase.Platform
{
	internal static class PlatformInformation
	{
		private static string runtimeVersion;

		internal static bool IsAndroid => false;

		internal static bool IsIOS => false;

		internal static string DefaultConfigLocation => null;

		internal static SynchronizationContext SynchronizationContext => null;

		internal static float RealtimeSinceStartup => 0f;

		internal static float RealtimeSinceStartupSafe
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal static string RuntimeName => null;

		internal static string RuntimeVersion => null;
	}
}
