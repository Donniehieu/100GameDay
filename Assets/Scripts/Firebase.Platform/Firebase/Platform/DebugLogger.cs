namespace Firebase.Platform
{
	internal class DebugLogger : ILoggingService
	{
		private static DebugLogger _instance;

		public static DebugLogger Instance => null;

		public void LogMessage(PlatformLogLevel level, string message)
		{
		}
	}
}
