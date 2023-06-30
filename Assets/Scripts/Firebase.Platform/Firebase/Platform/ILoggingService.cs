namespace Firebase.Platform
{
	internal interface ILoggingService
	{
		void LogMessage(PlatformLogLevel level, string message);
	}
}
