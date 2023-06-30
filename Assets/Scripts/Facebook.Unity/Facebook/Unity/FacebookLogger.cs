using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal static class FacebookLogger
	{
		private class DebugLogger : IFacebookLogger
		{
			public void Log(string msg)
			{
			}

			public void Info(string msg)
			{
			}

			public void Warn(string msg)
			{
			}

			public void Error(string msg)
			{
			}
		}

		internal static IFacebookLogger Instance
		{
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		static FacebookLogger()
		{
		}

		public static void Log(string msg)
		{
		}

		public static void Log(string format, params string[] args)
		{
		}

		public static void Info(string msg)
		{
		}

		public static void Info(string format, params string[] args)
		{
		}

		public static void Warn(string msg)
		{
		}

		public static void Warn(string format, params string[] args)
		{
		}

		public static void Error(string msg)
		{
		}

		public static void Error(string format, params string[] args)
		{
		}
	}
}
