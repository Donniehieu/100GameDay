using System;
using System.Collections.Generic;

namespace Firebase.Platform.Default
{
	internal class AppConfigExtensions : IAppConfigExtensions
	{
		private enum ExtraStringState
		{
			DatabaseUrl = 0,
			P12FileName = 1,
			P12Password = 2,
			ServiceAccountEmail = 3,
			CertTxtFileName = 4,
			WebCertUpdateUrl = 5
		}

		private static readonly Uri DefaultUpdateUrl;

		private static readonly string Default;

		private static readonly object Sync;

		private static AppConfigExtensions _instance;

		private static readonly Dictionary<int, Dictionary<string, string>> SStringState;

		public static IAppConfigExtensions Instance => null;

		protected AppConfigExtensions()
		{
		}

		public virtual string GetWriteablePath(IFirebaseAppPlatform app)
		{
			return null;
		}

		public virtual void SetDatabaseUrl(IFirebaseAppPlatform app, string databaseUrl)
		{
		}

		public virtual string GetDatabaseUrl(IFirebaseAppPlatform app)
		{
			return null;
		}

		public virtual void SetEditorP12Password(IFirebaseAppPlatform app, string p12Password)
		{
		}

		public virtual string GetEditorP12Password(IFirebaseAppPlatform app)
		{
			return null;
		}

		public virtual void SetEditorP12FileName(IFirebaseAppPlatform app, string p12Filename)
		{
		}

		public virtual string GetEditorP12FileName(IFirebaseAppPlatform app)
		{
			return null;
		}

		public virtual void SetEditorServiceAccountEmail(IFirebaseAppPlatform app, string email)
		{
		}

		public virtual string GetEditorServiceAccountEmail(IFirebaseAppPlatform app)
		{
			return null;
		}

		public virtual void SetCertPemFile(IFirebaseAppPlatform app, string certName)
		{
		}

		public virtual string GetCertPemFile(IFirebaseAppPlatform app)
		{
			return null;
		}

		public void SetCertUpdateUrl(IFirebaseAppPlatform app, Uri certUrl)
		{
		}

		public Uri GetCertUpdateUrl(IFirebaseAppPlatform app)
		{
			return null;
		}

		private static T GetState<T>(IFirebaseAppPlatform app, int state, Dictionary<int, Dictionary<string, T>> store)
		{
			return default(T);
		}

		private static void SetState<T>(IFirebaseAppPlatform app, int state, T value, Dictionary<int, Dictionary<string, T>> store)
		{
		}
	}
}
