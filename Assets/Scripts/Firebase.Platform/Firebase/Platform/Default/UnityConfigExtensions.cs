namespace Firebase.Platform.Default
{
	internal class UnityConfigExtensions : AppConfigExtensions
	{
		private static UnityConfigExtensions _instance;

		public static IAppConfigExtensions DefaultInstance => null;

		public override string GetWriteablePath(IFirebaseAppPlatform app)
		{
			return null;
		}

		public override void SetEditorP12FileName(IFirebaseAppPlatform app, string p12Filename)
		{
		}
	}
}
