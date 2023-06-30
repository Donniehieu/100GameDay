using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Firebase.Platform;

namespace Firebase
{
	public sealed class FirebaseApp : IDisposable
	{
		public class EnableModuleParams
		{
			public string CppModuleName
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

			public string CSharpClassName
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

			public bool AlwaysEnable
			{
				[CompilerGenerated]
				get
				{
					return false;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public EnableModuleParams(string csharp, string cpp, bool always = false)
			{
			}
		}

		private delegate FirebaseApp CreateDelegate();

		private HandleRef swigCPtr;

		private bool swigCMemOwn;

		internal static readonly object disposeLock;

		private string name;

		private static Dictionary<string, FirebaseApp> nameToProxy;

		private static Dictionary<IntPtr, FirebaseApp> cPtrToProxy;

		private static bool AppUtilCallbacksInitialized;

		private static object AppUtilCallbacksLock;

		private static bool PreventOnAllAppsDestroyed;

		private static bool crashlyticsInitializationAttempted;

		private const int CheckDependenciesNoThread = -1;

		private const int CheckDependenciesPendingThread = -2;

		private static int CheckDependenciesThread;

		private static object CheckDependenciesThreadLock;

		private FirebaseAppPlatform appPlatform;

		public static FirebaseApp DefaultInstance => null;

		public string Name => null;

		public static LogLevel LogLevel
		{
			get
			{
				return default(LogLevel);
			}
			set
			{
			}
		}

		private bool IsDataCollectionDefaultEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AppOptions Options => null;

		internal static SynchronizationContext ThreadSynchronizationContext => null;

		internal FirebaseAppPlatform AppPlatform => null;

		internal string NameInternal => null;

		public static string DefaultName => null;

		internal event EventHandler AppDisposed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal FirebaseApp(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(FirebaseApp obj)
		{
			return default(HandleRef);
		}

		~FirebaseApp()
		{
		}

		public void Dispose()
		{
		}

		public void Dispose(bool disposing)
		{
		}

		static FirebaseApp()
		{
		}

		internal static void TranslateDllNotFoundException(Action closureToExecute)
		{
		}

		public static FirebaseApp GetInstance(string name)
		{
			return null;
		}

		public static FirebaseApp Create()
		{
			return null;
		}

		public static FirebaseApp Create(AppOptions options)
		{
			return null;
		}

		public static FirebaseApp Create(AppOptions options, string name)
		{
			return null;
		}

		internal static void DisposeAllApps()
		{
		}

		private void AddReference()
		{
		}

		private void RemoveReference()
		{
		}

		private void ThrowIfNull()
		{
		}

		private static void InitializeAppUtilCallbacks()
		{
		}

		private static void OnAllAppsDestroyed()
		{
		}

		internal static Uri UrlStringToUri(string urlString)
		{
			return null;
		}

		internal static string UriToUrlString(Uri uri)
		{
			return null;
		}

		internal static object WeakReferenceGetTarget(WeakReference weakReference)
		{
			return null;
		}

		private static bool InitializeCrashlyticsIfPresent()
		{
			return false;
		}

		private static FirebaseApp CreateAndTrack(CreateDelegate createDelegate, FirebaseApp existingProxy)
		{
			return null;
		}

		private static void SetCheckDependenciesThread(int threadId)
		{
		}

		private static void ThrowIfCheckDependenciesRunning()
		{
		}

		private static bool IsCheckDependenciesRunning()
		{
			return false;
		}

		public static Task<DependencyStatus> CheckDependenciesAsync()
		{
			return null;
		}

		public static Task<DependencyStatus> CheckAndFixDependenciesAsync()
		{
			return null;
		}

		private static DependencyStatus CheckDependencies()
		{
			return default(DependencyStatus);
		}

		private static DependencyStatus CheckDependenciesInternal()
		{
			return default(DependencyStatus);
		}

		public static Task FixDependenciesAsync()
		{
			return null;
		}

		private static void ResetDefaultAppCPtr()
		{
		}

		internal AppOptionsInternal options()
		{
			return null;
		}

		internal void SetDataCollectionDefaultEnabledInternal(bool enabled)
		{
		}

		internal bool IsDataCollectionDefaultEnabledInternal()
		{
			return false;
		}

		internal static FirebaseApp CreateInternal()
		{
			return null;
		}

		internal static FirebaseApp CreateInternal(AppOptionsInternal options)
		{
			return null;
		}

		internal static FirebaseApp CreateInternal(AppOptionsInternal options, string name)
		{
			return null;
		}

		internal static void ReleaseReferenceInternal(FirebaseApp app)
		{
		}

		internal static void SetLogLevelInternal(LogLevel level)
		{
		}

		internal static LogLevel GetLogLevelInternal()
		{
			return default(LogLevel);
		}

		internal static void RegisterLibraryInternal(string library, string version)
		{
		}

		internal static void LogHeartbeatInternal(FirebaseApp app)
		{
		}

		internal static void AppSetDefaultConfigPath(string path)
		{
		}
	}
}
